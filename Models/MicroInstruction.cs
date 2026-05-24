namespace proiect_arhitectura_sistemelor_de_calcul.Models;

public class MicroInstruction
{
    public string Label { get; init; }
    
    public int MicroAddress { get; init; }

    public string SbusText { get; init; }
    public int SbusValue { get; init; }
    
    public string DbusText { get; init; }
    public int DbusValue { get; init; }
    
    public string AluText { get; init; }
    public int AluValue { get; init; }
    
    public string RbusText { get; init; }
    public int RbusValue { get; init; }
    
    public string MemoryText { get; init; }
    public int MemoryValue { get; init; }
    
    public string OtherOperationsText { get; init; }
    public int OtherOperationsValue { get; init; }
    
    public string SuccessorText { get; init; }
    public int SuccessorValue { get; init; }
    
    public string IndexSelectionText { get; init; }
    public int IndexSelectionValue { get; init; }
    
    public string InversionText { get; init; }
    public int InversionValue { get; init; }
    
    public string JumpAddressText { get; init; }
    public int JumpAddressValue { get; init; }
}