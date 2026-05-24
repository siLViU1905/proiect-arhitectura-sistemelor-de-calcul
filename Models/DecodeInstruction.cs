namespace proiect_arhitectura_sistemelor_de_calcul.Models;

public class DecodeInstruction
{
    public int Opcode { get; init; }
    public int MAS { get; init; }
    public int RS { get; init; }
    public int MAD { get; init; }
    public int RD { get; init; }
    
    public  DecodeInstruction FromIR(int ir)
    {
        return new DecodeInstruction()
        {
            Opcode = (ir >> 12) & 0xF,
            MAS = (ir >> 10) & 0x3,
            RS = (ir >> 6) & 0xF,
            MAD = (ir >> 4) & 0x3,
            RD = ir & 0xF,
        };
    }
}