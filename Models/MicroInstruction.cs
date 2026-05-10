namespace proiect_arhitectura_sistemelor_de_calcul.Models;

public class MicroInstruction
{
    public string Label { get; set; }
    public int MicroAddress { get; set; }
    public string Sbus { get; set; }
    public string Dbus { get; set; }
    public string Alu { get; set; }
    public string Rbus { get; set; }
    public string MemoryOp { get; set; }
    public string OtherOps { get; set; }
    public string Successor { get; set; }
    public string JumpAddress { get; set; }
}