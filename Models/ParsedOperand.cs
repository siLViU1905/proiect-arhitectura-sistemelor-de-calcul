namespace proiect_arhitectura_sistemelor_de_calcul.Models;

public class ParsedOperand
{
    public int Mode { get; init; }
    public int Register { get; init; }
    public int? Extra { get; init; }
}