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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GameList = new ListBox();
            groupBox1 = new ReaLTaiizor.Controls.CrownGroupBox();
            RemoveBtn = new ReaLTaiizor.Controls.CrownButton();
            AddGameBtn = new ReaLTaiizor.Controls.CrownButton();
            LaunchBtn = new ReaLTaiizor.Controls.CrownButton();
            LoadOdd = new ReaLTaiizor.Controls.CrownCheckBox();
            LoadMod = new ReaLTaiizor.Controls.CrownCheckBox();
            LoadAMDaemon = new ReaLTaiizor.Controls.CrownCheckBox();
            IsOldVersion = new ReaLTaiizor.Controls.CrownCheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GameList
            // 
            GameList.BackColor = Color.FromArgb(60, 63, 65);
            GameList.BorderStyle = BorderStyle.None;
            GameList.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            GameList.ForeColor = SystemColors.Menu;
            GameList.FormattingEnabled = true;
            GameList.ImeMode = ImeMode.NoControl;
            GameList.ItemHeight = 21;
            GameList.Location = new Point(6, 19);
            GameList.Margin = new Padding(2, 3, 2, 3);
            GameList.Name = "GameList";
            GameList.Size = new Size(289, 294);
            GameList.TabIndex = 0;
            GameList.SelectedIndexChanged += GameList_SelectedIndexChanged;
            GameList.DoubleClick += GameList_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.BorderColor = Color.FromArgb(51, 51, 51);
            groupBox1.Controls.Add(GameList);
            groupBox1.Location = new Point(5, 12);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(298, 319);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Version Select";
            // 
            // RemoveBtn
            // 
            RemoveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveBtn.Location = new Point(218, 337);
            RemoveBtn.Margin = new Padding(2, 3, 2, 3);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Padding = new Padding(4);
            RemoveBtn.Size = new Size(85, 36);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "Reload";
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AddGameBtn
            // 
            AddGameBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddGameBtn.Location = new Point(5, 337);
            AddGameBtn.Margin = new Padding(2, 3, 2, 3);
            AddGameBtn.Name = "AddGameBtn";
            AddGameBtn.Padding = new Padding(4);
            AddGameBtn.Size = new Size(85, 36);
            AddGameBtn.TabIndex = 1;
            AddGameBtn.Text = "Import...";
            AddGameBtn.Click += AddGameBtn_Click;
            // 
            // LaunchBtn
            // 
            LaunchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LaunchBtn.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LaunchBtn.Location = new Point(94, 337);
            LaunchBtn.Margin = new Padding(2, 3, 2, 3);
            LaunchBtn.Name = "LaunchBtn";
            LaunchBtn.Padding = new Padding(4);
            LaunchBtn.RightToLeft = RightToLeft.No;
            LaunchBtn.Size = new Size(120, 36);
            LaunchBtn.TabIndex = 2;
            LaunchBtn.Text = "Start!";
            LaunchBtn.Click += LaunchBtn_Click;
            // 
            // LoadOdd
            // 
            LoadOdd.AutoSize = true;
            LoadOdd.Location = new Point(11, 376);
            LoadOdd.Margin = new Padding(0);
            LoadOdd.Name = "LoadOdd";
            LoadOdd.Size = new Size(105, 21);
            LoadOdd.TabIndex = 3;
            LoadOdd.Text = "Load odd.sys";
            LoadOdd.CheckedChanged += LoadOdd_CheckedChanged;
            // 
            // LoadMod
            // 
            LoadMod.AutoSize = true;
            LoadMod.Location = new Point(11, 397);
            LoadMod.Margin = new Padding(0);
            LoadMod.Name = "LoadMod";
            LoadMod.Size = new Size(88, 21);
            LoadMod.TabIndex = 4;
            LoadMod.Text = "Load Mod";
            LoadMod.CheckedChanged += LoadMod_CheckedChanged;
            // 
            // LoadAMDaemon
            // 
            LoadAMDaemon.AutoSize = true;
            LoadAMDaemon.Checked = true;
            LoadAMDaemon.CheckState = CheckState.Checked;
            LoadAMDaemon.Location = new Point(178, 376);
            LoadAMDaemon.Margin = new Padding(0);
            LoadAMDaemon.Name = "LoadAMDaemon";
            LoadAMDaemon.Size = new Size(129, 21);
            LoadAMDaemon.TabIndex = 5;
            LoadAMDaemon.Text = "Load AMDaemon";
            LoadAMDaemon.CheckedChanged += LoadAMDaemon_CheckedChanged;
            // 
            // IsOldVersion
            // 
            IsOldVersion.AutoSize = true;
            IsOldVersion.Location = new Point(178, 397);
            IsOldVersion.Margin = new Padding(0);
            IsOldVersion.Name = "IsOldVersion";
            IsOldVersion.Size = new Size(109, 21);
            IsOldVersion.TabIndex = 6;
            IsOldVersion.Text = "Version DX(+)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 422);
            Controls.Add(IsOldVersion);
            Controls.Add(AddGameBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(LoadAMDaemon);
            Controls.Add(LoadMod);
            Controls.Add(LoadOdd);
            Controls.Add(LaunchBtn);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "maimai DX Multiversion Launcher";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

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
    }
}
