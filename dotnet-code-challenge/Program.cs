using System;
using System.IO;
using dotnet_code_challenge.Parsers;

namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlParser = new XmlFileParser();
            var fileReader = new FileReader.FileReader();
            var jsonParser = new JsonFileParser();

            var content = fileReader.ReadFile("FeedData/Caulfield_Race1.xml");
            var race = xmlParser.ProcessFileContent(content);
            
            var jsonContent = fileReader.ReadFile("FeedData/Wolferhampton_Race1.json");
            race = jsonParser.ProcessFileContent(jsonContent);
        }
    }
}
