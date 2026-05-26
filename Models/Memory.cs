namespace proiect_arhitectura_sistemelor_de_calcul.Models;

public class Memory
{
    private int[] ram = new int[65536];
    
    public int Read(int address)
    {
        if (address < 0 || address >= 65536)
            return 0;
        return ram[address];
    }

    public void Write(int address, int value)
    {
        if (address < 0 || address >= 65536)
            return;
        ram[address] = value;
    }
}