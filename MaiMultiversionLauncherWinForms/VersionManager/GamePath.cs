using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VersionManager
{
    internal class GamePath
    {
        private string _rootPath;
        private string _gamePath;
        private string _gameBasePath;
        private string _gameResPath;
        private string _segatoolsPath;
        private string _tempPath;
        private string _modPath;
        public GamePath(string RootPath)
        {
            if (!string.IsNullOrEmpty(RootPath) && Directory.Exists(RootPath))
            {
                _rootPath = RootPath;

                _gamePath = Path.Combine(_rootPath, "Games");
                _gameBasePath = Path.Combine(_rootPath, "Bases");
                _gameResPath = Path.Combine(_rootPath, "Resources");
                _segatoolsPath = Path.Combine(_rootPath, "Segatools");
                _tempPath = Path.Combine(_rootPath, "Temp");
                _modPath = Path.Combine(_rootPath, "Mod");

                if (!Directory.Exists(_gamePath))
                    Directory.CreateDirectory(_gamePath);
                if (!Directory.Exists(_gameBasePath))
                    Directory.CreateDirectory(_gameBasePath);
                if (!Directory.Exists(_gameResPath))
                    Directory.CreateDirectory(_gameResPath);
                if (!Directory.Exists(_segatoolsPath))
                    Directory.CreateDirectory(_segatoolsPath);
                if (!Directory.Exists(_modPath))
                    Directory.CreateDirectory(_modPath);

                if (Directory.Exists(_tempPath))
                    Directory.Delete(_tempPath, true);
                Directory.CreateDirectory(_tempPath);

            }
            else
                throw new Exception("RootPath is not valid.");
        }

        public string GetGamePath()
        {
            return _gamePath;
        }
        public string GetGameBasePath()
        {
            return _gameBasePath;
        }
        public string GetGameResPath()
        {
            return _gameResPath;
        }
        public string GetSegatoolsPath()
        {
            return _segatoolsPath;
        }
        public string GetTempPath(bool delete = false)
        {
            if (delete)
            {
                if (Directory.Exists(_tempPath))
                    Directory.Delete(_tempPath, true);
                Directory.CreateDirectory(_tempPath);
            }

            return _tempPath;
        }
        public string GetModPath()
        {
            return _modPath;
        }

        public static void CopyDirectory(string sourcePath, string destPath)
        {
            string folderName = Path.GetFileName(sourcePath);
            DirectoryInfo di = Directory.CreateDirectory(Path.Combine(destPath, folderName));
            string[] files = Directory.GetFileSystemEntries(sourcePath);

            Parallel.ForEach(files, file =>
            {
                if (Directory.Exists(file))
                {
                    CopyDirectory(file, di.FullName);
                }
                else
                {
                    File.Copy(file, Path.Combine(di.FullName, Path.GetFileName(file)), true);
                }
            });
        }


        public static void CreateSymbolicLink(string path, string pathToTarget)
        {
            var files = Directory.GetFiles(pathToTarget, "*", SearchOption.AllDirectories);

            Parallel.ForEach(files, file =>
            {
                var relativePath = Path.GetRelativePath(pathToTarget, file);
                var linkPath = Path.Combine(path, relativePath);
                Directory.CreateDirectory(Path.GetDirectoryName(linkPath));

                if (File.Exists(linkPath))
                {
                    File.Delete(linkPath);
                }

                File.CreateSymbolicLink(linkPath, file);
            });
        }

    }
}
