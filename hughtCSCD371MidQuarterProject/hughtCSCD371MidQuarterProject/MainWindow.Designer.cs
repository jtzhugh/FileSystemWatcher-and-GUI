namespace hughtCSCD371MidQuarterProject
{
    public partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.StartWatcher = new System.Windows.Forms.Button();
            this.StopWatcher = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ExtFilter = new System.Windows.Forms.Label();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.Directory = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DataWrite = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.MainFormQuery = new System.Windows.Forms.Button();
            this.QueryCombo = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolHelp = new System.Windows.Forms.ToolStripLabel();
            this.toolGo = new System.Windows.Forms.ToolStripButton();
            this.toolStop = new System.Windows.Forms.ToolStripButton();
            this.toolQ = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartWatcher
            // 
            this.StartWatcher.Location = new System.Drawing.Point(158, 98);
            this.StartWatcher.Name = "StartWatcher";
            this.StartWatcher.Size = new System.Drawing.Size(104, 29);
            this.StartWatcher.TabIndex = 3;
            this.StartWatcher.Text = "Start";
            this.StartWatcher.UseVisualStyleBackColor = true;
            this.StartWatcher.Click += new System.EventHandler(this.Start_Click);
            // 
            // StopWatcher
            // 
            this.StopWatcher.Location = new System.Drawing.Point(268, 98);
            this.StopWatcher.Name = "StopWatcher";
            this.StopWatcher.Size = new System.Drawing.Size(102, 29);
            this.StopWatcher.TabIndex = 4;
            this.StopWatcher.Text = "Stop";
            this.StopWatcher.UseVisualStyleBackColor = true;
            this.StopWatcher.Click += new System.EventHandler(this.Stop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "*.*",
            "*.txt",
            "*.exe",
            "*.cs",
            "*.asm",
            "*.docx"});
            this.comboBox1.Location = new System.Drawing.Point(15, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ExtFilter
            // 
            this.ExtFilter.AutoSize = true;
            this.ExtFilter.Location = new System.Drawing.Point(12, 48);
            this.ExtFilter.Name = "ExtFilter";
            this.ExtFilter.Size = new System.Drawing.Size(104, 17);
            this.ExtFilter.TabIndex = 3;
            this.ExtFilter.Text = "Extension Filter";
            this.ExtFilter.Click += new System.EventHandler(this.label1_Click);
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Location = new System.Drawing.Point(158, 70);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(212, 22);
            this.DirectoryTextBox.TabIndex = 2;
            this.DirectoryTextBox.TextChanged += new System.EventHandler(this.DirectoryTextBox_TextChanged);
            // 
            // Directory
            // 
            this.Directory.AutoSize = true;
            this.Directory.Location = new System.Drawing.Point(158, 50);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(65, 17);
            this.Directory.TabIndex = 5;
            this.Directory.Text = "Directory";
            this.Directory.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 209);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(362, 304);
            this.textBox1.TabIndex = 6;
            // 
            // DataWrite
            // 
            this.DataWrite.Location = new System.Drawing.Point(161, 172);
            this.DataWrite.Name = "DataWrite";
            this.DataWrite.Size = new System.Drawing.Size(139, 29);
            this.DataWrite.TabIndex = 7;
            this.DataWrite.Text = "Write To Database";
            this.DataWrite.UseVisualStyleBackColor = true;
            this.DataWrite.Click += new System.EventHandler(this.WriteToDatabase);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(306, 172);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(57, 29);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Location = new System.Drawing.Point(12, 110);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(89, 17);
            this.QueryLabel.TabIndex = 14;
            this.QueryLabel.Text = "Query by Ext";
            this.QueryLabel.Click += new System.EventHandler(this.QueryLabel_Click);
            // 
            // MainFormQuery
            // 
            this.MainFormQuery.Location = new System.Drawing.Point(12, 172);
            this.MainFormQuery.Name = "MainFormQuery";
            this.MainFormQuery.Size = new System.Drawing.Size(124, 30);
            this.MainFormQuery.TabIndex = 6;
            this.MainFormQuery.Text = "Query";
            this.MainFormQuery.UseVisualStyleBackColor = true;
            this.MainFormQuery.Click += new System.EventHandler(this.Query_Click);
            // 
            // QueryCombo
            // 
            this.QueryCombo.FormattingEnabled = true;
            this.QueryCombo.Items.AddRange(new object[] {
            ".*",
            ".txt",
            ".exe",
            ".cs",
            ".asm",
            ".docx"});
            this.QueryCombo.Location = new System.Drawing.Point(12, 130);
            this.QueryCombo.Name = "QueryCombo";
            this.QueryCombo.Size = new System.Drawing.Size(124, 24);
            this.QueryCombo.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHelp,
            this.toolGo,
            this.toolStop,
            this.toolQ});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(386, 27);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolHelp
            // 
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(41, 24);
            this.toolHelp.Text = "Help";
            this.toolHelp.Click += new System.EventHandler(this.ToolHelp_Click);
            // 
            // toolGo
            // 
            this.toolGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGo.Image = ((System.Drawing.Image)(resources.GetObject("toolGo.Image")));
            this.toolGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGo.Name = "toolGo";
            this.toolGo.Size = new System.Drawing.Size(24, 24);
            this.toolGo.Text = "toolStripButton1";
            this.toolGo.Click += new System.EventHandler(this.Start_Click);
            // 
            // toolStop
            // 
            this.toolStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStop.Image")));
            this.toolStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStop.Name = "toolStop";
            this.toolStop.Size = new System.Drawing.Size(24, 24);
            this.toolStop.Text = "toolStripButton1";
            this.toolStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // toolQ
            // 
            this.toolQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolQ.Image = ((System.Drawing.Image)(resources.GetObject("toolQ.Image")));
            this.toolQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolQ.Name = "toolQ";
            this.toolQ.Size = new System.Drawing.Size(24, 24);
            this.toolQ.Text = "toolStripButton1";
            this.toolQ.Click += new System.EventHandler(this.ToolQ_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 525);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.MainFormQuery);
            this.Controls.Add(this.DataWrite);
            this.Controls.Add(this.QueryCombo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.ExtFilter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.StopWatcher);
            this.Controls.Add(this.StartWatcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "FileSystemWatcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartWatcher;
        private System.Windows.Forms.Button StopWatcher;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ExtFilter;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Label Directory;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DataWrite;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.Button MainFormQuery;
        private System.Windows.Forms.ComboBox QueryCombo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolHelp;
        private System.Windows.Forms.ToolStripButton toolGo;
        private System.Windows.Forms.ToolStripButton toolStop;
        private System.Windows.Forms.ToolStripButton toolQ;
    }
}

