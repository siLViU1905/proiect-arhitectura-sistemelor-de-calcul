using proiect_arhitectura_sistemelor_de_calcul.Models;

namespace proiect_arhitectura_sistemelor_de_calcul
{
    public partial class CPUViewerForm : Form
    {
        public CPUViewerForm()
        {
            InitializeComponent();

            instructionLoader.Load("InstructiuniProcesor.xlsx");
            microprogramLoader.Load("Microprogram.xlsx");

            processorCore = new ProcessorCore(microprogramLoader.GetMicroprogram().ToList(),
                instructionLoader.GetOpcodes());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                parsedLines = ASMParser.Parse(openFileDialog.FileName);
                isAssembled = false;
                if (parsedLines.Count != 0)
                    MessageBox.Show(
                        "Parsed successfully",
                        "Parse status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                else
                    MessageBox.Show(
                        "Parsed failed",
                        "Parse status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                parsedTextBox.Lines = parsedLines.ToArray();
            }
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (parsedLines == null || parsedLines.Count == 0)
            {
                MessageBox.Show(
                         "Parsed content does not exist",
                         "Step status",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                return;
            }
            
            if(!isAssembled)
            {
                Assembler assembler = new Assembler(instructionLoader.GetOpcodes());
                int[] program = assembler.Assemble(parsedLines);
                processorCore.LoadProgram(program, 0);
                isAssembled = true;
            }
            
            if (processorCore.IsHalted)
            {
                MessageBox.Show("Processor halted.", "HALT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            processorCore.ExecuteClockCycle();
            UpdateUI();
        }

        private void UpdateUI()
        {
            pcValue.Text = "0x" + processorCore.ProgramCounter.ToString("X");
            irValue.Text = "0x" + processorCore.InstructionRegister.ToString("X");
            flagValue.Text = "0x" + processorCore.Flags.ToString("X");
            spValue.Text = "0x" + processorCore.StackPointer.ToString("X");
            
            adrValue.Text = "0x" + processorCore.MemoryAddressRegister.ToString("X");
            mdrValue.Text = "0x" + processorCore.MemoryDataRegister.ToString("X");
            
            tValue.Text = "0x" + processorCore.T.ToString("X");
            ivrValue.Text = "0x" + processorCore.Ivr.ToString("X");
            
            sbusValue.Text = "0x" + processorCore.CurrentSbusValue.ToString("X");
            dbusValue.Text = "0x" + processorCore.CurrentDbusValue.ToString("X");
            rbusValue.Text = "0x" + processorCore.CurrentAluValue.ToString("X");
            
            inputSValue.Text = "0x" + processorCore.CurrentSbusValue.ToString("X");
            inputDValue.Text = "0x" + processorCore.CurrentDbusValue.ToString("X");
            outputRValue.Text = "0x" + processorCore.CurrentAluValue.ToString("X");
            operationValue.Text = processorCore.CurrentAluOperation;
            
            r0Value.Text = "0x" + processorCore.GeneralRegisters[0].ToString("X");
            r1Value.Text = "0x" + processorCore.GeneralRegisters[1].ToString("X");
            r2Value.Text = "0x" + processorCore.GeneralRegisters[2].ToString("X");
            r3Value.Text = "0x" + processorCore.GeneralRegisters[3].ToString("X");
            r4Value.Text = "0x" + processorCore.GeneralRegisters[4].ToString("X");
            r5Value.Text = "0x" + processorCore.GeneralRegisters[5].ToString("X");
            r6Value.Text = "0x" + processorCore.GeneralRegisters[6].ToString("X");
            r7Value.Text = "0x" + processorCore.GeneralRegisters[7].ToString("X");
            r8Value.Text = "0x" + processorCore.GeneralRegisters[8].ToString("X");
            r9Value.Text = "0x" + processorCore.GeneralRegisters[9].ToString("X");
            r10Value.Text = "0x" + processorCore.GeneralRegisters[10].ToString("X");
            r11Value.Text = "0x" + processorCore.GeneralRegisters[11].ToString("X");
            r12Value.Text = "0x" + processorCore.GeneralRegisters[12].ToString("X");
            r13Value.Text = "0x" + processorCore.GeneralRegisters[13].ToString("X");
            r14Value.Text = "0x" + processorCore.GeneralRegisters[14].ToString("X");
            r15Value.Text = "0x" + processorCore.GeneralRegisters[15].ToString("X");
        }
    }
}
