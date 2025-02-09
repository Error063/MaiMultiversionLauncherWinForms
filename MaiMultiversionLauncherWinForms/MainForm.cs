using System;
using System.Diagnostics;
using VersionManager;

namespace MaiMultiversionLauncherWinForms
{
    public partial class MainForm : ReaLTaiizor.Forms.CrownForm
    {
        private Launch _launch = null;
        private Config _config = new("config.yaml");
        private AddGameForm _addGameForm = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchAllControls(false);
            if (string.IsNullOrEmpty(_config.config.settings.GamePath))
            {
                MessageBox.Show("Please Select The Game Folder First!");
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Please Select The Game Folder";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var cfg = _config.config;
                    cfg.settings.GamePath = dialog.SelectedPath;
                    _config.config = cfg;
                    _config.Save(_config.config);
                }
            }
            LoadOdd.Checked = _config.config.settings.LoadOdd;
            LoadMod.Checked = _config.config.settings.LoadMod;
            LoadAMDaemon.Checked = _config.config.settings.LoadAmDaemon;
            Task.Run(() =>
            {
                _launch = new Launch(_config);
                ReportStatus();
                Invoke(() => RemoveBtn_Click(sender, e));
            });
        }
        
        public void ReportStatus(string status="Ready") => Invoke(() => StatusReport.Text = $"Status: {status}");

        private void LaunchBtn_Click(object sender, EventArgs e)
        {
            if (_launch == null)
            {
                MessageBox.Show("Program was not initialized all data successfully!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var version = GameList.SelectedItem?.ToString();

            if (GameList.Items.Count <= 0 || string.IsNullOrEmpty(version))
            {
                LaunchBtn.Enabled = false;
                MessageBox.Show("Empty Game List£¡");
                return;
            }
            LaunchBtn.Enabled = false;
            ReportStatus("Starting game...");
            SwitchAllControls(false);
            Task.Run(() =>
            {
                if (_launch.LaunchGame(version, LoadOdd.Checked, LoadMod.Checked, LoadAMDaemon.Checked, IsOldVersion.Checked))
                    Invoke(() =>
                    {
                        LaunchBtn.Enabled = true;
                        ReportStatus();
                        SwitchAllControls(true);
                    });
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
        private void SwitchAllControls(bool enabled)
        {
            Invoke(() => SetControlsEnabled(this, enabled));
        }

        private void SetControlsEnabled(Control parent, bool enabled)
        {
            foreach (Control control in parent.Controls)
            {
                control.Enabled = enabled;
                if (control.HasChildren) SetControlsEnabled(control, enabled);
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (_launch == null)
            {
                MessageBox.Show("Program was not initialized all data successfully!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Task.Run(() =>
            {
                SwitchAllControls(false);
                Invoke(() =>
                {
                    GameList.Items.Clear();
                });
                foreach (var game in _launch.GetExistVersionList())
                {
                    Invoke(() =>
                    {
                        GameList.Items.Add(game);
                    });
                }
                Invoke(() =>
                {
                    if (GameList.Items.Count > 0)
                    {
                        SwitchAllControls(true);
                        GameList.SelectedIndex = 0;
                    }
                    else LaunchBtn.Enabled = false;
                });
            });
        }

        private void GameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var subVersion = Convert.ToInt32(GameList.SelectedItem?.ToString().Split("_")[1].Split(".")[1]);
                if (subVersion < 10)
                {
                    IsOldVersion.Checked = true;
                    IsOldVersion.Enabled = false;
                }
                else
                {
                    IsOldVersion.Checked = false;
                    IsOldVersion.Enabled = false;
                }
            }
            catch (Exception)
            {
                IsOldVersion.Checked = false;
                IsOldVersion.Enabled = true;
            }
        }

        private void AddGameBtn_Click(object sender, EventArgs e) => _addGameForm.ShowDialog();

        private void GameList_DoubleClick(object sender, EventArgs e)
        {
            if (LaunchBtn.Enabled) LaunchBtn_Click(sender, e);
        }

        private void LoadOdd_CheckedChanged(object sender, EventArgs e)
        {
            var cfg = _config.config;
            cfg.settings.LoadOdd = LoadOdd.Checked;
            _config.config = cfg;
            _config.Save(_config.config);
        }

        private void LoadMod_CheckedChanged(object sender, EventArgs e)
        {
            var cfg = _config.config;
            cfg.settings.LoadMod = LoadMod.Checked;
            _config.config = cfg;
            _config.Save(_config.config);
        }

        private void LoadAMDaemon_CheckedChanged(object sender, EventArgs e)
        {
            var cfg = _config.config;
            cfg.settings.LoadAmDaemon = LoadAMDaemon.Checked;
            _config.config = cfg;
            _config.Save(_config.config);
        }

        private void RenderFileTreeBtn_Click(object sender, EventArgs e)
        {
            var version = GameList.SelectedItem?.ToString();

            if (GameList.Items.Count <= 0 || string.IsNullOrEmpty(version))
            {
                RenderFileTreeBtn.Enabled = false;
                MessageBox.Show("Empty Game List£¡");
                return;
            }
            ReportStatus("Rendering temporary game folder...");
            SwitchAllControls(false);
            Task.Run(() =>
            {
                Process.Start("explorer", _launch.RenderGameFileTree(version, LoadOdd.Checked, LoadMod.Checked, IsOldVersion.Checked));
                Invoke(() =>
                {
                    ReportStatus();
                    SwitchAllControls(true);
                });
            });

        }

        private void CleanTempBtn_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (_launch == null)
                {
                    Invoke(() => MessageBox.Show("Program was not initialized all data successfully!", "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning));
                    return;
                }
                ReportStatus("Removing temporary folder...");
                SwitchAllControls(false);
                _launch.CleanTemp();
                Invoke(() =>
                {
                    MessageBox.Show("Temp Folder Was Cleaned", "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ReportStatus();
                    SwitchAllControls(true);
                });
            });
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void KillAllBtn_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (_launch == null)
                {
                    Invoke(() => MessageBox.Show("Program was not initialized all data successfully!", "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning));
                    return;
                }

                ReportStatus("Killing all process...");
                SwitchAllControls(false);
                Launch.KillAll();
                ReportStatus();
                SwitchAllControls(true);
            });
        }
    }
}
