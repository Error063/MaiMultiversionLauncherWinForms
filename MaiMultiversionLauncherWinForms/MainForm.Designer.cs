namespace MaiMultiversionLauncherWinForms
{
    partial class MainForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GameList = new System.Windows.Forms.ListBox();
            groupBox1 = new ReaLTaiizor.Controls.CrownGroupBox();
            RemoveBtn = new ReaLTaiizor.Controls.CrownButton();
            AddGameBtn = new ReaLTaiizor.Controls.CrownButton();
            LaunchBtn = new ReaLTaiizor.Controls.CrownButton();
            LoadOdd = new ReaLTaiizor.Controls.CrownCheckBox();
            LoadMod = new ReaLTaiizor.Controls.CrownCheckBox();
            LoadAMDaemon = new ReaLTaiizor.Controls.CrownCheckBox();
            IsOldVersion = new ReaLTaiizor.Controls.CrownCheckBox();
            crownGroupBox1 = new ReaLTaiizor.Controls.CrownGroupBox();
            CleanTempBtn = new ReaLTaiizor.Controls.CrownButton();
            RenderFileTreeBtn = new ReaLTaiizor.Controls.CrownButton();
            crownStatusStrip1 = new ReaLTaiizor.Controls.CrownStatusStrip();
            StatusReport = new System.Windows.Forms.ToolStripStatusLabel();
            KillAllBtn = new ReaLTaiizor.Controls.CrownButton();
            groupBox1.SuspendLayout();
            crownGroupBox1.SuspendLayout();
            crownStatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GameList
            // 
            GameList.BackColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)63)), ((int)((byte)65)));
            GameList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            GameList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)134));
            GameList.ForeColor = System.Drawing.SystemColors.Menu;
            GameList.FormattingEnabled = true;
            GameList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            GameList.ItemHeight = 27;
            GameList.Location = new System.Drawing.Point(8, 22);
            GameList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GameList.Name = "GameList";
            GameList.Size = new System.Drawing.Size(372, 324);
            GameList.TabIndex = 0;
            GameList.SelectedIndexChanged += GameList_SelectedIndexChanged;
            GameList.DoubleClick += GameList_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)51)), ((int)((byte)51)));
            groupBox1.Controls.Add(GameList);
            groupBox1.Location = new System.Drawing.Point(6, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(383, 375);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Version Select";
            // 
            // RemoveBtn
            // 
            RemoveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            RemoveBtn.Location = new System.Drawing.Point(280, 396);
            RemoveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Padding = new System.Windows.Forms.Padding(5);
            RemoveBtn.Size = new System.Drawing.Size(109, 42);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "Reload";
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AddGameBtn
            // 
            AddGameBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            AddGameBtn.Location = new System.Drawing.Point(6, 396);
            AddGameBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddGameBtn.Name = "AddGameBtn";
            AddGameBtn.Padding = new System.Windows.Forms.Padding(5);
            AddGameBtn.Size = new System.Drawing.Size(109, 42);
            AddGameBtn.TabIndex = 1;
            AddGameBtn.Text = "Import...";
            AddGameBtn.Click += AddGameBtn_Click;
            // 
            // LaunchBtn
            // 
            LaunchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            LaunchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)134));
            LaunchBtn.Location = new System.Drawing.Point(121, 396);
            LaunchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            LaunchBtn.Name = "LaunchBtn";
            LaunchBtn.Padding = new System.Windows.Forms.Padding(5);
            LaunchBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            LaunchBtn.Size = new System.Drawing.Size(154, 42);
            LaunchBtn.TabIndex = 2;
            LaunchBtn.Text = "Start!";
            LaunchBtn.Click += LaunchBtn_Click;
            // 
            // LoadOdd
            // 
            LoadOdd.AutoSize = true;
            LoadOdd.Enabled = false;
            LoadOdd.Location = new System.Drawing.Point(14, 442);
            LoadOdd.Margin = new System.Windows.Forms.Padding(0);
            LoadOdd.Name = "LoadOdd";
            LoadOdd.Size = new System.Drawing.Size(127, 24);
            LoadOdd.TabIndex = 3;
            LoadOdd.Text = "Load odd.sys";
            LoadOdd.CheckedChanged += LoadOdd_CheckedChanged;
            // 
            // LoadMod
            // 
            LoadMod.AutoSize = true;
            LoadMod.Enabled = false;
            LoadMod.Location = new System.Drawing.Point(14, 467);
            LoadMod.Margin = new System.Windows.Forms.Padding(0);
            LoadMod.Name = "LoadMod";
            LoadMod.Size = new System.Drawing.Size(106, 24);
            LoadMod.TabIndex = 4;
            LoadMod.Text = "Load Mod";
            LoadMod.CheckedChanged += LoadMod_CheckedChanged;
            // 
            // LoadAMDaemon
            // 
            LoadAMDaemon.AutoSize = true;
            LoadAMDaemon.Checked = true;
            LoadAMDaemon.CheckState = System.Windows.Forms.CheckState.Checked;
            LoadAMDaemon.Enabled = false;
            LoadAMDaemon.Location = new System.Drawing.Point(229, 442);
            LoadAMDaemon.Margin = new System.Windows.Forms.Padding(0);
            LoadAMDaemon.Name = "LoadAMDaemon";
            LoadAMDaemon.Size = new System.Drawing.Size(158, 24);
            LoadAMDaemon.TabIndex = 5;
            LoadAMDaemon.Text = "Load AMDaemon";
            LoadAMDaemon.CheckedChanged += LoadAMDaemon_CheckedChanged;
            // 
            // IsOldVersion
            // 
            IsOldVersion.AutoSize = true;
            IsOldVersion.Enabled = false;
            IsOldVersion.Location = new System.Drawing.Point(229, 467);
            IsOldVersion.Margin = new System.Windows.Forms.Padding(0);
            IsOldVersion.Name = "IsOldVersion";
            IsOldVersion.Size = new System.Drawing.Size(132, 24);
            IsOldVersion.TabIndex = 6;
            IsOldVersion.Text = "Version DX(+)";
            // 
            // crownGroupBox1
            // 
            crownGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)51)), ((int)((byte)51)));
            crownGroupBox1.Controls.Add(KillAllBtn);
            crownGroupBox1.Controls.Add(CleanTempBtn);
            crownGroupBox1.Controls.Add(RenderFileTreeBtn);
            crownGroupBox1.Location = new System.Drawing.Point(409, 14);
            crownGroupBox1.Name = "crownGroupBox1";
            crownGroupBox1.Size = new System.Drawing.Size(152, 477);
            crownGroupBox1.TabIndex = 7;
            crownGroupBox1.TabStop = false;
            crownGroupBox1.Text = "Advance";
            // 
            // CleanTempBtn
            // 
            CleanTempBtn.Location = new System.Drawing.Point(6, 26);
            CleanTempBtn.Name = "CleanTempBtn";
            CleanTempBtn.Padding = new System.Windows.Forms.Padding(5);
            CleanTempBtn.Size = new System.Drawing.Size(140, 32);
            CleanTempBtn.TabIndex = 1;
            CleanTempBtn.Text = "Clean Temp";
            CleanTempBtn.Click += CleanTempBtn_Click;
            // 
            // RenderFileTreeBtn
            // 
            RenderFileTreeBtn.Location = new System.Drawing.Point(6, 438);
            RenderFileTreeBtn.Name = "RenderFileTreeBtn";
            RenderFileTreeBtn.Padding = new System.Windows.Forms.Padding(5);
            RenderFileTreeBtn.Size = new System.Drawing.Size(140, 32);
            RenderFileTreeBtn.TabIndex = 0;
            RenderFileTreeBtn.Text = "Render File Tree";
            RenderFileTreeBtn.Click += RenderFileTreeBtn_Click;
            // 
            // crownStatusStrip1
            // 
            crownStatusStrip1.AutoSize = false;
            crownStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)63)), ((int)((byte)65)));
            crownStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)220)), ((int)((byte)220)));
            crownStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            crownStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { StatusReport });
            crownStatusStrip1.Location = new System.Drawing.Point(0, 501);
            crownStatusStrip1.Name = "crownStatusStrip1";
            crownStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            crownStatusStrip1.Size = new System.Drawing.Size(573, 38);
            crownStatusStrip1.SizingGrip = false;
            crownStatusStrip1.TabIndex = 8;
            crownStatusStrip1.Text = "crownStatusStrip1";
            // 
            // StatusReport
            // 
            StatusReport.Name = "StatusReport";
            StatusReport.Size = new System.Drawing.Size(135, 24);
            StatusReport.Text = "Status: Initializing";
            // 
            // KillAllBtn
            // 
            KillAllBtn.Location = new System.Drawing.Point(6, 64);
            KillAllBtn.Name = "KillAllBtn";
            KillAllBtn.Padding = new System.Windows.Forms.Padding(5);
            KillAllBtn.Size = new System.Drawing.Size(140, 32);
            KillAllBtn.TabIndex = 2;
            KillAllBtn.Text = "Kill All";
            KillAllBtn.Click += KillAllBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(573, 539);
            Controls.Add(crownStatusStrip1);
            Controls.Add(crownGroupBox1);
            Controls.Add(IsOldVersion);
            Controls.Add(AddGameBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(LoadAMDaemon);
            Controls.Add(LoadMod);
            Controls.Add(LoadOdd);
            Controls.Add(LaunchBtn);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            ShowIcon = false;
            Text = "maimai DX Multiversion Launcher";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            crownGroupBox1.ResumeLayout(false);
            crownStatusStrip1.ResumeLayout(false);
            crownStatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ReaLTaiizor.Controls.CrownButton KillAllBtn;

        #endregion

        private ListBox GameList;
        private ReaLTaiizor.Controls.CrownGroupBox groupBox1;
        private ReaLTaiizor.Controls.CrownButton LaunchBtn;
        private ReaLTaiizor.Controls.CrownCheckBox LoadOdd;
        private ReaLTaiizor.Controls.CrownButton RemoveBtn;
        private ReaLTaiizor.Controls.CrownButton AddGameBtn;
        private ReaLTaiizor.Controls.CrownCheckBox LoadMod;
        private ReaLTaiizor.Controls.CrownCheckBox LoadAMDaemon;
        private ReaLTaiizor.Controls.CrownCheckBox IsOldVersion;
        private ReaLTaiizor.Controls.CrownGroupBox crownGroupBox1;
        private ReaLTaiizor.Controls.CrownButton RenderFileTreeBtn;
        private ReaLTaiizor.Controls.CrownButton CleanTempBtn;
        private ReaLTaiizor.Controls.CrownStatusStrip crownStatusStrip1;
        private ToolStripStatusLabel StatusReport;
    }
}
