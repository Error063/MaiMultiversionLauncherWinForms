namespace MaiMultiversionLauncherWinForms
{
    partial class AddGameForm
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
            radioButton1 = new ReaLTaiizor.Controls.CrownRadioButton();
            radioButton2 = new ReaLTaiizor.Controls.CrownRadioButton();
            radioButton3 = new ReaLTaiizor.Controls.CrownRadioButton();
            groupBox1 = new ReaLTaiizor.Controls.CrownGroupBox();
            label1 = new ReaLTaiizor.Controls.CrownLabel();
            domainUpDown1 = new DomainUpDown();
            label2 = new ReaLTaiizor.Controls.CrownLabel();
            FolderPath = new ReaLTaiizor.Controls.CrownTextBox();
            BrowseGameBtn = new ReaLTaiizor.Controls.CrownButton();
            MergeBtn = new ReaLTaiizor.Controls.CrownButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 21);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "SDEZ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(78, 21);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "SDGA";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(157, 21);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "SDGB";
            // 
            // groupBox1
            // 
            groupBox1.BorderColor = Color.FromArgb(51, 51, 51);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(domainUpDown1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(247, 85);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Branch and version";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(220, 220, 220);
            label1.Location = new Point(10, 49);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "Version: 1.";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(104, 46);
            domainUpDown1.Margin = new Padding(3, 4, 3, 4);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(129, 27);
            domainUpDown1.TabIndex = 3;
            domainUpDown1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(220, 220, 220);
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 4;
            label2.Text = "Game Path:";
            // 
            // FolderPath
            // 
            FolderPath.BackColor = Color.FromArgb(69, 73, 74);
            FolderPath.BorderStyle = BorderStyle.FixedSingle;
            FolderPath.ForeColor = Color.FromArgb(220, 220, 220);
            FolderPath.Location = new Point(12, 129);
            FolderPath.Margin = new Padding(3, 4, 3, 4);
            FolderPath.Name = "FolderPath";
            FolderPath.Size = new Size(248, 27);
            FolderPath.TabIndex = 5;
            // 
            // BrowseGameBtn
            // 
            BrowseGameBtn.Location = new Point(12, 162);
            BrowseGameBtn.Margin = new Padding(3, 4, 3, 4);
            BrowseGameBtn.Name = "BrowseGameBtn";
            BrowseGameBtn.Padding = new Padding(5, 5, 5, 5);
            BrowseGameBtn.Size = new Size(247, 34);
            BrowseGameBtn.TabIndex = 6;
            BrowseGameBtn.Text = "Browse Folder";
            BrowseGameBtn.Click += BrowseGameBtn_Click;
            // 
            // MergeBtn
            // 
            MergeBtn.Location = new Point(12, 239);
            MergeBtn.Margin = new Padding(3, 4, 3, 4);
            MergeBtn.Name = "MergeBtn";
            MergeBtn.Padding = new Padding(5, 5, 5, 5);
            MergeBtn.Size = new Size(247, 29);
            MergeBtn.TabIndex = 7;
            MergeBtn.Text = "Merge";
            MergeBtn.Click += MergeBtn_Click;
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 279);
            Controls.Add(MergeBtn);
            Controls.Add(BrowseGameBtn);
            Controls.Add(FolderPath);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddGameForm";
            Text = "Import...";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownRadioButton radioButton1;
        private ReaLTaiizor.Controls.CrownRadioButton radioButton2;
        private ReaLTaiizor.Controls.CrownRadioButton radioButton3;
        private ReaLTaiizor.Controls.CrownGroupBox groupBox1;
        private ReaLTaiizor.Controls.CrownLabel label1;
        private DomainUpDown domainUpDown1;
        private ReaLTaiizor.Controls.CrownLabel label2;
        private ReaLTaiizor.Controls.CrownTextBox FolderPath;
        private ReaLTaiizor.Controls.CrownButton BrowseGameBtn;
        private ReaLTaiizor.Controls.CrownButton MergeBtn;
    }
}