namespace proiect_arhitectura_sistemelor_de_calcul.Models;

public class Assembler
{
    private readonly IReadOnlyDictionary<string, InstructionDef> opcodesMap;

    public Assembler(IReadOnlyDictionary<string, InstructionDef> opcodesMap)
    {
        this.opcodesMap = opcodesMap;
    }

    public int[] Assemble(List<string> tokens)
    {
        List<int> result = new List<int>();
        int index = 0;

        while (index < tokens.Count)
        {
            string mnemonic = tokens[index].ToUpper();
            index++;

            var instructionDef = opcodesMap[mnemonic];
            int opcode = instructionDef.Opcode;

            if (IsNoOperand(mnemonic))
            {
                result.Add(opcode);
                continue;
            }

            if (IsTwoOperand(mnemonic))
            {
                var destinationResult = ParseOperand(tokens[index++]);
                int destinationMode = destinationResult.Mode;
                int destinationRegister = destinationResult.Register;
                int? destinationExtra = destinationResult.Extra;

                var sourceResult = ParseOperand(tokens[index++]);
                int sourceMode = sourceResult.Mode;
                int sourceRegister = sourceResult.Register;
                int? sourceExtra = sourceResult.Extra;
                
                int instruction = (opcode << 12) | (sourceMode << 10) | (sourceRegister << 6) | (destinationMode << 4) | destinationRegister;
                result.Add(instruction);

                if (sourceExtra.HasValue)
                {
                    result.Add(sourceExtra.Value);
                }

                if (destinationExtra.HasValue)
                {
                    result.Add(destinationExtra.Value);
                }
                
                continue;
            }

            if (IsOneOperand(mnemonic))
            {
                var destinationResult = ParseOperand(tokens[index++]);
                int destinationMode = destinationResult.Mode;
                int destinationRegister = destinationResult.Register;
                int? destinationExtra = destinationResult.Extra;
                
                int instruction = (opcode << 6) | (destinationMode << 4) | destinationRegister;
                result.Add(instruction);

                if (destinationExtra.HasValue)
                {
                    result.Add(destinationExtra.Value);
                }
                continue;
            }

            if (IsBranch(mnemonic))
            {
                int offset = int.Parse(tokens[index++]);
                int instrcution = (opcode << 8) | offset;
                result.Add(instrcution);
                continue;
            }
        }
        
        return result.ToArray();
    }

    private ParsedOperand ParseOperand(string operand)
    {
        if (operand.StartsWith("R"))
        {
            int registerIndex = int.Parse(operand.Substring(1));
            return new ParsedOperand
            {
                Mode = 0b01,
                Register = registerIndex,
                Extra = null
            };
        }

        if (operand.StartsWith("(R") && operand.EndsWith(")"))
        {
            int registerIndex = int.Parse(operand.Substring(2, operand.Length - 3));
            return new ParsedOperand
            {
                Mode = 0b10,
                Register = registerIndex,
                Extra = null
            };
        }

        if (operand.Contains("(R"))
        {
            int parenthesisIndex = operand.IndexOf("(R");
            int immediateValue = int.Parse(operand.Substring(0, parenthesisIndex));
            int registerIndex = int.Parse(operand.Substring(parenthesisIndex + 2,  operand.Length - parenthesisIndex - 3));
            return new ParsedOperand
            {
                Mode = 0b11,
                Register = registerIndex,
                Extra = immediateValue
            };
        }
        
        int value = int.Parse(operand);
        return new ParsedOperand
        {
            Mode = 0b00,
            Register = 0,
            Extra = value
        };
    }

    private bool IsNoOperand(string mnemonic)
    {
        return mnemonic == "NOP" || mnemonic == "HALT" || mnemonic == "RET" || 
               mnemonic == "RETI" || mnemonic == "WAIT" || mnemonic == "CLC" || 
               mnemonic == "SEC" || mnemonic == "CLZ" || mnemonic == "SEZ" || 
               mnemonic == "CLV" || mnemonic == "SEV" || mnemonic == "CLS" || 
               mnemonic == "SES" || mnemonic == "CCC" || mnemonic == "SCC" || 
               mnemonic == "PUSH PC" || mnemonic == "POP PC" || 
               mnemonic == "PUSH FLAG" || mnemonic == "POP FLAG";
    }

    private bool IsTwoOperand(string mnemonic)
    {
        return mnemonic == "MOV" || mnemonic == "ADD" || mnemonic == "SUB" || 
               mnemonic == "CMP" || mnemonic == "AND" || mnemonic == "OR" || 
               mnemonic == "XOR";
    }

    private bool IsOneOperand(string mnemonic)
    {
        return mnemonic == "CLR" || mnemonic == "NEG" || mnemonic == "INC" || 
               mnemonic == "DEC" || mnemonic == "ASL" || mnemonic == "ASR" || 
               mnemonic == "LSR" || mnemonic == "ROL" || mnemonic == "ROR" || 
               mnemonic == "RLC" || mnemonic == "RRC" || mnemonic == "JMP" || 
               mnemonic == "CALL" || mnemonic == "PUSH" || mnemonic == "POP";
    }

    private bool IsBranch(string mnemonic)
    {
        return mnemonic == "BR" || mnemonic == "BEQ" || mnemonic == "BNE" || 
               mnemonic == "BPL" || mnemonic == "BMI" || mnemonic == "BCS" || 
               mnemonic == "BCC" || mnemonic == "BVS" || mnemonic == "BVC";
    }
}