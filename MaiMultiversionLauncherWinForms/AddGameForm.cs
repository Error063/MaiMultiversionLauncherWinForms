using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using VersionManager;

namespace MaiMultiversionLauncherWinForms
{
    public partial class AddGameForm : ReaLTaiizor.Forms.CrownForm
    {
        public AddGameForm()
        {
            InitializeComponent();
        }

        private void BrowseGameBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please Select The Game Folder";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var savePath = dialog.SelectedPath;
                FolderPath.Text = savePath;
            }
        }

        private void MergeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wait for implement");
        }
    }
}
