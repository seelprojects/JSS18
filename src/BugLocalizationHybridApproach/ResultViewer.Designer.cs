namespace BugLocalizationHybridApproach
{
    partial class ResultViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultViewer));
            this.groupBoxDataset = new System.Windows.Forms.GroupBox();
            this.listBoxDataset = new System.Windows.Forms.ListBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxMethodI = new System.Windows.Forms.GroupBox();
            this.listBoxMethodI = new System.Windows.Forms.ListBox();
            this.groupBoxMethodJ = new System.Windows.Forms.GroupBox();
            this.listBoxMethodJ = new System.Windows.Forms.ListBox();
            this.groupBoxMetricToUse = new System.Windows.Forms.GroupBox();
            this.listBoxMetric = new System.Windows.Forms.ListBox();
            this.panelGraphs = new System.Windows.Forms.Panel();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxYMax = new System.Windows.Forms.TextBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.textBoxYInterval = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.textBoxYMin = new System.Windows.Forms.TextBox();
            this.textBoxXInterval = new System.Windows.Forms.TextBox();
            this.textBoxXMin = new System.Windows.Forms.TextBox();
            this.labelYMin = new System.Windows.Forms.Label();
            this.labelXMin = new System.Windows.Forms.Label();
            this.groupBoxDataset.SuspendLayout();
            this.groupBoxMethodI.SuspendLayout();
            this.groupBoxMethodJ.SuspendLayout();
            this.groupBoxMetricToUse.SuspendLayout();
            this.groupBoxSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDataset
            // 
            this.groupBoxDataset.Controls.Add(this.listBoxDataset);
            this.groupBoxDataset.Location = new System.Drawing.Point(11, 12);
            this.groupBoxDataset.Name = "groupBoxDataset";
            this.groupBoxDataset.Size = new System.Drawing.Size(133, 119);
            this.groupBoxDataset.TabIndex = 0;
            this.groupBoxDataset.TabStop = false;
            this.groupBoxDataset.Text = "Dataset";
            // 
            // listBoxDataset
            // 
            this.listBoxDataset.FormattingEnabled = true;
            this.listBoxDataset.Items.AddRange(new object[] {
            "AspectJ",
            "Eclipse",
            "JodaTime",
            "SWT",
            "ZXing"});
            this.listBoxDataset.Location = new System.Drawing.Point(6, 18);
            this.listBoxDataset.Name = "listBoxDataset";
            this.listBoxDataset.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDataset.Size = new System.Drawing.Size(120, 95);
            this.listBoxDataset.TabIndex = 3;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(942, 108);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 2;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // groupBoxMethodI
            // 
            this.groupBoxMethodI.Controls.Add(this.listBoxMethodI);
            this.groupBoxMethodI.Location = new System.Drawing.Point(150, 12);
            this.groupBoxMethodI.Name = "groupBoxMethodI";
            this.groupBoxMethodI.Size = new System.Drawing.Size(133, 119);
            this.groupBoxMethodI.TabIndex = 4;
            this.groupBoxMethodI.TabStop = false;
            this.groupBoxMethodI.Text = "Method i";
            // 
            // listBoxMethodI
            // 
            this.listBoxMethodI.FormattingEnabled = true;
            this.listBoxMethodI.Items.AddRange(new object[] {
            "VSM",
            "LSI",
            "JSM",
            "PMI"});
            this.listBoxMethodI.Location = new System.Drawing.Point(6, 18);
            this.listBoxMethodI.Name = "listBoxMethodI";
            this.listBoxMethodI.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMethodI.Size = new System.Drawing.Size(120, 95);
            this.listBoxMethodI.TabIndex = 3;
            // 
            // groupBoxMethodJ
            // 
            this.groupBoxMethodJ.Controls.Add(this.listBoxMethodJ);
            this.groupBoxMethodJ.Location = new System.Drawing.Point(289, 12);
            this.groupBoxMethodJ.Name = "groupBoxMethodJ";
            this.groupBoxMethodJ.Size = new System.Drawing.Size(133, 119);
            this.groupBoxMethodJ.TabIndex = 4;
            this.groupBoxMethodJ.TabStop = false;
            this.groupBoxMethodJ.Text = "Method j";
            // 
            // listBoxMethodJ
            // 
            this.listBoxMethodJ.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxMethodJ.FormattingEnabled = true;
            this.listBoxMethodJ.Items.AddRange(new object[] {
            "VSM",
            "LSI",
            "JSM",
            "PMI"});
            this.listBoxMethodJ.Location = new System.Drawing.Point(6, 18);
            this.listBoxMethodJ.Name = "listBoxMethodJ";
            this.listBoxMethodJ.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMethodJ.Size = new System.Drawing.Size(120, 95);
            this.listBoxMethodJ.TabIndex = 3;
            this.listBoxMethodJ.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxMethodJ_DrawItem);
            // 
            // groupBoxMetricToUse
            // 
            this.groupBoxMetricToUse.Controls.Add(this.listBoxMetric);
            this.groupBoxMetricToUse.Location = new System.Drawing.Point(428, 12);
            this.groupBoxMetricToUse.Name = "groupBoxMetricToUse";
            this.groupBoxMetricToUse.Size = new System.Drawing.Size(133, 119);
            this.groupBoxMetricToUse.TabIndex = 4;
            this.groupBoxMetricToUse.TabStop = false;
            this.groupBoxMetricToUse.Text = "Metric ";
            // 
            // listBoxMetric
            // 
            this.listBoxMetric.FormattingEnabled = true;
            this.listBoxMetric.Items.AddRange(new object[] {
            "TR1",
            "TR5",
            "TR10",
            "MAP",
            "MRR"});
            this.listBoxMetric.Location = new System.Drawing.Point(6, 18);
            this.listBoxMetric.Name = "listBoxMetric";
            this.listBoxMetric.Size = new System.Drawing.Size(120, 95);
            this.listBoxMetric.TabIndex = 3;
            this.listBoxMetric.SelectedValueChanged += new System.EventHandler(this.listBoxMetric_SelectedValueChanged);
            // 
            // panelGraphs
            // 
            this.panelGraphs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraphs.AutoScroll = true;
            this.panelGraphs.Location = new System.Drawing.Point(16, 138);
            this.panelGraphs.Name = "panelGraphs";
            this.panelGraphs.Size = new System.Drawing.Size(996, 343);
            this.panelGraphs.TabIndex = 5;
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Controls.Add(this.labelHeight);
            this.groupBoxSetting.Controls.Add(this.labelWidth);
            this.groupBoxSetting.Controls.Add(this.textBoxHeight);
            this.groupBoxSetting.Controls.Add(this.textBoxWidth);
            this.groupBoxSetting.Controls.Add(this.textBoxYMax);
            this.groupBoxSetting.Controls.Add(this.labelInterval);
            this.groupBoxSetting.Controls.Add(this.textBoxXMax);
            this.groupBoxSetting.Controls.Add(this.labelMax);
            this.groupBoxSetting.Controls.Add(this.textBoxYInterval);
            this.groupBoxSetting.Controls.Add(this.labelMin);
            this.groupBoxSetting.Controls.Add(this.textBoxYMin);
            this.groupBoxSetting.Controls.Add(this.textBoxXInterval);
            this.groupBoxSetting.Controls.Add(this.textBoxXMin);
            this.groupBoxSetting.Controls.Add(this.labelYMin);
            this.groupBoxSetting.Controls.Add(this.labelXMin);
            this.groupBoxSetting.Location = new System.Drawing.Point(567, 12);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(369, 119);
            this.groupBoxSetting.TabIndex = 6;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Setting";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(215, 69);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 15;
            this.labelHeight.Text = "Height";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(215, 43);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 14;
            this.labelWidth.Text = "Width";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(267, 66);
            this.textBoxHeight.MaxLength = 7;
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(43, 20);
            this.textBoxHeight.TabIndex = 13;
            this.textBoxHeight.Text = "300";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(267, 40);
            this.textBoxWidth.MaxLength = 7;
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(43, 20);
            this.textBoxWidth.TabIndex = 12;
            this.textBoxWidth.Text = "300";
            // 
            // textBoxYMax
            // 
            this.textBoxYMax.Location = new System.Drawing.Point(159, 66);
            this.textBoxYMax.MaxLength = 7;
            this.textBoxYMax.Name = "textBoxYMax";
            this.textBoxYMax.Size = new System.Drawing.Size(43, 20);
            this.textBoxYMax.TabIndex = 11;
            this.textBoxYMax.Text = "0";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(109, 18);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(42, 13);
            this.labelInterval.TabIndex = 10;
            this.labelInterval.Text = "Interval";
            // 
            // textBoxXMax
            // 
            this.textBoxXMax.Location = new System.Drawing.Point(159, 40);
            this.textBoxXMax.MaxLength = 7;
            this.textBoxXMax.Name = "textBoxXMax";
            this.textBoxXMax.Size = new System.Drawing.Size(43, 20);
            this.textBoxXMax.TabIndex = 9;
            this.textBoxXMax.Text = "0";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(166, 18);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 8;
            this.labelMax.Text = "Max";
            // 
            // textBoxYInterval
            // 
            this.textBoxYInterval.Location = new System.Drawing.Point(108, 66);
            this.textBoxYInterval.MaxLength = 7;
            this.textBoxYInterval.Name = "textBoxYInterval";
            this.textBoxYInterval.Size = new System.Drawing.Size(43, 20);
            this.textBoxYInterval.TabIndex = 7;
            this.textBoxYInterval.Text = "0";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(63, 18);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 6;
            this.labelMin.Text = "Min";
            // 
            // textBoxYMin
            // 
            this.textBoxYMin.Location = new System.Drawing.Point(55, 66);
            this.textBoxYMin.MaxLength = 7;
            this.textBoxYMin.Name = "textBoxYMin";
            this.textBoxYMin.Size = new System.Drawing.Size(43, 20);
            this.textBoxYMin.TabIndex = 5;
            this.textBoxYMin.Text = "0";
            // 
            // textBoxXInterval
            // 
            this.textBoxXInterval.Location = new System.Drawing.Point(108, 40);
            this.textBoxXInterval.MaxLength = 7;
            this.textBoxXInterval.Name = "textBoxXInterval";
            this.textBoxXInterval.Size = new System.Drawing.Size(43, 20);
            this.textBoxXInterval.TabIndex = 4;
            this.textBoxXInterval.Text = "0";
            // 
            // textBoxXMin
            // 
            this.textBoxXMin.Location = new System.Drawing.Point(55, 40);
            this.textBoxXMin.MaxLength = 7;
            this.textBoxXMin.Name = "textBoxXMin";
            this.textBoxXMin.Size = new System.Drawing.Size(43, 20);
            this.textBoxXMin.TabIndex = 2;
            this.textBoxXMin.Text = "0";
            // 
            // labelYMin
            // 
            this.labelYMin.AutoSize = true;
            this.labelYMin.Location = new System.Drawing.Point(32, 69);
            this.labelYMin.Name = "labelYMin";
            this.labelYMin.Size = new System.Drawing.Size(14, 13);
            this.labelYMin.TabIndex = 1;
            this.labelYMin.Text = "Y";
            // 
            // labelXMin
            // 
            this.labelXMin.AutoSize = true;
            this.labelXMin.Location = new System.Drawing.Point(32, 43);
            this.labelXMin.Name = "labelXMin";
            this.labelXMin.Size = new System.Drawing.Size(14, 13);
            this.labelXMin.TabIndex = 0;
            this.labelXMin.Text = "X";
            // 
            // ResultViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 493);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.panelGraphs);
            this.Controls.Add(this.groupBoxMetricToUse);
            this.Controls.Add(this.groupBoxMethodJ);
            this.Controls.Add(this.groupBoxMethodI);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.groupBoxDataset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultViewer";
            this.Text = "Hybrid Bug Localization";
            this.groupBoxDataset.ResumeLayout(false);
            this.groupBoxMethodI.ResumeLayout(false);
            this.groupBoxMethodJ.ResumeLayout(false);
            this.groupBoxMetricToUse.ResumeLayout(false);
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataset;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.ListBox listBoxDataset;
        private System.Windows.Forms.GroupBox groupBoxMethodI;
        private System.Windows.Forms.ListBox listBoxMethodI;
        private System.Windows.Forms.GroupBox groupBoxMethodJ;
        private System.Windows.Forms.ListBox listBoxMethodJ;
        private System.Windows.Forms.GroupBox groupBoxMetricToUse;
        private System.Windows.Forms.ListBox listBoxMetric;
        private System.Windows.Forms.Panel panelGraphs;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.TextBox textBoxYInterval;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox textBoxYMin;
        private System.Windows.Forms.TextBox textBoxXInterval;
        private System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.Label labelYMin;
        private System.Windows.Forms.Label labelXMin;
        private System.Windows.Forms.TextBox textBoxYMax;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
    }
}

