
using ClosedXML.Excel;
using proiect_arhitectura_sistemelor_de_calcul.Models;

namespace proiect_arhitectura_sistemelor_de_calcul
{
    internal class InstructionLoader
    {
        private Dictionary<String, InstructionDef> opcodesMap = new Dictionary<String, InstructionDef>();

        public void Load(String path)
        {
            using (var workbook = new XLWorkbook(path))
            {
                var sheet = workbook.Worksheet(1);
                var rows = sheet.RangeUsed().RowsUsed().Skip(1);

                foreach (var row in rows)
                {
                    string mnemonic = row.Cell(1).GetString();

                    if (string.IsNullOrWhiteSpace(mnemonic))
                        continue;

                    int opcode = 0;

                    for (int col = 2; col <= 17; col++)
                    {
                        var cell = row.Cell(col);
                        string val = cell.GetValue<string>().Trim();

                        if (int.TryParse(val, out int bit))
                            opcode = (opcode << 1) | bit;
                        else
                            break;
                    }

                    opcodesMap[mnemonic] = new InstructionDef
                    {
                        Mnemonic = mnemonic,
                        Opcode = opcode
                    };
                    Console.WriteLine(opcodesMap[mnemonic].Opcode);
                }
            }
        }
        
        public Dictionary<string, InstructionDef> GetOpcodes()
        {
            return this.opcodesMap;
        }
    }
}
