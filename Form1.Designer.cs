using proiect_arhitectura_sistemelor_de_calcul.Models;

namespace proiect_arhitectura_sistemelor_de_calcul
{
    partial class CPUViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            stepToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            generalRegistersGroup = new GroupBox();
            generalRegistersTableLayout = new TableLayoutPanel();
            r15Value = new TextBox();
            r14Value = new TextBox();
            r13Value = new TextBox();
            r12Value = new TextBox();
            r11Value = new TextBox();
            r10Value = new TextBox();
            r9Value = new TextBox();
            r8Value = new TextBox();
            r7Value = new TextBox();
            r6Value = new TextBox();
            r5Value = new TextBox();
            r4Value = new TextBox();
            r3Value = new TextBox();
            r2Value = new TextBox();
            r1Value = new TextBox();
            generalRegistersTableColumn3Label = new Label();
            generalRegistersTableColumn1Label = new Label();
            generalRegistersTableColumn0Label = new Label();
            r1Label = new Label();
            generalRegistersTableColumn2Label = new Label();
            r0Label = new Label();
            r2Label = new Label();
            r3Label = new Label();
            r4Label = new Label();
            r5Label = new Label();
            r6Label = new Label();
            r7Label = new Label();
            r8Label = new Label();
            r9Label = new Label();
            r10Label = new Label();
            r11Label = new Label();
            r12Label = new Label();
            r13Label = new Label();
            r14Label = new Label();
            r15Label = new Label();
            r0Value = new TextBox();
            controlAndStatusRegistersGroup = new GroupBox();
            contorlAndStatusRegistersTableLayout = new TableLayoutPanel();
            spValue = new TextBox();
            flagValue = new TextBox();
            irValue = new TextBox();
            controlAndStatusRegistersTableColumn1Label = new Label();
            controlAndStatusRegistersTableColumn0Label = new Label();
            pcLabel = new Label();
            irLabel = new Label();
            flagLabel = new Label();
            spLabel = new Label();
            pcValue = new TextBox();
            memoryInterfaceRegistersGroup = new GroupBox();
            memoryInterfaceRegistersTableLayout = new TableLayoutPanel();
            mdrValue = new TextBox();
            memoryInterfaceRegistersTableColumn1Label = new Label();
            memoryInterfaceRegistersTableColumn0Label = new Label();
            adrLabel = new Label();
            mdrLabel = new Label();
            adrValue = new TextBox();
            auxiliaryRegistersGroup = new GroupBox();
            auxiliaryRegistersTableLayout = new TableLayoutPanel();
            ivrValue = new TextBox();
            auxiliaryRegistersTableColumn1Label = new Label();
            auxiliaryRegistersTableColumn0Label = new Label();
            tLabel = new Label();
            ivrLabel = new Label();
            tValue = new TextBox();
            busGroup = new GroupBox();
            busTableLayout = new TableLayoutPanel();
            rbusValue = new TextBox();
            rbusLabel = new Label();
            dbusValue = new TextBox();
            busRegistersTableColumn1Label = new Label();
            busRegistersTableColumn0Label = new Label();
            sbusLabel = new Label();
            dbusLabel = new Label();
            sbusValue = new TextBox();
            aluGroup = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            outputRValue = new TextBox();
            outputRLabel = new Label();
            operationValue = new TextBox();
            operationLabel = new Label();
            inputDValue = new TextBox();
            aluTableColumn1Label = new Label();
            aluTableColumn0Label = new Label();
            inputSLabel = new Label();
            inputDLabel = new Label();
            inputSValue = new TextBox();
            parsedTextBox = new TextBox();
            parsedTextLabel = new Label();
            menuStrip.SuspendLayout();
            generalRegistersGroup.SuspendLayout();
            generalRegistersTableLayout.SuspendLayout();
            controlAndStatusRegistersGroup.SuspendLayout();
            contorlAndStatusRegistersTableLayout.SuspendLayout();
            memoryInterfaceRegistersGroup.SuspendLayout();
            memoryInterfaceRegistersTableLayout.SuspendLayout();
            auxiliaryRegistersGroup.SuspendLayout();
            auxiliaryRegistersTableLayout.SuspendLayout();
            busGroup.SuspendLayout();
            busTableLayout.SuspendLayout();
            aluGroup.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, stepToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1241, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(137, 26);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // stepToolStripMenuItem
            // 
            stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            stepToolStripMenuItem.Size = new Size(53, 24);
            stepToolStripMenuItem.Text = "Step";
            stepToolStripMenuItem.Click += stepToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "|*.asm";
            // 
            // generalRegistersGroup
            // 
            generalRegistersGroup.Controls.Add(generalRegistersTableLayout);
            generalRegistersGroup.Location = new Point(12, 44);
            generalRegistersGroup.Name = "generalRegistersGroup";
            generalRegistersGroup.Size = new Size(232, 326);
            generalRegistersGroup.TabIndex = 1;
            generalRegistersGroup.TabStop = false;
            generalRegistersGroup.Text = "General";
            // 
            // generalRegistersTableLayout
            // 
            generalRegistersTableLayout.ColumnCount = 4;
            generalRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            generalRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            generalRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            generalRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            generalRegistersTableLayout.Controls.Add(r15Value, 3, 8);
            generalRegistersTableLayout.Controls.Add(r14Value, 1, 8);
            generalRegistersTableLayout.Controls.Add(r13Value, 3, 7);
            generalRegistersTableLayout.Controls.Add(r12Value, 1, 7);
            generalRegistersTableLayout.Controls.Add(r11Value, 3, 6);
            generalRegistersTableLayout.Controls.Add(r10Value, 1, 6);
            generalRegistersTableLayout.Controls.Add(r9Value, 3, 5);
            generalRegistersTableLayout.Controls.Add(r8Value, 1, 5);
            generalRegistersTableLayout.Controls.Add(r7Value, 3, 4);
            generalRegistersTableLayout.Controls.Add(r6Value, 1, 4);
            generalRegistersTableLayout.Controls.Add(r5Value, 3, 3);
            generalRegistersTableLayout.Controls.Add(r4Value, 1, 3);
            generalRegistersTableLayout.Controls.Add(r3Value, 3, 2);
            generalRegistersTableLayout.Controls.Add(r2Value, 1, 2);
            generalRegistersTableLayout.Controls.Add(r1Value, 3, 1);
            generalRegistersTableLayout.Controls.Add(generalRegistersTableColumn3Label, 3, 0);
            generalRegistersTableLayout.Controls.Add(generalRegistersTableColumn1Label, 1, 0);
            generalRegistersTableLayout.Controls.Add(generalRegistersTableColumn0Label, 0, 0);
            generalRegistersTableLayout.Controls.Add(r1Label, 2, 1);
            generalRegistersTableLayout.Controls.Add(generalRegistersTableColumn2Label, 2, 0);
            generalRegistersTableLayout.Controls.Add(r0Label, 0, 1);
            generalRegistersTableLayout.Controls.Add(r2Label, 0, 2);
            generalRegistersTableLayout.Controls.Add(r3Label, 2, 2);
            generalRegistersTableLayout.Controls.Add(r4Label, 0, 3);
            generalRegistersTableLayout.Controls.Add(r5Label, 2, 3);
            generalRegistersTableLayout.Controls.Add(r6Label, 0, 4);
            generalRegistersTableLayout.Controls.Add(r7Label, 2, 4);
            generalRegistersTableLayout.Controls.Add(r8Label, 0, 5);
            generalRegistersTableLayout.Controls.Add(r9Label, 2, 5);
            generalRegistersTableLayout.Controls.Add(r10Label, 0, 6);
            generalRegistersTableLayout.Controls.Add(r11Label, 2, 6);
            generalRegistersTableLayout.Controls.Add(r12Label, 0, 7);
            generalRegistersTableLayout.Controls.Add(r13Label, 2, 7);
            generalRegistersTableLayout.Controls.Add(r14Label, 0, 8);
            generalRegistersTableLayout.Controls.Add(r15Label, 2, 8);
            generalRegistersTableLayout.Controls.Add(r0Value, 1, 1);
            generalRegistersTableLayout.Dock = DockStyle.Fill;
            generalRegistersTableLayout.Location = new Point(3, 23);
            generalRegistersTableLayout.Name = "generalRegistersTableLayout";
            generalRegistersTableLayout.RowCount = 9;
            generalRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            generalRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            generalRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            generalRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            generalRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            generalRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            generalRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            generalRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            generalRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            generalRegistersTableLayout.Size = new Size(226, 300);
            generalRegistersTableLayout.TabIndex = 2;
            // 
            // r15Value
            // 
            r15Value.Location = new Point(171, 267);
            r15Value.Name = "r15Value";
            r15Value.ReadOnly = true;
            r15Value.Size = new Size(50, 27);
            r15Value.TabIndex = 35;
            r15Value.Text = "0x0";
            // 
            // r14Value
            // 
            r14Value.Location = new Point(59, 267);
            r14Value.Name = "r14Value";
            r14Value.ReadOnly = true;
            r14Value.Size = new Size(50, 27);
            r14Value.TabIndex = 34;
            r14Value.Text = "0x0";
            // 
            // r13Value
            // 
            r13Value.Location = new Point(171, 234);
            r13Value.Name = "r13Value";
            r13Value.ReadOnly = true;
            r13Value.Size = new Size(50, 27);
            r13Value.TabIndex = 33;
            r13Value.Text = "0x0";
            // 
            // r12Value
            // 
            r12Value.Location = new Point(59, 234);
            r12Value.Name = "r12Value";
            r12Value.ReadOnly = true;
            r12Value.Size = new Size(50, 27);
            r12Value.TabIndex = 32;
            r12Value.Text = "0x0";
            // 
            // r11Value
            // 
            r11Value.Location = new Point(171, 201);
            r11Value.Name = "r11Value";
            r11Value.ReadOnly = true;
            r11Value.Size = new Size(50, 27);
            r11Value.TabIndex = 31;
            r11Value.Text = "0x0";
            // 
            // r10Value
            // 
            r10Value.Location = new Point(59, 201);
            r10Value.Name = "r10Value";
            r10Value.ReadOnly = true;
            r10Value.Size = new Size(50, 27);
            r10Value.TabIndex = 30;
            r10Value.Text = "0x0";
            // 
            // r9Value
            // 
            r9Value.Location = new Point(171, 168);
            r9Value.Name = "r9Value";
            r9Value.ReadOnly = true;
            r9Value.Size = new Size(50, 27);
            r9Value.TabIndex = 29;
            r9Value.Text = "0x0";
            // 
            // r8Value
            // 
            r8Value.Location = new Point(59, 168);
            r8Value.Name = "r8Value";
            r8Value.ReadOnly = true;
            r8Value.Size = new Size(50, 27);
            r8Value.TabIndex = 28;
            r8Value.Text = "0x0";
            // 
            // r7Value
            // 
            r7Value.Location = new Point(171, 135);
            r7Value.Name = "r7Value";
            r7Value.ReadOnly = true;
            r7Value.Size = new Size(50, 27);
            r7Value.TabIndex = 27;
            r7Value.Text = "0x0";
            // 
            // r6Value
            // 
            r6Value.Location = new Point(59, 135);
            r6Value.Name = "r6Value";
            r6Value.ReadOnly = true;
            r6Value.Size = new Size(50, 27);
            r6Value.TabIndex = 26;
            r6Value.Text = "0x0";
            // 
            // r5Value
            // 
            r5Value.Location = new Point(171, 102);
            r5Value.Name = "r5Value";
            r5Value.ReadOnly = true;
            r5Value.Size = new Size(50, 27);
            r5Value.TabIndex = 25;
            r5Value.Text = "0x0";
            // 
            // r4Value
            // 
            r4Value.Location = new Point(59, 102);
            r4Value.Name = "r4Value";
            r4Value.ReadOnly = true;
            r4Value.Size = new Size(50, 27);
            r4Value.TabIndex = 24;
            r4Value.Text = "0x0";
            // 
            // r3Value
            // 
            r3Value.Location = new Point(171, 69);
            r3Value.Name = "r3Value";
            r3Value.ReadOnly = true;
            r3Value.Size = new Size(50, 27);
            r3Value.TabIndex = 23;
            r3Value.Text = "0x0";
            // 
            // r2Value
            // 
            r2Value.Location = new Point(59, 69);
            r2Value.Name = "r2Value";
            r2Value.ReadOnly = true;
            r2Value.Size = new Size(50, 27);
            r2Value.TabIndex = 22;
            r2Value.Text = "0x0";
            // 
            // r1Value
            // 
            r1Value.Location = new Point(171, 36);
            r1Value.Name = "r1Value";
            r1Value.ReadOnly = true;
            r1Value.Size = new Size(50, 27);
            r1Value.TabIndex = 21;
            r1Value.Text = "0x0";
            // 
            // generalRegistersTableColumn3Label
            // 
            generalRegistersTableColumn3Label.AutoSize = true;
            generalRegistersTableColumn3Label.Location = new Point(171, 0);
            generalRegistersTableColumn3Label.Name = "generalRegistersTableColumn3Label";
            generalRegistersTableColumn3Label.Size = new Size(45, 20);
            generalRegistersTableColumn3Label.TabIndex = 5;
            generalRegistersTableColumn3Label.Text = "Value";
            // 
            // generalRegistersTableColumn1Label
            // 
            generalRegistersTableColumn1Label.AutoSize = true;
            generalRegistersTableColumn1Label.Location = new Point(59, 0);
            generalRegistersTableColumn1Label.Name = "generalRegistersTableColumn1Label";
            generalRegistersTableColumn1Label.Size = new Size(45, 20);
            generalRegistersTableColumn1Label.TabIndex = 4;
            generalRegistersTableColumn1Label.Text = "Value";
            // 
            // generalRegistersTableColumn0Label
            // 
            generalRegistersTableColumn0Label.AutoSize = true;
            generalRegistersTableColumn0Label.Location = new Point(3, 0);
            generalRegistersTableColumn0Label.Name = "generalRegistersTableColumn0Label";
            generalRegistersTableColumn0Label.Size = new Size(49, 20);
            generalRegistersTableColumn0Label.TabIndex = 2;
            generalRegistersTableColumn0Label.Text = "Name";
            // 
            // r1Label
            // 
            r1Label.AutoSize = true;
            r1Label.Location = new Point(115, 33);
            r1Label.Name = "r1Label";
            r1Label.Size = new Size(26, 20);
            r1Label.TabIndex = 1;
            r1Label.Text = "R1";
            // 
            // generalRegistersTableColumn2Label
            // 
            generalRegistersTableColumn2Label.AutoSize = true;
            generalRegistersTableColumn2Label.Location = new Point(115, 0);
            generalRegistersTableColumn2Label.Name = "generalRegistersTableColumn2Label";
            generalRegistersTableColumn2Label.Size = new Size(49, 20);
            generalRegistersTableColumn2Label.TabIndex = 3;
            generalRegistersTableColumn2Label.Text = "Name";
            // 
            // r0Label
            // 
            r0Label.AutoSize = true;
            r0Label.Location = new Point(3, 33);
            r0Label.Name = "r0Label";
            r0Label.Size = new Size(26, 20);
            r0Label.TabIndex = 0;
            r0Label.Text = "R0";
            // 
            // r2Label
            // 
            r2Label.AutoSize = true;
            r2Label.Location = new Point(3, 66);
            r2Label.Name = "r2Label";
            r2Label.Size = new Size(26, 20);
            r2Label.TabIndex = 6;
            r2Label.Text = "R2";
            // 
            // r3Label
            // 
            r3Label.AutoSize = true;
            r3Label.Location = new Point(115, 66);
            r3Label.Name = "r3Label";
            r3Label.Size = new Size(26, 20);
            r3Label.TabIndex = 7;
            r3Label.Text = "R3";
            // 
            // r4Label
            // 
            r4Label.AutoSize = true;
            r4Label.Location = new Point(3, 99);
            r4Label.Name = "r4Label";
            r4Label.Size = new Size(26, 20);
            r4Label.TabIndex = 8;
            r4Label.Text = "R4";
            // 
            // r5Label
            // 
            r5Label.AutoSize = true;
            r5Label.Location = new Point(115, 99);
            r5Label.Name = "r5Label";
            r5Label.Size = new Size(26, 20);
            r5Label.TabIndex = 9;
            r5Label.Text = "R5";
            // 
            // r6Label
            // 
            r6Label.AutoSize = true;
            r6Label.Location = new Point(3, 132);
            r6Label.Name = "r6Label";
            r6Label.Size = new Size(26, 20);
            r6Label.TabIndex = 10;
            r6Label.Text = "R6";
            // 
            // r7Label
            // 
            r7Label.AutoSize = true;
            r7Label.Location = new Point(115, 132);
            r7Label.Name = "r7Label";
            r7Label.Size = new Size(26, 20);
            r7Label.TabIndex = 11;
            r7Label.Text = "R7";
            // 
            // r8Label
            // 
            r8Label.AutoSize = true;
            r8Label.Location = new Point(3, 165);
            r8Label.Name = "r8Label";
            r8Label.Size = new Size(26, 20);
            r8Label.TabIndex = 12;
            r8Label.Text = "R8";
            // 
            // r9Label
            // 
            r9Label.AutoSize = true;
            r9Label.Location = new Point(115, 165);
            r9Label.Name = "r9Label";
            r9Label.Size = new Size(26, 20);
            r9Label.TabIndex = 13;
            r9Label.Text = "R9";
            // 
            // r10Label
            // 
            r10Label.AutoSize = true;
            r10Label.Location = new Point(3, 198);
            r10Label.Name = "r10Label";
            r10Label.Size = new Size(34, 20);
            r10Label.TabIndex = 14;
            r10Label.Text = "R10";
            // 
            // r11Label
            // 
            r11Label.AutoSize = true;
            r11Label.Location = new Point(115, 198);
            r11Label.Name = "r11Label";
            r11Label.Size = new Size(34, 20);
            r11Label.TabIndex = 15;
            r11Label.Text = "R11";
            // 
            // r12Label
            // 
            r12Label.AutoSize = true;
            r12Label.Location = new Point(3, 231);
            r12Label.Name = "r12Label";
            r12Label.Size = new Size(34, 20);
            r12Label.TabIndex = 16;
            r12Label.Text = "R12";
            // 
            // r13Label
            // 
            r13Label.AutoSize = true;
            r13Label.Location = new Point(115, 231);
            r13Label.Name = "r13Label";
            r13Label.Size = new Size(34, 20);
            r13Label.TabIndex = 17;
            r13Label.Text = "R13";
            // 
            // r14Label
            // 
            r14Label.AutoSize = true;
            r14Label.Location = new Point(3, 264);
            r14Label.Name = "r14Label";
            r14Label.Size = new Size(34, 20);
            r14Label.TabIndex = 18;
            r14Label.Text = "R14";
            // 
            // r15Label
            // 
            r15Label.AutoSize = true;
            r15Label.Location = new Point(115, 264);
            r15Label.Name = "r15Label";
            r15Label.Size = new Size(34, 20);
            r15Label.TabIndex = 19;
            r15Label.Text = "R15";
            // 
            // r0Value
            // 
            r0Value.Location = new Point(59, 36);
            r0Value.Name = "r0Value";
            r0Value.ReadOnly = true;
            r0Value.Size = new Size(50, 27);
            r0Value.TabIndex = 20;
            r0Value.Text = "0x0";
            // 
            // controlAndStatusRegistersGroup
            // 
            controlAndStatusRegistersGroup.Controls.Add(contorlAndStatusRegistersTableLayout);
            controlAndStatusRegistersGroup.Location = new Point(265, 44);
            controlAndStatusRegistersGroup.Name = "controlAndStatusRegistersGroup";
            controlAndStatusRegistersGroup.Size = new Size(232, 326);
            controlAndStatusRegistersGroup.TabIndex = 2;
            controlAndStatusRegistersGroup.TabStop = false;
            controlAndStatusRegistersGroup.Text = "Control and Status";
            // 
            // contorlAndStatusRegistersTableLayout
            // 
            contorlAndStatusRegistersTableLayout.ColumnCount = 2;
            contorlAndStatusRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0884953F));
            contorlAndStatusRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.91151F));
            contorlAndStatusRegistersTableLayout.Controls.Add(spValue, 1, 4);
            contorlAndStatusRegistersTableLayout.Controls.Add(flagValue, 1, 3);
            contorlAndStatusRegistersTableLayout.Controls.Add(irValue, 1, 2);
            contorlAndStatusRegistersTableLayout.Controls.Add(controlAndStatusRegistersTableColumn1Label, 1, 0);
            contorlAndStatusRegistersTableLayout.Controls.Add(controlAndStatusRegistersTableColumn0Label, 0, 0);
            contorlAndStatusRegistersTableLayout.Controls.Add(pcLabel, 0, 1);
            contorlAndStatusRegistersTableLayout.Controls.Add(irLabel, 0, 2);
            contorlAndStatusRegistersTableLayout.Controls.Add(flagLabel, 0, 3);
            contorlAndStatusRegistersTableLayout.Controls.Add(spLabel, 0, 4);
            contorlAndStatusRegistersTableLayout.Controls.Add(pcValue, 1, 1);
            contorlAndStatusRegistersTableLayout.Dock = DockStyle.Fill;
            contorlAndStatusRegistersTableLayout.Location = new Point(3, 23);
            contorlAndStatusRegistersTableLayout.Name = "contorlAndStatusRegistersTableLayout";
            contorlAndStatusRegistersTableLayout.RowCount = 5;
            contorlAndStatusRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            contorlAndStatusRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            contorlAndStatusRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            contorlAndStatusRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            contorlAndStatusRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            contorlAndStatusRegistersTableLayout.Size = new Size(226, 300);
            contorlAndStatusRegistersTableLayout.TabIndex = 2;
            // 
            // spValue
            // 
            spValue.Location = new Point(71, 243);
            spValue.Name = "spValue";
            spValue.ReadOnly = true;
            spValue.Size = new Size(50, 27);
            spValue.TabIndex = 26;
            spValue.Text = "0x0";
            // 
            // flagValue
            // 
            flagValue.Location = new Point(71, 183);
            flagValue.Name = "flagValue";
            flagValue.ReadOnly = true;
            flagValue.Size = new Size(50, 27);
            flagValue.TabIndex = 24;
            flagValue.Text = "0x0";
            // 
            // irValue
            // 
            irValue.Location = new Point(71, 123);
            irValue.Name = "irValue";
            irValue.ReadOnly = true;
            irValue.Size = new Size(50, 27);
            irValue.TabIndex = 22;
            irValue.Text = "0x0";
            // 
            // controlAndStatusRegistersTableColumn1Label
            // 
            controlAndStatusRegistersTableColumn1Label.AutoSize = true;
            controlAndStatusRegistersTableColumn1Label.Location = new Point(71, 0);
            controlAndStatusRegistersTableColumn1Label.Name = "controlAndStatusRegistersTableColumn1Label";
            controlAndStatusRegistersTableColumn1Label.Size = new Size(45, 20);
            controlAndStatusRegistersTableColumn1Label.TabIndex = 4;
            controlAndStatusRegistersTableColumn1Label.Text = "Value";
            // 
            // controlAndStatusRegistersTableColumn0Label
            // 
            controlAndStatusRegistersTableColumn0Label.AutoSize = true;
            controlAndStatusRegistersTableColumn0Label.Location = new Point(3, 0);
            controlAndStatusRegistersTableColumn0Label.Name = "controlAndStatusRegistersTableColumn0Label";
            controlAndStatusRegistersTableColumn0Label.Size = new Size(49, 20);
            controlAndStatusRegistersTableColumn0Label.TabIndex = 2;
            controlAndStatusRegistersTableColumn0Label.Text = "Name";
            // 
            // pcLabel
            // 
            pcLabel.AutoSize = true;
            pcLabel.Location = new Point(3, 60);
            pcLabel.Name = "pcLabel";
            pcLabel.Size = new Size(26, 20);
            pcLabel.TabIndex = 0;
            pcLabel.Text = "PC";
            // 
            // irLabel
            // 
            irLabel.AutoSize = true;
            irLabel.Location = new Point(3, 120);
            irLabel.Name = "irLabel";
            irLabel.Size = new Size(22, 20);
            irLabel.TabIndex = 6;
            irLabel.Text = "IR";
            // 
            // flagLabel
            // 
            flagLabel.AutoSize = true;
            flagLabel.Location = new Point(3, 180);
            flagLabel.Name = "flagLabel";
            flagLabel.Size = new Size(43, 20);
            flagLabel.TabIndex = 8;
            flagLabel.Text = "FLAG";
            // 
            // spLabel
            // 
            spLabel.AutoSize = true;
            spLabel.Location = new Point(3, 240);
            spLabel.Name = "spLabel";
            spLabel.Size = new Size(25, 20);
            spLabel.TabIndex = 10;
            spLabel.Text = "SP";
            // 
            // pcValue
            // 
            pcValue.Location = new Point(71, 63);
            pcValue.Name = "pcValue";
            pcValue.ReadOnly = true;
            pcValue.Size = new Size(50, 27);
            pcValue.TabIndex = 20;
            pcValue.Text = "0x0";
            // 
            // memoryInterfaceRegistersGroup
            // 
            memoryInterfaceRegistersGroup.Controls.Add(memoryInterfaceRegistersTableLayout);
            memoryInterfaceRegistersGroup.Location = new Point(799, 44);
            memoryInterfaceRegistersGroup.Name = "memoryInterfaceRegistersGroup";
            memoryInterfaceRegistersGroup.Size = new Size(232, 175);
            memoryInterfaceRegistersGroup.TabIndex = 3;
            memoryInterfaceRegistersGroup.TabStop = false;
            memoryInterfaceRegistersGroup.Text = "Memory Interface";
            // 
            // memoryInterfaceRegistersTableLayout
            // 
            memoryInterfaceRegistersTableLayout.ColumnCount = 2;
            memoryInterfaceRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.41593F));
            memoryInterfaceRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.58407F));
            memoryInterfaceRegistersTableLayout.Controls.Add(mdrValue, 1, 2);
            memoryInterfaceRegistersTableLayout.Controls.Add(memoryInterfaceRegistersTableColumn1Label, 1, 0);
            memoryInterfaceRegistersTableLayout.Controls.Add(memoryInterfaceRegistersTableColumn0Label, 0, 0);
            memoryInterfaceRegistersTableLayout.Controls.Add(adrLabel, 0, 1);
            memoryInterfaceRegistersTableLayout.Controls.Add(mdrLabel, 0, 2);
            memoryInterfaceRegistersTableLayout.Controls.Add(adrValue, 1, 1);
            memoryInterfaceRegistersTableLayout.Dock = DockStyle.Fill;
            memoryInterfaceRegistersTableLayout.Location = new Point(3, 23);
            memoryInterfaceRegistersTableLayout.Name = "memoryInterfaceRegistersTableLayout";
            memoryInterfaceRegistersTableLayout.RowCount = 3;
            memoryInterfaceRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            memoryInterfaceRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            memoryInterfaceRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            memoryInterfaceRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            memoryInterfaceRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            memoryInterfaceRegistersTableLayout.Size = new Size(226, 149);
            memoryInterfaceRegistersTableLayout.TabIndex = 2;
            // 
            // mdrValue
            // 
            mdrValue.Location = new Point(74, 101);
            mdrValue.Name = "mdrValue";
            mdrValue.ReadOnly = true;
            mdrValue.Size = new Size(50, 27);
            mdrValue.TabIndex = 22;
            mdrValue.Text = "0x0";
            // 
            // memoryInterfaceRegistersTableColumn1Label
            // 
            memoryInterfaceRegistersTableColumn1Label.AutoSize = true;
            memoryInterfaceRegistersTableColumn1Label.Location = new Point(74, 0);
            memoryInterfaceRegistersTableColumn1Label.Name = "memoryInterfaceRegistersTableColumn1Label";
            memoryInterfaceRegistersTableColumn1Label.Size = new Size(45, 20);
            memoryInterfaceRegistersTableColumn1Label.TabIndex = 4;
            memoryInterfaceRegistersTableColumn1Label.Text = "Value";
            // 
            // memoryInterfaceRegistersTableColumn0Label
            // 
            memoryInterfaceRegistersTableColumn0Label.AutoSize = true;
            memoryInterfaceRegistersTableColumn0Label.Location = new Point(3, 0);
            memoryInterfaceRegistersTableColumn0Label.Name = "memoryInterfaceRegistersTableColumn0Label";
            memoryInterfaceRegistersTableColumn0Label.Size = new Size(49, 20);
            memoryInterfaceRegistersTableColumn0Label.TabIndex = 2;
            memoryInterfaceRegistersTableColumn0Label.Text = "Name";
            // 
            // adrLabel
            // 
            adrLabel.AutoSize = true;
            adrLabel.Location = new Point(3, 49);
            adrLabel.Name = "adrLabel";
            adrLabel.Size = new Size(39, 20);
            adrLabel.TabIndex = 0;
            adrLabel.Text = "ADR";
            // 
            // mdrLabel
            // 
            mdrLabel.AutoSize = true;
            mdrLabel.Location = new Point(3, 98);
            mdrLabel.Name = "mdrLabel";
            mdrLabel.Size = new Size(42, 20);
            mdrLabel.TabIndex = 6;
            mdrLabel.Text = "MDR";
            // 
            // adrValue
            // 
            adrValue.Location = new Point(74, 52);
            adrValue.Name = "adrValue";
            adrValue.ReadOnly = true;
            adrValue.Size = new Size(50, 27);
            adrValue.TabIndex = 20;
            adrValue.Text = "0x0";
            // 
            // auxiliaryRegistersGroup
            // 
            auxiliaryRegistersGroup.Controls.Add(auxiliaryRegistersTableLayout);
            auxiliaryRegistersGroup.Location = new Point(799, 225);
            auxiliaryRegistersGroup.Name = "auxiliaryRegistersGroup";
            auxiliaryRegistersGroup.Size = new Size(232, 145);
            auxiliaryRegistersGroup.TabIndex = 4;
            auxiliaryRegistersGroup.TabStop = false;
            auxiliaryRegistersGroup.Text = "Auxiliary";
            // 
            // auxiliaryRegistersTableLayout
            // 
            auxiliaryRegistersTableLayout.ColumnCount = 2;
            auxiliaryRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.2035389F));
            auxiliaryRegistersTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.79646F));
            auxiliaryRegistersTableLayout.Controls.Add(ivrValue, 1, 2);
            auxiliaryRegistersTableLayout.Controls.Add(auxiliaryRegistersTableColumn1Label, 1, 0);
            auxiliaryRegistersTableLayout.Controls.Add(auxiliaryRegistersTableColumn0Label, 0, 0);
            auxiliaryRegistersTableLayout.Controls.Add(tLabel, 0, 1);
            auxiliaryRegistersTableLayout.Controls.Add(ivrLabel, 0, 2);
            auxiliaryRegistersTableLayout.Controls.Add(tValue, 1, 1);
            auxiliaryRegistersTableLayout.Dock = DockStyle.Fill;
            auxiliaryRegistersTableLayout.Location = new Point(3, 23);
            auxiliaryRegistersTableLayout.Name = "auxiliaryRegistersTableLayout";
            auxiliaryRegistersTableLayout.RowCount = 3;
            auxiliaryRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            auxiliaryRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            auxiliaryRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            auxiliaryRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            auxiliaryRegistersTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            auxiliaryRegistersTableLayout.Size = new Size(226, 119);
            auxiliaryRegistersTableLayout.TabIndex = 2;
            // 
            // ivrValue
            // 
            ivrValue.Location = new Point(69, 81);
            ivrValue.Name = "ivrValue";
            ivrValue.ReadOnly = true;
            ivrValue.Size = new Size(50, 27);
            ivrValue.TabIndex = 22;
            ivrValue.Text = "0x0";
            // 
            // auxiliaryRegistersTableColumn1Label
            // 
            auxiliaryRegistersTableColumn1Label.AutoSize = true;
            auxiliaryRegistersTableColumn1Label.Location = new Point(69, 0);
            auxiliaryRegistersTableColumn1Label.Name = "auxiliaryRegistersTableColumn1Label";
            auxiliaryRegistersTableColumn1Label.Size = new Size(45, 20);
            auxiliaryRegistersTableColumn1Label.TabIndex = 4;
            auxiliaryRegistersTableColumn1Label.Text = "Value";
            // 
            // auxiliaryRegistersTableColumn0Label
            // 
            auxiliaryRegistersTableColumn0Label.AutoSize = true;
            auxiliaryRegistersTableColumn0Label.Location = new Point(3, 0);
            auxiliaryRegistersTableColumn0Label.Name = "auxiliaryRegistersTableColumn0Label";
            auxiliaryRegistersTableColumn0Label.Size = new Size(49, 20);
            auxiliaryRegistersTableColumn0Label.TabIndex = 2;
            auxiliaryRegistersTableColumn0Label.Text = "Name";
            // 
            // tLabel
            // 
            tLabel.AutoSize = true;
            tLabel.Location = new Point(3, 39);
            tLabel.Name = "tLabel";
            tLabel.Size = new Size(17, 20);
            tLabel.TabIndex = 0;
            tLabel.Text = "T";
            // 
            // ivrLabel
            // 
            ivrLabel.AutoSize = true;
            ivrLabel.Location = new Point(3, 78);
            ivrLabel.Name = "ivrLabel";
            ivrLabel.Size = new Size(31, 20);
            ivrLabel.TabIndex = 6;
            ivrLabel.Text = "IVR";
            // 
            // tValue
            // 
            tValue.Location = new Point(69, 42);
            tValue.Name = "tValue";
            tValue.ReadOnly = true;
            tValue.Size = new Size(50, 27);
            tValue.TabIndex = 20;
            tValue.Text = "0x0";
            // 
            // busGroup
            // 
            busGroup.Controls.Add(busTableLayout);
            busGroup.Location = new Point(15, 422);
            busGroup.Name = "busGroup";
            busGroup.Size = new Size(229, 145);
            busGroup.TabIndex = 5;
            busGroup.TabStop = false;
            busGroup.Text = "Bus";
            // 
            // busTableLayout
            // 
            busTableLayout.ColumnCount = 2;
            busTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.87444F));
            busTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.12556F));
            busTableLayout.Controls.Add(rbusValue, 1, 3);
            busTableLayout.Controls.Add(rbusLabel, 0, 3);
            busTableLayout.Controls.Add(dbusValue, 1, 2);
            busTableLayout.Controls.Add(busRegistersTableColumn1Label, 1, 0);
            busTableLayout.Controls.Add(busRegistersTableColumn0Label, 0, 0);
            busTableLayout.Controls.Add(sbusLabel, 0, 1);
            busTableLayout.Controls.Add(dbusLabel, 0, 2);
            busTableLayout.Controls.Add(sbusValue, 1, 1);
            busTableLayout.Dock = DockStyle.Fill;
            busTableLayout.Location = new Point(3, 23);
            busTableLayout.Name = "busTableLayout";
            busTableLayout.RowCount = 4;
            busTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            busTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            busTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            busTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            busTableLayout.Size = new Size(223, 119);
            busTableLayout.TabIndex = 2;
            // 
            // rbusValue
            // 
            rbusValue.Location = new Point(83, 90);
            rbusValue.Name = "rbusValue";
            rbusValue.ReadOnly = true;
            rbusValue.Size = new Size(50, 27);
            rbusValue.TabIndex = 24;
            rbusValue.Text = "0x0";
            // 
            // rbusLabel
            // 
            rbusLabel.AutoSize = true;
            rbusLabel.Location = new Point(3, 87);
            rbusLabel.Name = "rbusLabel";
            rbusLabel.Size = new Size(45, 20);
            rbusLabel.TabIndex = 23;
            rbusLabel.Text = "RBUS";
            // 
            // dbusValue
            // 
            dbusValue.Location = new Point(83, 61);
            dbusValue.Name = "dbusValue";
            dbusValue.ReadOnly = true;
            dbusValue.Size = new Size(50, 27);
            dbusValue.TabIndex = 22;
            dbusValue.Text = "0x0";
            // 
            // busRegistersTableColumn1Label
            // 
            busRegistersTableColumn1Label.AutoSize = true;
            busRegistersTableColumn1Label.Location = new Point(83, 0);
            busRegistersTableColumn1Label.Name = "busRegistersTableColumn1Label";
            busRegistersTableColumn1Label.Size = new Size(45, 20);
            busRegistersTableColumn1Label.TabIndex = 4;
            busRegistersTableColumn1Label.Text = "Value";
            // 
            // busRegistersTableColumn0Label
            // 
            busRegistersTableColumn0Label.AutoSize = true;
            busRegistersTableColumn0Label.Location = new Point(3, 0);
            busRegistersTableColumn0Label.Name = "busRegistersTableColumn0Label";
            busRegistersTableColumn0Label.Size = new Size(49, 20);
            busRegistersTableColumn0Label.TabIndex = 2;
            busRegistersTableColumn0Label.Text = "Name";
            // 
            // sbusLabel
            // 
            sbusLabel.AutoSize = true;
            sbusLabel.Location = new Point(3, 29);
            sbusLabel.Name = "sbusLabel";
            sbusLabel.Size = new Size(44, 20);
            sbusLabel.TabIndex = 0;
            sbusLabel.Text = "SBUS";
            // 
            // dbusLabel
            // 
            dbusLabel.AutoSize = true;
            dbusLabel.Location = new Point(3, 58);
            dbusLabel.Name = "dbusLabel";
            dbusLabel.Size = new Size(47, 20);
            dbusLabel.TabIndex = 6;
            dbusLabel.Text = "DBUS";
            // 
            // sbusValue
            // 
            sbusValue.Location = new Point(83, 32);
            sbusValue.Name = "sbusValue";
            sbusValue.ReadOnly = true;
            sbusValue.Size = new Size(50, 27);
            sbusValue.TabIndex = 20;
            sbusValue.Text = "0x0";
            // 
            // aluGroup
            // 
            aluGroup.Controls.Add(tableLayoutPanel1);
            aluGroup.Location = new Point(534, 44);
            aluGroup.Name = "aluGroup";
            aluGroup.Size = new Size(229, 326);
            aluGroup.TabIndex = 6;
            aluGroup.TabStop = false;
            aluGroup.Text = "ALU";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.4618835F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.5381165F));
            tableLayoutPanel1.Controls.Add(outputRValue, 1, 4);
            tableLayoutPanel1.Controls.Add(outputRLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(operationValue, 1, 3);
            tableLayoutPanel1.Controls.Add(operationLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(inputDValue, 1, 2);
            tableLayoutPanel1.Controls.Add(aluTableColumn1Label, 1, 0);
            tableLayoutPanel1.Controls.Add(aluTableColumn0Label, 0, 0);
            tableLayoutPanel1.Controls.Add(inputSLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(inputDLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(inputSValue, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(223, 300);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // outputRValue
            // 
            outputRValue.Location = new Point(91, 243);
            outputRValue.Name = "outputRValue";
            outputRValue.ReadOnly = true;
            outputRValue.Size = new Size(50, 27);
            outputRValue.TabIndex = 26;
            outputRValue.Text = "0x0";
            // 
            // outputRLabel
            // 
            outputRLabel.AutoSize = true;
            outputRLabel.Location = new Point(3, 240);
            outputRLabel.Name = "outputRLabel";
            outputRLabel.Size = new Size(68, 20);
            outputRLabel.TabIndex = 25;
            outputRLabel.Text = "Output R";
            // 
            // operationValue
            // 
            operationValue.Location = new Point(91, 183);
            operationValue.Name = "operationValue";
            operationValue.ReadOnly = true;
            operationValue.Size = new Size(50, 27);
            operationValue.TabIndex = 24;
            operationValue.Text = "NaN";
            // 
            // operationLabel
            // 
            operationLabel.AutoSize = true;
            operationLabel.Location = new Point(3, 180);
            operationLabel.Name = "operationLabel";
            operationLabel.Size = new Size(76, 20);
            operationLabel.TabIndex = 23;
            operationLabel.Text = "Operation";
            // 
            // inputDValue
            // 
            inputDValue.Location = new Point(91, 123);
            inputDValue.Name = "inputDValue";
            inputDValue.ReadOnly = true;
            inputDValue.Size = new Size(50, 27);
            inputDValue.TabIndex = 22;
            inputDValue.Text = "0x0";
            // 
            // aluTableColumn1Label
            // 
            aluTableColumn1Label.AutoSize = true;
            aluTableColumn1Label.Location = new Point(91, 0);
            aluTableColumn1Label.Name = "aluTableColumn1Label";
            aluTableColumn1Label.Size = new Size(45, 20);
            aluTableColumn1Label.TabIndex = 4;
            aluTableColumn1Label.Text = "Value";
            // 
            // aluTableColumn0Label
            // 
            aluTableColumn0Label.AutoSize = true;
            aluTableColumn0Label.Location = new Point(3, 0);
            aluTableColumn0Label.Name = "aluTableColumn0Label";
            aluTableColumn0Label.Size = new Size(49, 20);
            aluTableColumn0Label.TabIndex = 2;
            aluTableColumn0Label.Text = "Name";
            // 
            // inputSLabel
            // 
            inputSLabel.AutoSize = true;
            inputSLabel.Location = new Point(3, 60);
            inputSLabel.Name = "inputSLabel";
            inputSLabel.Size = new Size(55, 20);
            inputSLabel.TabIndex = 0;
            inputSLabel.Text = "Input S";
            // 
            // inputDLabel
            // 
            inputDLabel.AutoSize = true;
            inputDLabel.Location = new Point(3, 120);
            inputDLabel.Name = "inputDLabel";
            inputDLabel.Size = new Size(58, 20);
            inputDLabel.TabIndex = 6;
            inputDLabel.Text = "Input D";
            // 
            // inputSValue
            // 
            inputSValue.Location = new Point(91, 63);
            inputSValue.Name = "inputSValue";
            inputSValue.ReadOnly = true;
            inputSValue.Size = new Size(50, 27);
            inputSValue.TabIndex = 20;
            inputSValue.Text = "0x0";
            // 
            // parsedTextBox
            // 
            parsedTextBox.Location = new Point(329, 422);
            parsedTextBox.Multiline = true;
            parsedTextBox.Name = "parsedTextBox";
            parsedTextBox.ScrollBars = ScrollBars.Vertical;
            parsedTextBox.Size = new Size(150, 150);
            parsedTextBox.TabIndex = 7;
            // 
            // parsedTextLabel
            // 
            parsedTextLabel.AutoSize = true;
            parsedTextLabel.Location = new Point(329, 399);
            parsedTextLabel.Name = "parsedTextLabel";
            parsedTextLabel.Size = new Size(55, 20);
            parsedTextLabel.TabIndex = 8;
            parsedTextLabel.Text = "Parsed:";
            // 
            // CPUViewerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 606);
            Controls.Add(parsedTextLabel);
            Controls.Add(parsedTextBox);
            Controls.Add(aluGroup);
            Controls.Add(busGroup);
            Controls.Add(auxiliaryRegistersGroup);
            Controls.Add(memoryInterfaceRegistersGroup);
            Controls.Add(controlAndStatusRegistersGroup);
            Controls.Add(generalRegistersGroup);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "CPUViewerForm";
            Text = "CPUViewer";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            generalRegistersGroup.ResumeLayout(false);
            generalRegistersTableLayout.ResumeLayout(false);
            generalRegistersTableLayout.PerformLayout();
            controlAndStatusRegistersGroup.ResumeLayout(false);
            contorlAndStatusRegistersTableLayout.ResumeLayout(false);
            contorlAndStatusRegistersTableLayout.PerformLayout();
            memoryInterfaceRegistersGroup.ResumeLayout(false);
            memoryInterfaceRegistersTableLayout.ResumeLayout(false);
            memoryInterfaceRegistersTableLayout.PerformLayout();
            auxiliaryRegistersGroup.ResumeLayout(false);
            auxiliaryRegistersTableLayout.ResumeLayout(false);
            auxiliaryRegistersTableLayout.PerformLayout();
            busGroup.ResumeLayout(false);
            busTableLayout.ResumeLayout(false);
            busTableLayout.PerformLayout();
            aluGroup.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Custom Variables

        private List<String> parsedLines;

        private InstructionLoader instructionLoader = new InstructionLoader();

        private MicroprogramLoader microprogramLoader = new MicroprogramLoader();

        private ProcessorCore processorCore;
        
        private bool isAssembled = false;

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem stepToolStripMenuItem;
        private GroupBox generalRegistersGroup;
        private TableLayoutPanel generalRegistersTableLayout;
        private Label r1Label;
        private Label r0Label;
        private Label generalRegistersTableColumn0Label;
        private Label generalRegistersTableColumn1Label;
        private Label generalRegistersTableColumn2Label;
        private Label generalRegistersTableColumn3Label;
        private Label r2Label;
        private Label r13Label;
        private Label r3Label;
        private Label r4Label;
        private Label r5Label;
        private Label r6Label;
        private Label r7Label;
        private Label r8Label;
        private Label r9Label;
        private Label r10Label;
        private Label r11Label;
        private Label r12Label;
        private Label r15Label;
        private Label r14Label;
        private TextBox r0Value;
        private TextBox r15Value;
        private TextBox r14Value;
        private TextBox r13Value;
        private TextBox r12Value;
        private TextBox r11Value;
        private TextBox r10Value;
        private TextBox r9Value;
        private TextBox r8Value;
        private TextBox r7Value;
        private TextBox r6Value;
        private TextBox r5Value;
        private TextBox r4Value;
        private TextBox r3Value;
        private TextBox r2Value;
        private TextBox r1Value;
        private GroupBox controlAndStatusRegistersGroup;
        private TableLayoutPanel contorlAndStatusRegistersTableLayout;
        private TextBox spValue;
        private TextBox flagValue;
        private TextBox irValue;
        private Label controlAndStatusRegistersTableColumn1Label;
        private Label controlAndStatusRegistersTableColumn0Label;
        private Label pcLabel;
        private Label irLabel;
        private Label flagLabel;
        private Label spLabel;
        private TextBox pcValue;
        private GroupBox memoryInterfaceRegistersGroup;
        private TableLayoutPanel memoryInterfaceRegistersTableLayout;
        private TextBox mdrValue;
        private Label memoryInterfaceRegistersTableColumn1Label;
        private Label memoryInterfaceRegistersTableColumn0Label;
        private Label adrLabel;
        private Label mdrLabel;
        private TextBox adrValue;
        private GroupBox auxiliaryRegistersGroup;
        private TableLayoutPanel auxiliaryRegistersTableLayout;
        private TextBox ivrValue;
        private Label auxiliaryRegistersTableColumn1Label;
        private Label auxiliaryRegistersTableColumn0Label;
        private Label tLabel;
        private Label ivrLabel;
        private TextBox tValue;
        private GroupBox busGroup;
        private TableLayoutPanel busTableLayout;
        private TextBox dbusValue;
        private Label busRegistersTableColumn1Label;
        private Label busRegistersTableColumn0Label;
        private Label sbusLabel;
        private Label dbusLabel;
        private TextBox sbusValue;
        private TextBox rbusValue;
        private Label rbusLabel;
        private GroupBox aluGroup;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox operationValue;
        private Label operationLabel;
        private TextBox inputDValue;
        private Label aluTableColumn1Label;
        private Label aluTableColumn0Label;
        private Label inputSLabel;
        private Label inputDLabel;
        private TextBox inputSValue;
        private Label outputRLabel;
        private TextBox outputRValue;
        private TextBox parsedTextBox;
        private Label parsedTextLabel;
    }
}
