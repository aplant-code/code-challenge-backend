using System;
using System.IO;
using System.Text;

namespace dotnet_code_challenge.FileReader
{
    public static class RaceFileReader
    {
        public static string ReadFile(string path)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));
            return File.ReadAllText(Path.Combine(basePath, path), Encoding.Default);
        }
    }
}