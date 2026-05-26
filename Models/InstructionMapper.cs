using System;
using System.Collections.Generic;
using System.Linq;
using ClosedXML.Excel;

namespace proiect_arhitectura_sistemelor_de_calcul.Models
{
    public class InstructionMapper
    {
        private readonly IReadOnlyDictionary<string, InstructionDef> _opcodesMap;

        public InstructionMapper(IReadOnlyDictionary<string, InstructionDef> opcodesMap)
        {
            _opcodesMap = opcodesMap;
        }

        public void Export(List<string> tokens, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Sheet1");

                ws.Cell(1, 2).Value = "IR";
                for (int bit = 15; bit >= 0; bit--)
                    ws.Cell(1, 3 + (15 - bit)).Value = bit;
                ws.Cell(1, 19).Value = "Cod Hex";

                var headerRange = ws.Range(1, 2, 1, 19);
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(189, 215, 238);
                headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                int tokenIdx = 0;
                int rowIdx = 2;

                while (tokenIdx < tokens.Count)
                {
                    string mnemonic = tokens[tokenIdx++].ToUpper();

                    if (!_opcodesMap.ContainsKey(mnemonic))
                        continue;

                    int opcode = _opcodesMap[mnemonic].Opcode;
                    string fullText = mnemonic;
                    int irValue;

                    if (IsTwoOperand(mnemonic))
                    {
                        string destToken = tokens[tokenIdx++];
                        string srcToken = tokens[tokenIdx++];
                        fullText += $" {destToken}, {srcToken}";

                        var dest = ParseOperand(destToken);
                        var src = ParseOperand(srcToken);

                        irValue = (opcode << 12)
                                | (src.Mode << 10)
                                | (src.Register << 6)
                                | (dest.Mode << 4)
                                | dest.Register;

                        WriteRow(ws, rowIdx++, fullText, irValue);

                        if (src.Extra.HasValue)
                            WriteRow(ws, rowIdx++, $"  {src.Extra.Value}", src.Extra.Value);
                        if (dest.Extra.HasValue)
                            WriteRow(ws, rowIdx++, $"  {dest.Extra.Value}", dest.Extra.Value);
                    }
                    else if (IsOneOperand(mnemonic))
                    {
                        string opToken = tokens[tokenIdx++];
                        fullText += $" {opToken}";

                        var op = ParseOperand(opToken);

                        irValue = (opcode << 6)
                                | (op.Mode << 4)
                                | op.Register;

                        WriteRow(ws, rowIdx++, fullText, irValue);

                        if (op.Extra.HasValue)
                            WriteRow(ws, rowIdx++, $"  {op.Extra.Value}", op.Extra.Value);
                    }
                    else if (IsBranch(mnemonic))
                    {
                        string offsetStr = tokens[tokenIdx++];
                        int offset = int.Parse(offsetStr);
                        fullText += $" {(offset >= 0 ? "+" : "")}{offset}";

                        irValue = (opcode << 8) | (offset & 0xFF);

                        WriteRow(ws, rowIdx++, fullText, irValue);
                    }
                    else
                    {
                        irValue = opcode;
                        WriteRow(ws, rowIdx++, fullText, irValue);
                    }
                }

                ws.Column(2).Width = 22;
                for (int c = 3; c <= 18; c++)
                    ws.Column(c).Width = 4;
                ws.Column(19).Width = 10;

                workbook.SaveAs(filePath);
            }
        }

        private void WriteRow(IXLWorksheet ws, int row, string text, int value)
        {
            ws.Cell(row, 2).Value = text;
            for (int bit = 15; bit >= 0; bit--)
                ws.Cell(row, 3 + (15 - bit)).Value = (value >> bit) & 1;
            ws.Cell(row, 19).Value = value.ToString("X4");
            ws.Range(row, 3, row, 18).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        }

        private ParsedOperand ParseOperand(string operand)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(operand, @"^R\d+$",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                return new ParsedOperand { Mode = 0b01, Register = int.Parse(operand.Substring(1)), Extra = null };

            if (System.Text.RegularExpressions.Regex.IsMatch(operand, @"^\(R\d+\)$",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                int reg = int.Parse(operand.Substring(2, operand.Length - 3));
                return new ParsedOperand { Mode = 0b10, Register = reg, Extra = null };
            }

            if (operand.Contains("(R") || operand.Contains("(r"))
            {
                int paren = operand.IndexOf('(');
                int imm = int.Parse(operand.Substring(0, paren));
                int reg = int.Parse(operand.Substring(paren + 2, operand.Length - paren - 3));
                return new ParsedOperand { Mode = 0b11, Register = reg, Extra = imm };
            }

            int value = int.Parse(operand);
            return new ParsedOperand { Mode = 0b00, Register = 0, Extra = value };
        }

        private bool IsTwoOperand(string m) =>
            new[] { "MOV", "ADD", "SUB", "CMP", "AND", "OR", "XOR" }.Contains(m);

        private bool IsOneOperand(string m) =>
            new[] { "CLR", "NEG", "INC", "DEC", "ASL", "ASR", "LSR",
                    "ROL", "ROR", "RLC", "RRC", "JMP", "CALL", "PUSH", "POP" }.Contains(m);

        private bool IsBranch(string m) =>
            new[] { "BR", "BEQ", "BNE", "BPL", "BMI", "BCS", "BCC", "BVS", "BVC" }.Contains(m);
    }
}