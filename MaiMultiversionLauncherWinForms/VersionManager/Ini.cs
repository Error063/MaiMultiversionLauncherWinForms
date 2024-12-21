using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiMultiversionLauncherWinForms.VersionManager
{
    internal class Ini(string path)
    {
        private string path;
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);


        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, path);
        }

        public string Read(string section, string key)
        {
            System.Text.StringBuilder temp = new System.Text.StringBuilder(255);

            GetPrivateProfileString(section, key, "", temp, 255, path);
            return temp.ToString();

        }
    }
}
