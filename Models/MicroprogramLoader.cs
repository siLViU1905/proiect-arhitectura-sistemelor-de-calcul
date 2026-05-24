using ClosedXML.Excel;

namespace proiect_arhitectura_sistemelor_de_calcul.Models;

public class MicroprogramLoader
{
    private List<MicroInstruction> MicroprogramMemory =  new List<MicroInstruction>();

    public void Load(string path)
    {
        using (var workbook = new XLWorkbook(path))
        {
            var sheet = workbook.Worksheet(2);
            var rows = sheet.RangeUsed().RowsUsed().Skip(2);

            foreach (var row in rows)
            {
                string label = row.Cell(1).GetString();
                
                string addressStr = row.Cell(2).GetString();
                
                int address = Convert.ToInt32(addressStr);

                var sbusData = ParseCell(row.Cell(5).GetString());
                var dbusData = ParseCell(row.Cell(6).GetString());
                var aluData = ParseCell(row.Cell(7).GetString());
                var rbusData = ParseCell(row.Cell(8).GetString());
                var memoryData = ParseCell(row.Cell(9).GetString());
                var otherData = ParseCell(row.Cell(10).GetString());
                var successorData = ParseCell(row.Cell(11).GetString());
                var indexData = ParseCell(row.Cell(12).GetString());
                var inversionData = ParseCell(row.Cell(13).GetString());
                var jumpData = ParseCell(row.Cell(14).GetString());
                if (label == "FOS_AD:")
                    jumpData = (jumpData.text, jumpData.value - 1);
                if (label == "FOD_AD_B2:")
                    jumpData = (jumpData.text, jumpData.value - 7);
                if (label == "B3:")
                    jumpData = (jumpData.text, 37);
                var instruction = new MicroInstruction
                {
                    Label = label,
                    
                    MicroAddress = address,
                    
                    SbusText = sbusData.text,
                    SbusValue = sbusData.value,
                    
                    DbusText = dbusData.text,
                        
                    DbusValue = dbusData.value,
                    
                    AluText = aluData.text,
                    AluValue = aluData.value,
                    
                    RbusText = rbusData.text,
                    RbusValue = rbusData.value,
                    
                    MemoryText = memoryData.text,
                    MemoryValue = memoryData.value,
                    
                    OtherOperationsText = otherData.text,
                    OtherOperationsValue = otherData.value,
                    
                    SuccessorText = successorData.text,
                    SuccessorValue = successorData.value,
                    
                    IndexSelectionText = indexData.text,
                    IndexSelectionValue = indexData.value,
                    
                    InversionText = inversionData.text,
                    InversionValue = inversionData.value,
                    
                    JumpAddressText = jumpData.text,
                    JumpAddressValue = jumpData.value,
                };
                MicroprogramMemory.Add(instruction);
            }
        }
    }

    private (string text, int value) ParseCell(string cell)
    {
        if (string.IsNullOrWhiteSpace(cell))
        {
            return (string.Empty, 0);
        }

        if (cell.Contains(':'))
        {
            var parts = cell.Split(':');
            string textPart = parts[0];
            string bineryPart = parts[1].Trim();

            int numericValue = 0;
            if (!string.IsNullOrWhiteSpace(bineryPart))
            {
                numericValue = Convert.ToInt32(bineryPart, 2);
            }
            
            return (textPart, numericValue);
        }
        return (cell, 0);
    }

    public List<MicroInstruction> GetMicroprogram()
    {
        return MicroprogramMemory;
    }
}