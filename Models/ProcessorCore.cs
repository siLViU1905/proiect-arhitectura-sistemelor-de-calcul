namespace proiect_arhitectura_sistemelor_de_calcul.Models;

public class ProcessorCore
{
    private List<MicroInstruction> rom = new List<MicroInstruction>();
    private Memory memory = new Memory();

    private int microProgramCounter = 0;
    
    private IReadOnlyDictionary<string, InstructionDef> opcodesMap = new Dictionary<string, InstructionDef>();
    
    public DecodeInstruction? DecodedInstruction { get; private set; }
    
    public int[] GeneralRegisters { get; private set; } = new int[16];
    public int ProgramCounter { get; private set; }
    public int InstructionRegister { get; private set; }
    public int Flags {get; private set;}
    public int StackPointer { get; private set; }
    
    public int MemoryAddressRegister { get; private set; }
    public int MemoryDataRegister { get; private set; }
    public int T { get; private set; }
    public int Ivr {get; private set; }
    
    public int CurrentSbusValue { get; private set; }
    public int CurrentDbusValue { get; private set; }
    public int CurrentAluValue { get; private set; }
    public string CurrentAluOperation { get; private set; }
    
    public bool IsHalted { get; private set; } = false;

    public ProcessorCore(List<MicroInstruction> romData, IReadOnlyDictionary<string, InstructionDef> opcodesMap)
    {
        rom = romData;
        this.opcodesMap = opcodesMap;
    }

    private int ComputeSbus(MicroInstruction microInstruction)
    {
        return microInstruction.SbusText switch
        {
            "PdPCs" => ProgramCounter,
            "PdSPs" => StackPointer,
            "PdRGs" => GeneralRegisters[(InstructionRegister >> 6) & 0xF],
            "PdTs" => T,
            "PdTsNeg" => -T,
            "PdFLAGs" => Flags,
            "PdMDRs" => MemoryDataRegister,
            "PdIVRs" => Ivr,
            "PdADRs" => MemoryAddressRegister,
            "Pd0s" => 0,
            "Pd-1s" => -1,
            "NONE" => 0
        };
    }

    private int ComputeDbus(MicroInstruction microInstruction)
    {
        return microInstruction.DbusText switch
        {
            "PdRGd" => GeneralRegisters[InstructionRegister & 0xF],
            "PdMDRd" => MemoryDataRegister,
            "PdMDRdNeg" => (-MemoryDataRegister) & 0xFFFF,
            "PdPCd" => ProgramCounter,
            "PdIR [7…0]d" => InstructionRegister & 0xFF,
            "Pd0d" => 0,
            "NONE" => 0
        };
    }

    private int ComputeAlu(MicroInstruction microInstruction, int sbusValue, int dbusValue)
    {
        CurrentAluOperation = microInstruction.AluText;
        
        int result = microInstruction.AluText switch
        {
            "SBUS" => sbusValue,
            "DBUS" => dbusValue,
            "SUM" => sbusValue + dbusValue,
            "AND" => T & dbusValue,
            "OR" => T | dbusValue,
            "XOR" => T ^ dbusValue,
            "ASL" => dbusValue << 1,
            "ASR" => dbusValue >> 1,
            "LSR" => (int)((uint)dbusValue >> 1),
            "ROL" => ((dbusValue << 1) | (dbusValue >> 15)) & 0xFFFF,
            "ROR" => ((dbusValue >> 1) | (dbusValue << 15)) & 0xFFFF,
            "RLC" => ((dbusValue << 1) | ((Flags >> 3) & 1)) & 0xFFFF,
            "RRC" => ((dbusValue >> 1) | (((Flags >> 3) & 1) << 15)) & 0xFFFF,
            "NONE" => 0
        };
        
        CurrentAluValue = result & 0xFFFF;

        return result;
    }
    
    private void WriteRbus(MicroInstruction microInstruction, int aluResult)
    {
        switch (microInstruction.RbusText)
        {
            case "PmPC":
                ProgramCounter = aluResult;
                break;
            case "PmSP":
                StackPointer = aluResult;
                break;
            case "PmRG":
                GeneralRegisters[InstructionRegister & 0xF] = aluResult;
                break;
            case "PmT":
                T = aluResult;
                break;
            case "PmFLAG":
                Flags = aluResult & 0xF;
                break;
            case "PmMDR":
                MemoryDataRegister = aluResult;
                break;
            case "PmADR":
                MemoryAddressRegister = aluResult;
                break;
            case "NONE":
                break;
            default:
                throw new InvalidOperationException($"Unknown RBUS: {microInstruction.RbusText}");
        }
    }
    
    private void HandleMemory(MicroInstruction microInstruction)
    {
        switch (microInstruction.MemoryText)
        {
            case "READ":
                MemoryDataRegister = memory.Read(MemoryAddressRegister);
                break;
            case "IFCH": 
                MemoryDataRegister = memory.Read(MemoryAddressRegister);
                InstructionRegister = MemoryDataRegister;
                break;
            case "WRITE":
                memory.Write(MemoryAddressRegister, MemoryDataRegister);
                break;
            case "NONE":
                break;
            default:
                throw new InvalidOperationException($"Unknown memory operation: {microInstruction.MemoryText}");
        }
    }

    private void HandleOtherOperations(MicroInstruction microInstruction, int aluResult)
    {
        switch (microInstruction.OtherOperationsText)
        {
            case "+2PC":
                ProgramCounter += 2;
                break;
            case "-2SP":
                StackPointer -= 2;
                break;
            case "+2SP":
                StackPointer += 2;
                break;
            case "Cin,PdCONDaritm":
                aluResult += (Flags >> 0) & 1;
                UpdateArithmeticFlags(aluResult);
                break;
            case "PdCONDaritm":
                UpdateArithmeticFlags(aluResult);
                break;
            case "PdCONDlog":
                UpdateLogicFlags(aluResult);
                break;
            case "INTA,-2SP":
                StackPointer -= 2;
                break;
            case "A(1)BE1":
            case "A(0)BE,A(0)BI":
            case "A(1)BVI":
            case "A(0)BVI":
            case "A(1)BE0":
            case "A(0)BPO":
                break;
            case "NONE":
                break;
            default:
                throw new InvalidOperationException($"Unknown operation: {microInstruction.OtherOperationsText}");
        }
    }

    private void UpdateArithmeticFlags(int result)
    {
        bool negativeFlag = (result & 0x8000) != 0;
        bool zeroFlag = (result & 0xFFFF) == 0;
        bool carryFlag = result > 0xFFFF || result < 0;
        bool overflowFlag = result > 32767 || result < -32768;
        
        Flags = (negativeFlag ? 1 : 0) << 3 |
                (zeroFlag     ? 1 : 0) << 2 |
                (overflowFlag ? 1 : 0) << 1 |
                (carryFlag    ? 1 : 0);
    }
    
    private void UpdateLogicFlags(int result)
    {
        bool negativeFlag = (result & 0x8000) != 0;
        bool zeroFlag = (result & 0xFFFF) == 0;

        Flags = (negativeFlag ? 1 : 0) << 3 |
                (zeroFlag     ? 1 : 0) << 2;
    }
    
    private int ComputeNextMicroAddress(MicroInstruction microInstruction) 
    {
        bool zeroFlag    = ((Flags >> 2) & 1) == 1;
        bool signFlag    = ((Flags >> 3) & 1) == 1;
        bool carryFlag   = ((Flags >> 0) & 1) == 1;
        bool overflowFlag = ((Flags >> 1) & 1) == 1;
        
        bool inversion = microInstruction.InversionText == "F";

        switch (microInstruction.SuccessorText)
        {
            case "STEP":
                return microProgramCounter + 1;

            case "JUMPI":
                int index = ComputeIndex(microInstruction.IndexSelectionValue);
                return microInstruction.JumpAddressValue + index;

            case "IF Z JUMPI":
                return ShouldJump(zeroFlag, inversion)
                    ? microInstruction.JumpAddressValue + ComputeIndex(microInstruction.IndexSelectionValue)
                    : microProgramCounter + 1;

            case "IF S JUMPI":
                return ShouldJump(signFlag, inversion)
                    ? microInstruction.JumpAddressValue + ComputeIndex(microInstruction.IndexSelectionValue)
                    : microProgramCounter + 1;

            case "IF C JUMPI":
                return ShouldJump(carryFlag, inversion)
                    ? microInstruction.JumpAddressValue + ComputeIndex(microInstruction.IndexSelectionValue)
                    : microProgramCounter + 1;

            case "IF V JUMPI":
                return ShouldJump(overflowFlag, inversion)
                    ? microInstruction.JumpAddressValue + ComputeIndex(microInstruction.IndexSelectionValue)
                    : microProgramCounter + 1;

            case "IF ACLOW JUMPI":
            {
                int sourceMode = (InstructionRegister >> 10) & 0x3;
                return ShouldJump(false, inversion)
                    ? microInstruction.JumpAddressValue + ComputeIndex(microInstruction.IndexSelectionValue)
                    : microProgramCounter + 1;
            }

            case "IF CIL JUMPI":
            {
                int sourceMode = (InstructionRegister >> 10) & 0x3;
                return ShouldJump(false, inversion)
                    ? microInstruction.JumpAddressValue + ComputeIndex(microInstruction.IndexSelectionValue)
                    : microProgramCounter + 1;

            }
                
            default:
                throw new InvalidOperationException($"Unknown successor: {microInstruction.SuccessorText}");
        }
    }
    
    private int ComputeIndex(int indexSelection)
    {
        switch (indexSelection)
        {
            case 0: 
                return 0;
        
            case 1: 
                return (InstructionRegister >> 14) & 0x3;
        
            case 2: 
                return (InstructionRegister >> 10) & 0x3;
        
            case 3: 
                return ((InstructionRegister >> 4) & 0x3);
        
            case 4: 
                return (InstructionRegister >> 12) & 0x7;
        
            case 5:
                if (((InstructionRegister >> 14) & 0x3) == 0x2) 
                    return (InstructionRegister >> 6) & 0x3F;
                return (InstructionRegister >> 12) & 0xF; 
        
            case 6: 
                return (InstructionRegister >> 1) & 0x3F;
        
            case 7: 
                return 0;
        
            default:
                return 0;
        }
    }
    
    private bool ShouldJump(bool condition, bool inversion)
    {
        if (inversion)
            return !condition;
        return condition;
    }
    
    private bool HandleBranchInstructions(MicroInstruction microInstruction)
    {
        if (microInstruction.Label is not ("BEQ:" or "BNE:" or "BMI:" or
            "BPL:" or "BCS:" or "BCC:" or "BVS:" or "BVC:" or "BR:"))
            return false;

        bool shouldBranch = microInstruction.Label switch
        {
            "BEQ:" => ((Flags >> 2) & 1) == 1,
            "BNE:" => ((Flags >> 2) & 1) == 0,
            "BMI:" => ((Flags >> 3) & 1) == 1,
            "BPL:" => ((Flags >> 3) & 1) == 0,
            "BCS:" => ((Flags >> 0) & 1) == 1,
            "BCC:" => ((Flags >> 0) & 1) == 0,
            "BVS:" => ((Flags >> 1) & 1) == 1,
            "BVC:" => ((Flags >> 1) & 1) == 0,
            "BR:"  => true,
            _ => false
        };

        if (shouldBranch)
        {
            sbyte offset = (sbyte)(InstructionRegister & 0xFF);
            ProgramCounter = ProgramCounter + offset * 2;
        }

        microProgramCounter = 0;
        return true;
    }
    
    private void PrepareOneOperandInstruction()
    {
        int destinationRegister = InstructionRegister & 0xF;
        MemoryDataRegister = GeneralRegisters[destinationRegister];
    }
    
    public void ExecuteClockCycle()
    {
        if (IsHalted)
        {
            return;
        }
        
        var microInstruction = rom[microProgramCounter];
        
        if (microInstruction.Label is "INC:" or "DEC:" or "NEG:" or 
            "ASL:" or "ASR:" or "LSR:" or "ROL:" or "ROR:" or "RLC:" or "RRC:")
        {
            PrepareOneOperandInstruction();
        }
        
        if (microInstruction.Label == "HALT:")
        {
            IsHalted = true;
            return;
        }
        
        CurrentSbusValue = ComputeSbus(microInstruction);
        CurrentDbusValue = ComputeDbus(microInstruction);
        
        int aluResult = ComputeAlu(microInstruction, CurrentSbusValue, CurrentDbusValue);
        
        if (microInstruction.OtherOperationsText == "Cin,PdCONDaritm")
        {
            if (microInstruction.Label is "INC:")
                aluResult = (aluResult + 1) & 0xFFFF;
            CurrentAluValue = aluResult;
        }
        WriteRbus(microInstruction, aluResult);
        
        HandleMemory(microInstruction);
        
        HandleOtherOperations(microInstruction, aluResult);

        if (HandleBranchInstructions(microInstruction))
        {
            return;
        }
        
        microProgramCounter = ComputeNextMicroAddress(microInstruction);
    }

    public void LoadProgram(int[] program, int startAddress)
    {
        for (int i = 0; i < program.Length; i++)
        {
            memory.Write(startAddress + i * 2, program[i]);
        }
    }
}