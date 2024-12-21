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
            AddBtn = new Button();
            LaunchBtn = new Button();
            LoadOdd = new CheckBox();
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
            groupBox1.Controls.Add(RemoveBtn);
            groupBox1.Controls.Add(AddBtn);
            groupBox1.Controls.Add(GameList);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "游戏版本选择";
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(178, 378);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(172, 42);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "删除游戏版本";
            RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(6, 378);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(173, 42);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "添加游戏版本";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // LaunchBtn
            // 
            LaunchBtn.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LaunchBtn.Location = new Point(12, 444);
            LaunchBtn.Name = "LaunchBtn";
            LaunchBtn.RightToLeft = RightToLeft.No;
            LaunchBtn.Size = new Size(253, 90);
            LaunchBtn.TabIndex = 2;
            LaunchBtn.Text = "启动!";
            LaunchBtn.UseVisualStyleBackColor = true;
            LaunchBtn.Click += LaunchBtn_Click;
            // 
            // LoadOdd
            // 
            LoadOdd.AutoSize = true;
            LoadOdd.Location = new Point(271, 487);
            LoadOdd.Name = "LoadOdd";
            LoadOdd.Size = new Size(91, 24);
            LoadOdd.TabIndex = 3;
            LoadOdd.Text = "加载odd";
            LoadOdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 547);
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
        private Button AddBtn;
    }
}
