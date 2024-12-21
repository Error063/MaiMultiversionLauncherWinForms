using VersionManager;

namespace MaiMultiversionLauncherWinForms
{
    public partial class Form1 : Form
    {
        private Launch _launch = new Launch("D:\\maimai");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var game in _launch.GetExistVersionList())
            {
                GameList.Items.Add(game);
            }
            if (GameList.Items.Count > 0) GameList.SelectedIndex = 0;
        }

        private void LaunchBtn_Click(object sender, EventArgs e)
        {
            var version = GameList.SelectedItem?.ToString();

            if (GameList.Items.Count <= 0 || string.IsNullOrEmpty(version))
            {
                MessageBox.Show("��Ϸ�汾�б�Ϊ�գ�");
                return;
            }
            LaunchBtn.Enabled = false;
            LaunchBtn.Text = "������...";
            Task.Run(() =>
            {
                if (_launch.LaunchGame(version, LoadOdd.Checked)) ;
                Invoke(() =>
                {
                    LaunchBtn.Enabled = true;
                    LaunchBtn.Text = "����!";
                });
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Launch.KillAll();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
