using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Retro_CMS.Infrastructure.Assemblies
{
    public static class AssemblyRegister
    {
        private static string ThemeMap
        {
            get { return Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Themes"); }
        }

        private static string BinMap
        {
            get { return Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Bin"); }
        }

        public static void RegisterThemeDlls()
        {
            foreach (var themeDll in GetThemeDlls())
            {
                string fileName = Path.GetFileName(themeDll);
                string binFilePath = string.Format("{0}/{1}", BinMap, fileName);

                // If the dll doesn't exist yet or if the theme id is newer
                if (!FileExists(binFilePath) || GetFileEditedDate(themeDll) > GetFileEditedDate(binFilePath))
                {
                    File.Copy(themeDll, binFilePath, true);
                }
            }
        }

        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public static DateTime GetFileEditedDate(string filePath)
        {
            return File.GetLastWriteTime(filePath);
        }

        private static IEnumerable<string> GetThemeDlls()
        {
            const string themeName = "Default";
            string themePath = Path.Combine(ThemeMap, themeName, "bin");

            return Directory.GetFiles(themePath, "*.dll", SearchOption.AllDirectories);
        }
    }
}