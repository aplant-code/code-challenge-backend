using System;
using System.IO;
using System.Text;

namespace dotnet_code_challenge.FileReader
{
    public class FileReader
    {
        public string ReadFile(string path)
        {
            return File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin")), path), Encoding.Default);
        }
    }
}