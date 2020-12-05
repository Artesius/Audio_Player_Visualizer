namespace Audio_Spectrum_Analyzer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbbb = new System.Windows.Forms.TextBox();
            this.columnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbbg = new System.Windows.Forms.TextBox();
            this.radialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbbr = new System.Windows.Forms.TextBox();
            this.tbba = new System.Windows.Forms.TextBox();
            this.lbba = new System.Windows.Forms.Label();
            this.lbbb = new System.Windows.Forms.Label();
            this.lbbg = new System.Windows.Forms.Label();
            this.spectrumTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbbr = new System.Windows.Forms.Label();
            this.lbln = new System.Windows.Forms.Label();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tbg = new System.Windows.Forms.TextBox();
            this.tbr = new System.Windows.Forms.TextBox();
            this.tba = new System.Windows.Forms.TextBox();
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.tbln = new System.Windows.Forms.TextBox();
            this.lbg = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spectrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainbowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowChangingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spectrumSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withReflectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutReflectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbr = new System.Windows.Forms.Label();
            this.lblRadial = new System.Windows.Forms.Label();
            this.devicelist = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbbb
            // 
            this.tbbb.Location = new System.Drawing.Point(581, 49);
            this.tbbb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbbb.Name = "tbbb";
            this.tbbb.Size = new System.Drawing.Size(43, 30);
            this.tbbb.TabIndex = 45;
            this.tbbb.Text = "255";
            this.tbbb.Visible = false;
            this.tbbb.TextChanged += new System.EventHandler(this.tbbb_TextChanged);
            // 
            // columnToolStripMenuItem
            // 
            this.columnToolStripMenuItem.Name = "columnToolStripMenuItem";
            this.columnToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.columnToolStripMenuItem.Text = "Column";
            this.columnToolStripMenuItem.Click += new System.EventHandler(this.columnToolStripMenuItem_Click);
            // 
            // tbbg
            // 
            this.tbbg.Location = new System.Drawing.Point(436, 49);
            this.tbbg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbbg.Name = "tbbg";
            this.tbbg.Size = new System.Drawing.Size(43, 30);
            this.tbbg.TabIndex = 44;
            this.tbbg.Text = "255";
            this.tbbg.Visible = false;
            this.tbbg.TextChanged += new System.EventHandler(this.tbbg_TextChanged);
            // 
            // radialToolStripMenuItem
            // 
            this.radialToolStripMenuItem.Name = "radialToolStripMenuItem";
            this.radialToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.radialToolStripMenuItem.Text = "Radial";
            this.radialToolStripMenuItem.Click += new System.EventHandler(this.radialToolStripMenuItem_Click);
            // 
            // tbbr
            // 
            this.tbbr.Location = new System.Drawing.Point(278, 49);
            this.tbbr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbbr.Name = "tbbr";
            this.tbbr.Size = new System.Drawing.Size(43, 30);
            this.tbbr.TabIndex = 43;
            this.tbbr.Text = "255";
            this.tbbr.Visible = false;
            this.tbbr.TextChanged += new System.EventHandler(this.tbbr_TextChanged);
            // 
            // tbba
            // 
            this.tbba.Location = new System.Drawing.Point(135, 49);
            this.tbba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbba.Name = "tbba";
            this.tbba.Size = new System.Drawing.Size(43, 30);
            this.tbba.TabIndex = 42;
            this.tbba.Text = "255";
            this.tbba.Visible = false;
            this.tbba.TextChanged += new System.EventHandler(this.tbba_TextChanged);
            // 
            // lbba
            // 
            this.lbba.AutoSize = true;
            this.lbba.Location = new System.Drawing.Point(13, 52);
            this.lbba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbba.Name = "lbba";
            this.lbba.Size = new System.Drawing.Size(139, 25);
            this.lbba.TabIndex = 41;
            this.lbba.Text = "Transparency:";
            this.lbba.Visible = false;
            // 
            // lbbb
            // 
            this.lbbb.AutoSize = true;
            this.lbbb.Location = new System.Drawing.Point(487, 52);
            this.lbbb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbb.Name = "lbbb";
            this.lbbb.Size = new System.Drawing.Size(109, 25);
            this.lbbb.TabIndex = 40;
            this.lbbb.Text = "Blue Color:";
            this.lbbb.Visible = false;
            // 
            // lbbg
            // 
            this.lbbg.AutoSize = true;
            this.lbbg.Location = new System.Drawing.Point(329, 52);
            this.lbbg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbg.Name = "lbbg";
            this.lbbg.Size = new System.Drawing.Size(124, 25);
            this.lbbg.TabIndex = 39;
            this.lbbg.Text = "Green Color:";
            this.lbbg.Visible = false;
            // 
            // spectrumTypeToolStripMenuItem
            // 
            this.spectrumTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.columnToolStripMenuItem,
            this.radialToolStripMenuItem,
            this.filledToolStripMenuItem});
            this.spectrumTypeToolStripMenuItem.Name = "spectrumTypeToolStripMenuItem";
            this.spectrumTypeToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.spectrumTypeToolStripMenuItem.Text = "Spectrum Type";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // filledToolStripMenuItem
            // 
            this.filledToolStripMenuItem.Name = "filledToolStripMenuItem";
            this.filledToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.filledToolStripMenuItem.Text = "Filled Range";
            this.filledToolStripMenuItem.Click += new System.EventHandler(this.filledToolStripMenuItem_Click);
            // 
            // lbbr
            // 
            this.lbbr.AutoSize = true;
            this.lbbr.Location = new System.Drawing.Point(186, 52);
            this.lbbr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbr.Name = "lbbr";
            this.lbbr.Size = new System.Drawing.Size(105, 25);
            this.lbbr.TabIndex = 38;
            this.lbbr.Text = "Red Color:";
            this.lbbr.Visible = false;
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(18, 52);
            this.lbln.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(153, 25);
            this.lbln.TabIndex = 36;
            this.lbln.Text = "Number of lines:";
            this.lbln.Visible = false;
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(581, 49);
            this.tbb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(43, 30);
            this.tbb.TabIndex = 35;
            this.tbb.Text = "0";
            this.tbb.Visible = false;
            this.tbb.TextChanged += new System.EventHandler(this.tbb_TextChanged);
            // 
            // tbg
            // 
            this.tbg.Location = new System.Drawing.Point(436, 49);
            this.tbg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbg.Name = "tbg";
            this.tbg.Size = new System.Drawing.Size(43, 30);
            this.tbg.TabIndex = 34;
            this.tbg.Text = "0";
            this.tbg.Visible = false;
            this.tbg.TextChanged += new System.EventHandler(this.tbg_TextChanged);
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(278, 49);
            this.tbr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(43, 30);
            this.tbr.TabIndex = 33;
            this.tbr.Text = "0";
            this.tbr.Visible = false;
            this.tbr.TextChanged += new System.EventHandler(this.tbr_TextChanged);
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(135, 49);
            this.tba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(43, 30);
            this.tba.TabIndex = 32;
            this.tba.Text = "255";
            this.tba.Visible = false;
            this.tba.TextChanged += new System.EventHandler(this.tba_TextChanged);
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(18, 52);
            this.lba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(139, 25);
            this.lba.TabIndex = 31;
            this.lba.Text = "Transparency:";
            this.lba.Visible = false;
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Location = new System.Drawing.Point(487, 52);
            this.lbb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(109, 25);
            this.lbb.TabIndex = 30;
            this.lbb.Text = "Blue Color:";
            this.lbb.Visible = false;
            // 
            // tbln
            // 
            this.tbln.Location = new System.Drawing.Point(149, 49);
            this.tbln.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbln.Name = "tbln";
            this.tbln.Size = new System.Drawing.Size(105, 30);
            this.tbln.TabIndex = 37;
            this.tbln.Text = "64";
            this.tbln.Visible = false;
            this.tbln.TextChanged += new System.EventHandler(this.tbln_TextChanged);
            // 
            // lbg
            // 
            this.lbg.AutoSize = true;
            this.lbg.Location = new System.Drawing.Point(329, 52);
            this.lbg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbg.Name = "lbg";
            this.lbg.Size = new System.Drawing.Size(124, 25);
            this.lbg.TabIndex = 29;
            this.lbg.Text = "Green Color:";
            this.lbg.Visible = false;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.SystemColors.Window;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.Maximum = 129D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Maximum = 1536D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(13, 87);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "wave";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(854, 463);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spectrumToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.reflectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(880, 30);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spectrumToolStripMenuItem
            // 
            this.spectrumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staticToolStripMenuItem1,
            this.slowChangingToolStripMenuItem});
            this.spectrumToolStripMenuItem.Name = "spectrumToolStripMenuItem";
            this.spectrumToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.spectrumToolStripMenuItem.Text = "Styles";
            // 
            // staticToolStripMenuItem1
            // 
            this.staticToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staticToolStripMenuItem,
            this.rainbowToolStripMenuItem,
            this.slowChangeToolStripMenuItem,
            this.fastChangeToolStripMenuItem});
            this.staticToolStripMenuItem1.Name = "staticToolStripMenuItem1";
            this.staticToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.staticToolStripMenuItem1.Text = "Spectrum";
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.staticToolStripMenuItem.Text = "Static";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.staticToolStripMenuItem_Click);
            // 
            // rainbowToolStripMenuItem
            // 
            this.rainbowToolStripMenuItem.Name = "rainbowToolStripMenuItem";
            this.rainbowToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.rainbowToolStripMenuItem.Text = "Rainbow";
            this.rainbowToolStripMenuItem.Click += new System.EventHandler(this.rainbowToolStripMenuItem_Click);
            // 
            // slowChangeToolStripMenuItem
            // 
            this.slowChangeToolStripMenuItem.Name = "slowChangeToolStripMenuItem";
            this.slowChangeToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.slowChangeToolStripMenuItem.Text = "Slow change";
            this.slowChangeToolStripMenuItem.Click += new System.EventHandler(this.slowChangeToolStripMenuItem_Click);
            // 
            // fastChangeToolStripMenuItem
            // 
            this.fastChangeToolStripMenuItem.Name = "fastChangeToolStripMenuItem";
            this.fastChangeToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.fastChangeToolStripMenuItem.Text = "Fast change";
            this.fastChangeToolStripMenuItem.Click += new System.EventHandler(this.fastChangeToolStripMenuItem_Click);
            // 
            // slowChangingToolStripMenuItem
            // 
            this.slowChangingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staticToolStripMenuItem2,
            this.imageToolStripMenuItem});
            this.slowChangingToolStripMenuItem.Name = "slowChangingToolStripMenuItem";
            this.slowChangingToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.slowChangingToolStripMenuItem.Text = "Background";
            // 
            // staticToolStripMenuItem2
            // 
            this.staticToolStripMenuItem2.Name = "staticToolStripMenuItem2";
            this.staticToolStripMenuItem2.Size = new System.Drawing.Size(134, 26);
            this.staticToolStripMenuItem2.Text = "Static";
            this.staticToolStripMenuItem2.Click += new System.EventHandler(this.staticToolStripMenuItem2_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorSettingToolStripMenuItem,
            this.spectrumSettingToolStripMenuItem,
            this.backgroundColorSettingToolStripMenuItem,
            this.spectrumTypeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // colorSettingToolStripMenuItem
            // 
            this.colorSettingToolStripMenuItem.Name = "colorSettingToolStripMenuItem";
            this.colorSettingToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.colorSettingToolStripMenuItem.Text = "Spectrum color setting";
            this.colorSettingToolStripMenuItem.Click += new System.EventHandler(this.colorSettingToolStripMenuItem_Click);
            // 
            // spectrumSettingToolStripMenuItem
            // 
            this.spectrumSettingToolStripMenuItem.Name = "spectrumSettingToolStripMenuItem";
            this.spectrumSettingToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.spectrumSettingToolStripMenuItem.Text = "Spectrum setting";
            this.spectrumSettingToolStripMenuItem.Click += new System.EventHandler(this.spectrumSettingToolStripMenuItem_Click);
            // 
            // backgroundColorSettingToolStripMenuItem
            // 
            this.backgroundColorSettingToolStripMenuItem.Name = "backgroundColorSettingToolStripMenuItem";
            this.backgroundColorSettingToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.backgroundColorSettingToolStripMenuItem.Text = "Background color setting";
            this.backgroundColorSettingToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorSettingToolStripMenuItem_Click);
            // 
            // reflectToolStripMenuItem
            // 
            this.reflectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withReflectionToolStripMenuItem,
            this.withoutReflectionToolStripMenuItem});
            this.reflectToolStripMenuItem.Name = "reflectToolStripMenuItem";
            this.reflectToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.reflectToolStripMenuItem.Text = "Reflect";
            // 
            // withReflectionToolStripMenuItem
            // 
            this.withReflectionToolStripMenuItem.Name = "withReflectionToolStripMenuItem";
            this.withReflectionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.withReflectionToolStripMenuItem.Text = "With Reflection";
            this.withReflectionToolStripMenuItem.Click += new System.EventHandler(this.withReflectionToolStripMenuItem_Click);
            // 
            // withoutReflectionToolStripMenuItem
            // 
            this.withoutReflectionToolStripMenuItem.Name = "withoutReflectionToolStripMenuItem";
            this.withoutReflectionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.withoutReflectionToolStripMenuItem.Text = "Without Reflection";
            this.withoutReflectionToolStripMenuItem.Click += new System.EventHandler(this.withoutReflectionToolStripMenuItem_Click);
            // 
            // lbr
            // 
            this.lbr.AutoSize = true;
            this.lbr.Location = new System.Drawing.Point(186, 52);
            this.lbr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbr.Name = "lbr";
            this.lbr.Size = new System.Drawing.Size(105, 25);
            this.lbr.TabIndex = 28;
            this.lbr.Text = "Red Color:";
            this.lbr.Visible = false;
            // 
            // lblRadial
            // 
            this.lblRadial.AutoSize = true;
            this.lblRadial.Location = new System.Drawing.Point(261, 52);
            this.lblRadial.Name = "lblRadial";
            this.lblRadial.Size = new System.Drawing.Size(544, 25);
            this.lblRadial.TabIndex = 46;
            this.lblRadial.Text = "Changing number of lines is not possible while in Radial mode";
            this.lblRadial.Visible = false;
            // 
            // devicelist
            // 
            this.devicelist.FormattingEnabled = true;
            this.devicelist.Location = new System.Drawing.Point(12, 47);
            this.devicelist.Name = "devicelist";
            this.devicelist.Size = new System.Drawing.Size(855, 33);
            this.devicelist.TabIndex = 47;
            this.devicelist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.devicelist);
            this.Controls.Add(this.lblRadial);
            this.Controls.Add(this.tbbb);
            this.Controls.Add(this.tbbg);
            this.Controls.Add(this.tbbr);
            this.Controls.Add(this.tbba);
            this.Controls.Add(this.lbba);
            this.Controls.Add(this.lbbb);
            this.Controls.Add(this.lbbg);
            this.Controls.Add(this.lbbr);
            this.Controls.Add(this.lbln);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tbg);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.tba);
            this.Controls.Add(this.lba);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.tbln);
            this.Controls.Add(this.lbg);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Spectrum Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbbb;
        private System.Windows.Forms.ToolStripMenuItem columnToolStripMenuItem;
        private System.Windows.Forms.TextBox tbbg;
        private System.Windows.Forms.ToolStripMenuItem radialToolStripMenuItem;
        private System.Windows.Forms.TextBox tbbr;
        private System.Windows.Forms.TextBox tbba;
        private System.Windows.Forms.Label lbba;
        private System.Windows.Forms.Label lbbb;
        private System.Windows.Forms.Label lbbg;
        private System.Windows.Forms.ToolStripMenuItem spectrumTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.Label lbbr;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tbg;
        private System.Windows.Forms.TextBox tbr;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.TextBox tbln;
        private System.Windows.Forms.Label lbg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spectrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainbowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowChangingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spectrumSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorSettingToolStripMenuItem;
        private System.Windows.Forms.Label lbr;
        private System.Windows.Forms.Label lblRadial;
        private System.Windows.Forms.ToolStripMenuItem filledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withReflectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withoutReflectionToolStripMenuItem;
        private System.Windows.Forms.ComboBox devicelist;
    }
}

