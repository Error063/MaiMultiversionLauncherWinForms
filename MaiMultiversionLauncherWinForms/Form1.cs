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
                MessageBox.Show("游戏版本列表为空！");
                return;
            }
            LaunchBtn.Enabled = false;
            LaunchBtn.Text = "启动中...";
            Task.Run(() =>
            {
                if (_launch.LaunchGame(version, LoadOdd.Checked)) ;
                Invoke(() =>
                {
                    LaunchBtn.Enabled = true;
                    LaunchBtn.Text = "启动!";
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
