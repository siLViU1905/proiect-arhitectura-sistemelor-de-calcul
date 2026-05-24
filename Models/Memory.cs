namespace proiect_arhitectura_sistemelor_de_calcul.Models;

public class Memory
{
    private int[] ram = new int[65536];
    
    public int Read(int address)
    {
        return ram[address];
    }

    public void Write(int address, int value)
    {
        ram[address] = value;
    }
}