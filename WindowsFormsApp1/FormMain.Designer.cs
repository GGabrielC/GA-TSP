using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_GaRunStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xqf131ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPath = new System.Windows.Forms.Panel();
            this.numericUpDownMaxGenerations = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMutationRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiscrimination = new System.Windows.Forms.NumericUpDown();
            this.labelMutationRate = new System.Windows.Forms.Label();
            this.labelMaxGenerations = new System.Windows.Forms.Label();
            this.labelPopulationSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxAddBestToPopulation = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawBestSolution = new System.Windows.Forms.CheckBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelMaxGenerationsValue = new System.Windows.Forms.Label();
            this.labelFitnessDiscriminatorValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMutationRateValue = new System.Windows.Forms.Label();
            this.labelPopulationSizeValue = new System.Windows.Forms.Label();
            this.labelLastShortestPathValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelBestShortestPathValue = new System.Windows.Forms.Label();
            this.labelShortestPath = new System.Windows.Forms.Label();
            this.labelCurrentGenerationValue = new System.Windows.Forms.Label();
            this.labelCurrentGeneration = new System.Windows.Forms.Label();
            this.sampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutationRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscrimination)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_GaRunStatus,
            this.inputToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1620, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_GaRunStatus
            // 
            this.toolStripMenuItem_GaRunStatus.Name = "toolStripMenuItem_GaRunStatus";
            this.toolStripMenuItem_GaRunStatus.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem_GaRunStatus.Text = "Run";
            this.toolStripMenuItem_GaRunStatus.Click += new System.EventHandler(this.ToolStripMenuItem_GaRunStatus_Click);
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomInputToolStripMenuItem,
            this.fileInputToolStripMenuItem,
            this.textToolStripMenuItem,
            this.xqf131ToolStripMenuItem,
            this.sampleToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.inputToolStripMenuItem.Text = "Input";
            // 
            // randomInputToolStripMenuItem
            // 
            this.randomInputToolStripMenuItem.Name = "randomInputToolStripMenuItem";
            this.randomInputToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.randomInputToolStripMenuItem.Text = "Random";
            this.randomInputToolStripMenuItem.Click += new System.EventHandler(this.randomInputToolStripMenuItem_Click);
            // 
            // fileInputToolStripMenuItem
            // 
            this.fileInputToolStripMenuItem.Name = "fileInputToolStripMenuItem";
            this.fileInputToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.fileInputToolStripMenuItem.Text = "File";
            this.fileInputToolStripMenuItem.Click += new System.EventHandler(this.fileInputToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // xqf131ToolStripMenuItem
            // 
            this.xqf131ToolStripMenuItem.Name = "xqf131ToolStripMenuItem";
            this.xqf131ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.xqf131ToolStripMenuItem.Text = "xqf131";
            this.xqf131ToolStripMenuItem.Click += new System.EventHandler(this.xqf131ToolStripMenuItem_Click);
            // 
            // panelPath
            // 
            this.panelPath.AutoSize = true;
            this.panelPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPath.Location = new System.Drawing.Point(304, 31);
            this.panelPath.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.panelPath.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.panelPath.Name = "panelPath";
            this.panelPath.Size = new System.Drawing.Size(1500, 1000);
            this.panelPath.TabIndex = 0;
            this.panelPath.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPath_Paint);
            // 
            // numericUpDownMaxGenerations
            // 
            this.numericUpDownMaxGenerations.AccessibleDescription = "";
            this.numericUpDownMaxGenerations.AccessibleName = "";
            this.numericUpDownMaxGenerations.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxGenerations.Location = new System.Drawing.Point(161, 26);
            this.numericUpDownMaxGenerations.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownMaxGenerations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxGenerations.Name = "numericUpDownMaxGenerations";
            this.numericUpDownMaxGenerations.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMaxGenerations.TabIndex = 9;
            this.numericUpDownMaxGenerations.Tag = "";
            this.numericUpDownMaxGenerations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMaxGenerations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxGenerations.ValueChanged += new System.EventHandler(this.numericUpDownMaxGenerations_ValueChanged);
            // 
            // numericUpDownMutationRate
            // 
            this.numericUpDownMutationRate.DecimalPlaces = 4;
            this.numericUpDownMutationRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numericUpDownMutationRate.Location = new System.Drawing.Point(161, 54);
            this.numericUpDownMutationRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMutationRate.Name = "numericUpDownMutationRate";
            this.numericUpDownMutationRate.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMutationRate.TabIndex = 10;
            this.numericUpDownMutationRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMutationRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownMutationRate.ValueChanged += new System.EventHandler(this.numericUpDownMutationRate_ValueChanged);
            // 
            // numericUpDownPopulationSize
            // 
            this.numericUpDownPopulationSize.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPopulationSize.Location = new System.Drawing.Point(161, 82);
            this.numericUpDownPopulationSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPopulationSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPopulationSize.Name = "numericUpDownPopulationSize";
            this.numericUpDownPopulationSize.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPopulationSize.TabIndex = 11;
            this.numericUpDownPopulationSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPopulationSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPopulationSize.ValueChanged += new System.EventHandler(this.numericUpDownPopulationSize_ValueChanged);
            // 
            // numericUpDownDiscrimination
            // 
            this.numericUpDownDiscrimination.Location = new System.Drawing.Point(161, 110);
            this.numericUpDownDiscrimination.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownDiscrimination.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDiscrimination.Name = "numericUpDownDiscrimination";
            this.numericUpDownDiscrimination.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDiscrimination.TabIndex = 12;
            this.numericUpDownDiscrimination.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDiscrimination.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDiscrimination.ValueChanged += new System.EventHandler(this.numericUpDownDiscrimination_ValueChanged);
            // 
            // labelMutationRate
            // 
            this.labelMutationRate.AutoSize = true;
            this.labelMutationRate.Location = new System.Drawing.Point(59, 54);
            this.labelMutationRate.Name = "labelMutationRate";
            this.labelMutationRate.Size = new System.Drawing.Size(96, 17);
            this.labelMutationRate.TabIndex = 13;
            this.labelMutationRate.Text = "Mutation Rate";
            // 
            // labelMaxGenerations
            // 
            this.labelMaxGenerations.AutoSize = true;
            this.labelMaxGenerations.Location = new System.Drawing.Point(36, 26);
            this.labelMaxGenerations.Name = "labelMaxGenerations";
            this.labelMaxGenerations.Size = new System.Drawing.Size(119, 17);
            this.labelMaxGenerations.TabIndex = 14;
            this.labelMaxGenerations.Text = "Max. Generations";
            // 
            // labelPopulationSize
            // 
            this.labelPopulationSize.AutoSize = true;
            this.labelPopulationSize.Location = new System.Drawing.Point(49, 82);
            this.labelPopulationSize.Name = "labelPopulationSize";
            this.labelPopulationSize.Size = new System.Drawing.Size(106, 17);
            this.labelPopulationSize.TabIndex = 15;
            this.labelPopulationSize.Text = "Population Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fitness Discriminator";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.checkBoxAddBestToPopulation);
            this.groupBoxSettings.Controls.Add(this.checkBoxDrawBestSolution);
            this.groupBoxSettings.Controls.Add(this.numericUpDownDiscrimination);
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Controls.Add(this.labelMaxGenerations);
            this.groupBoxSettings.Controls.Add(this.numericUpDownMaxGenerations);
            this.groupBoxSettings.Controls.Add(this.numericUpDownMutationRate);
            this.groupBoxSettings.Controls.Add(this.numericUpDownPopulationSize);
            this.groupBoxSettings.Controls.Add(this.labelPopulationSize);
            this.groupBoxSettings.Controls.Add(this.labelMutationRate);
            this.groupBoxSettings.Location = new System.Drawing.Point(3, 45);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(295, 214);
            this.groupBoxSettings.TabIndex = 19;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // checkBoxAddBestToPopulation
            // 
            this.checkBoxAddBestToPopulation.AutoSize = true;
            this.checkBoxAddBestToPopulation.Location = new System.Drawing.Point(25, 175);
            this.checkBoxAddBestToPopulation.Name = "checkBoxAddBestToPopulation";
            this.checkBoxAddBestToPopulation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAddBestToPopulation.Size = new System.Drawing.Size(234, 21);
            this.checkBoxAddBestToPopulation.TabIndex = 25;
            this.checkBoxAddBestToPopulation.Text = "Add Best Solution To Population";
            this.checkBoxAddBestToPopulation.UseVisualStyleBackColor = true;
            this.checkBoxAddBestToPopulation.CheckedChanged += new System.EventHandler(this.checkBoxAddBestToPopulation_CheckedChanged);
            // 
            // checkBoxDrawBestSolution
            // 
            this.checkBoxDrawBestSolution.AutoSize = true;
            this.checkBoxDrawBestSolution.Checked = true;
            this.checkBoxDrawBestSolution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrawBestSolution.Location = new System.Drawing.Point(78, 148);
            this.checkBoxDrawBestSolution.Name = "checkBoxDrawBestSolution";
            this.checkBoxDrawBestSolution.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDrawBestSolution.Size = new System.Drawing.Size(180, 21);
            this.checkBoxDrawBestSolution.TabIndex = 24;
            this.checkBoxDrawBestSolution.Text = "Draw New Best Solution";
            this.checkBoxDrawBestSolution.UseVisualStyleBackColor = true;
            this.checkBoxDrawBestSolution.CheckedChanged += new System.EventHandler(this.checkBoxDrawBestSolution_CheckedChanged);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelStatus);
            this.groupBoxInfo.Controls.Add(this.labelMaxGenerationsValue);
            this.groupBoxInfo.Controls.Add(this.labelFitnessDiscriminatorValue);
            this.groupBoxInfo.Controls.Add(this.label10);
            this.groupBoxInfo.Controls.Add(this.label8);
            this.groupBoxInfo.Controls.Add(this.label4);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.labelMutationRateValue);
            this.groupBoxInfo.Controls.Add(this.labelPopulationSizeValue);
            this.groupBoxInfo.Controls.Add(this.labelLastShortestPathValue);
            this.groupBoxInfo.Controls.Add(this.label6);
            this.groupBoxInfo.Controls.Add(this.labelBestShortestPathValue);
            this.groupBoxInfo.Controls.Add(this.labelShortestPath);
            this.groupBoxInfo.Controls.Add(this.labelCurrentGenerationValue);
            this.groupBoxInfo.Controls.Add(this.labelCurrentGeneration);
            this.groupBoxInfo.Location = new System.Drawing.Point(3, 265);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(281, 287);
            this.groupBoxInfo.TabIndex = 20;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(95, 257);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(59, 17);
            this.labelStatus.TabIndex = 23;
            this.labelStatus.Text = "no input";
            // 
            // labelMaxGenerationsValue
            // 
            this.labelMaxGenerationsValue.AutoSize = true;
            this.labelMaxGenerationsValue.Location = new System.Drawing.Point(149, 131);
            this.labelMaxGenerationsValue.Name = "labelMaxGenerationsValue";
            this.labelMaxGenerationsValue.Size = new System.Drawing.Size(44, 17);
            this.labelMaxGenerationsValue.TabIndex = 21;
            this.labelMaxGenerationsValue.Text = "Value";
            // 
            // labelFitnessDiscriminatorValue
            // 
            this.labelFitnessDiscriminatorValue.AutoSize = true;
            this.labelFitnessDiscriminatorValue.Location = new System.Drawing.Point(149, 209);
            this.labelFitnessDiscriminatorValue.Name = "labelFitnessDiscriminatorValue";
            this.labelFitnessDiscriminatorValue.Size = new System.Drawing.Size(44, 17);
            this.labelFitnessDiscriminatorValue.TabIndex = 20;
            this.labelFitnessDiscriminatorValue.Text = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fitness Discriminator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Population Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mutation Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Max. Generations";
            // 
            // labelMutationRateValue
            // 
            this.labelMutationRateValue.AutoSize = true;
            this.labelMutationRateValue.Location = new System.Drawing.Point(149, 158);
            this.labelMutationRateValue.Name = "labelMutationRateValue";
            this.labelMutationRateValue.Size = new System.Drawing.Size(44, 17);
            this.labelMutationRateValue.TabIndex = 7;
            this.labelMutationRateValue.Text = "Value";
            // 
            // labelPopulationSizeValue
            // 
            this.labelPopulationSizeValue.AutoSize = true;
            this.labelPopulationSizeValue.Location = new System.Drawing.Point(149, 182);
            this.labelPopulationSizeValue.Name = "labelPopulationSizeValue";
            this.labelPopulationSizeValue.Size = new System.Drawing.Size(44, 17);
            this.labelPopulationSizeValue.TabIndex = 6;
            this.labelPopulationSizeValue.Text = "Value";
            // 
            // labelLastShortestPathValue
            // 
            this.labelLastShortestPathValue.AutoSize = true;
            this.labelLastShortestPathValue.Location = new System.Drawing.Point(149, 88);
            this.labelLastShortestPathValue.Name = "labelLastShortestPathValue";
            this.labelLastShortestPathValue.Size = new System.Drawing.Size(44, 17);
            this.labelLastShortestPathValue.TabIndex = 5;
            this.labelLastShortestPathValue.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Last Shortest Path";
            // 
            // labelBestShortestPathValue
            // 
            this.labelBestShortestPathValue.AutoSize = true;
            this.labelBestShortestPathValue.Location = new System.Drawing.Point(149, 62);
            this.labelBestShortestPathValue.Name = "labelBestShortestPathValue";
            this.labelBestShortestPathValue.Size = new System.Drawing.Size(44, 17);
            this.labelBestShortestPathValue.TabIndex = 3;
            this.labelBestShortestPathValue.Text = "Value";
            // 
            // labelShortestPath
            // 
            this.labelShortestPath.AutoSize = true;
            this.labelShortestPath.Location = new System.Drawing.Point(20, 62);
            this.labelShortestPath.Name = "labelShortestPath";
            this.labelShortestPath.Size = new System.Drawing.Size(126, 17);
            this.labelShortestPath.TabIndex = 2;
            this.labelShortestPath.Text = "Best Shortest Path";
            // 
            // labelCurrentGenerationValue
            // 
            this.labelCurrentGenerationValue.AutoSize = true;
            this.labelCurrentGenerationValue.Location = new System.Drawing.Point(149, 31);
            this.labelCurrentGenerationValue.Name = "labelCurrentGenerationValue";
            this.labelCurrentGenerationValue.Size = new System.Drawing.Size(44, 17);
            this.labelCurrentGenerationValue.TabIndex = 1;
            this.labelCurrentGenerationValue.Text = "Value";
            // 
            // labelCurrentGeneration
            // 
            this.labelCurrentGeneration.AutoSize = true;
            this.labelCurrentGeneration.Location = new System.Drawing.Point(11, 31);
            this.labelCurrentGeneration.Name = "labelCurrentGeneration";
            this.labelCurrentGeneration.Size = new System.Drawing.Size(130, 17);
            this.labelCurrentGeneration.TabIndex = 0;
            this.labelCurrentGeneration.Text = "Current Generation\r\n";
            // 
            // sampleToolStripMenuItem
            // 
            this.sampleToolStripMenuItem.Name = "sampleToolStripMenuItem";
            this.sampleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sampleToolStripMenuItem.Text = "Sample";
            this.sampleToolStripMenuItem.Click += new System.EventHandler(this.sampleToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 807);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.panelPath);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutationRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscrimination)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_GaRunStatus;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileInputToolStripMenuItem;
        private System.Windows.Forms.Panel panelPath;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxGenerations;
        private System.Windows.Forms.NumericUpDown numericUpDownMutationRate;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulationSize;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscrimination;
        private System.Windows.Forms.Label labelMutationRate;
        private System.Windows.Forms.Label labelMaxGenerations;
        private System.Windows.Forms.Label labelPopulationSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelMutationRateValue;
        private System.Windows.Forms.Label labelPopulationSizeValue;
        private System.Windows.Forms.Label labelLastShortestPathValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelBestShortestPathValue;
        private System.Windows.Forms.Label labelShortestPath;
        private System.Windows.Forms.Label labelCurrentGenerationValue;
        private System.Windows.Forms.Label labelCurrentGeneration;
        private System.Windows.Forms.Label labelMaxGenerationsValue;
        private System.Windows.Forms.Label labelFitnessDiscriminatorValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatus;
        private CheckBox checkBoxDrawBestSolution;
        private CheckBox checkBoxAddBestToPopulation;
        private ToolStripMenuItem xqf131ToolStripMenuItem;
        private ToolStripMenuItem sampleToolStripMenuItem;
    }
}

