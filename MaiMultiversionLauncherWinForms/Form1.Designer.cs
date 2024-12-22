namespace MaiMultiversionLauncherWinForms
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            RemoveBtn = new Button();
            AddGameBtn = new Button();
            LaunchBtn = new Button();
            LoadOdd = new CheckBox();
            LoadMod = new CheckBox();
            LoadAMDaemon = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GameList
            // 
            GameList.FormattingEnabled = true;
            GameList.Location = new Point(6, 26);
            GameList.Name = "GameList";
            GameList.Size = new Size(344, 344);
            GameList.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GameList);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 375);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "游戏版本选择";
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(110, 393);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(52, 42);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "刷新";
            RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // AddGameBtn
            // 
            AddGameBtn.Location = new Point(12, 393);
            AddGameBtn.Name = "AddGameBtn";
            AddGameBtn.Size = new Size(92, 42);
            AddGameBtn.TabIndex = 1;
            AddGameBtn.Text = "导入游戏";
            AddGameBtn.UseVisualStyleBackColor = true;
            // 
            // LaunchBtn
            // 
            LaunchBtn.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LaunchBtn.Location = new Point(12, 444);
            LaunchBtn.Name = "LaunchBtn";
            LaunchBtn.RightToLeft = RightToLeft.No;
            LaunchBtn.Size = new Size(179, 90);
            LaunchBtn.TabIndex = 2;
            LaunchBtn.Text = "启动!";
            LaunchBtn.UseVisualStyleBackColor = true;
            LaunchBtn.Click += LaunchBtn_Click;
            // 
            // LoadOdd
            // 
            LoadOdd.AutoSize = true;
            LoadOdd.Location = new Point(197, 511);
            LoadOdd.Name = "LoadOdd";
            LoadOdd.Size = new Size(91, 24);
            LoadOdd.TabIndex = 3;
            LoadOdd.Text = "加载odd";
            LoadOdd.UseVisualStyleBackColor = true;
            // 
            // LoadMod
            // 
            LoadMod.AutoSize = true;
            LoadMod.Location = new Point(197, 480);
            LoadMod.Name = "LoadMod";
            LoadMod.Size = new Size(96, 24);
            LoadMod.TabIndex = 4;
            LoadMod.Text = "加载Mod";
            LoadMod.UseVisualStyleBackColor = true;
            // 
            // LoadAMDaemon
            // 
            LoadAMDaemon.AutoSize = true;
            LoadAMDaemon.Checked = true;
            LoadAMDaemon.CheckState = CheckState.Checked;
            LoadAMDaemon.Location = new Point(197, 450);
            LoadAMDaemon.Name = "LoadAMDaemon";
            LoadAMDaemon.Size = new Size(148, 24);
            LoadAMDaemon.TabIndex = 5;
            LoadAMDaemon.Text = "加载AMDaemon";
            LoadAMDaemon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 547);
            Controls.Add(AddGameBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(LoadAMDaemon);
            Controls.Add(LoadMod);
            Controls.Add(LoadOdd);
            Controls.Add(LaunchBtn);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox GameList;
        private GroupBox groupBox1;
        private Button LaunchBtn;
        private CheckBox LoadOdd;
        private Button RemoveBtn;
        private Button AddGameBtn;
        private CheckBox LoadMod;
        private CheckBox LoadAMDaemon;
    }
}
