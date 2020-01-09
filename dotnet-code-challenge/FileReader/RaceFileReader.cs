using System;
using System.IO;
using System.Text;

namespace dotnet_code_challenge.FileReader
{
    public static class RaceFileReader
    {
        public static string ReadFile(string path)
        {
            var extension = Path.GetExtension(path).ToLower();


            if (extension == ".json" || extension == ".xml")
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory.Substring(0,
                    AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));
                return File.ReadAllText(Path.Combine(basePath, path), Encoding.Default);
            }
            else
            {
                // TODO: Maybe use more distinct Exception class
                throw new IOException("This reader will only process files in JSON or XML format");
            }
        }
    }
}