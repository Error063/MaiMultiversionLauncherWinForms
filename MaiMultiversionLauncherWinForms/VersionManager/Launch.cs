using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaiMultiversionLauncherWinForms.VersionManager;

namespace VersionManager
{
    internal class Launch(string RootPath)
    {
        private GamePath _gamePath = new GamePath(RootPath);

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);


        public List<string> GetExistVersionList()
        {
            List<string> versions = new List<string>();
            foreach (var item in Directory.GetDirectories(_gamePath.GetGamePath()))
            {
                if (Directory.Exists(Path.Combine(item, "AMDaemon")) && Directory.Exists(Path.Combine(item, "Resources")))
                    versions.Add(Path.GetFileName(item));
            }
            return versions;
        }

        public bool LaunchGame(string version, bool isEncrypted)
        {
            KillAll();
            var gameResPath = Path.Combine(_gamePath.GetGamePath(), version, "Resources") + "/";
            var resPath = _gamePath.GetGameResPath();
            var tempPath = _gamePath.GetTempPath(true);
            var gameBasePath = Path.Combine(_gamePath.GetGameBasePath(), isEncrypted ? "Encrypted" : "Decrypted") + "/";

            StartAMDaemon(version);

            GamePath.CreateSymbolicLink(tempPath, gameBasePath);
            GamePath.CreateSymbolicLink(tempPath, gameResPath);
            GamePath.CreateSymbolicLink(Path.Combine(tempPath, "Sinmai_Data", "StreamingAssets", "A000"), Path.Combine(resPath, "A888"));

            StartSinmai(tempPath);
            return true;
        }

        public void StartAMDaemon(string version)
        {
            new Thread(() =>
            {
                var segatoolsPath = _gamePath.GetSegatoolsPath();
                var gameAmdPath = Path.Combine(_gamePath.GetGamePath(), version, "AMDaemon");

                File.WriteAllText(Path.Combine(segatoolsPath, "segatools.ini"), File.ReadAllText(Path.Combine(segatoolsPath, "segatools.template.ini"))
                    .Replace("##THE_AMFS_PATH##", Path.Combine(gameAmdPath, "amfs"))
                    .Replace("##THE_OPTION_PATH##", Path.Combine(gameAmdPath, "option"))
                    .Replace("##THE_APPDATA_PATH##", Path.Combine(gameAmdPath, "appdata")));

                ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe")
                {
                    WorkingDirectory = segatoolsPath,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput=true
                };

                Process p = new Process();
                p.StartInfo = startInfo;
                p.Start();
                p.StandardInput.WriteLine("taskkill /f /im amdaemon.exe > nul 2>&1");
                p.StandardInput.WriteLine(
                    $"start {segatoolsPath}\\inject -d -k {segatoolsPath}\\mai2hook.dll {gameAmdPath}\\amdaemon.exe -f -c {segatoolsPath}\\config_common.json {segatoolsPath}\\config_server.json {segatoolsPath}\\config_client.json");
                // p.WaitForExit();
            }).Start();

        }

        public static void StartSinmai(string command)
        {
            new Thread(() =>
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", $"/c {command}//Sinmai.exe")
                {
                    WorkingDirectory = command,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                StringBuilder output = new StringBuilder();
                StringBuilder error = new StringBuilder();

                using (Process process = new Process())
                {
                    process.StartInfo = processStartInfo;

                    process.Start();
                    process.WaitForExit();

                }
            }).Start();
        }

        public static void KillAll()
        {
            new Thread(() =>
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true
                };

                Process p = new Process();
                p.StartInfo = startInfo;
                p.Start();
                p.StandardInput.WriteLine("taskkill /f /im Sinmai.exe > nul 2>&1");
                p.StandardInput.WriteLine("taskkill /f /im amdaemon.exe > nul 2>&1");
                // p.WaitForExit();
            }).Start();
        }
    }
}
