using System;
using System.IO;
using dotnet_code_challenge.FileReader;
using dotnet_code_challenge.Output;
using dotnet_code_challenge.Parsers;

namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlParser = new XmlFileParser();
            var jsonParser = new JsonFileParser();

            var content = RaceFileReader.ReadFile("FeedData/Caulfield_Race1.xml");
            var xmlRace = xmlParser.ProcessFileContent(content);
            
            var jsonContent = RaceFileReader.ReadFile("FeedData/Wolferhampton_Race1.json");
            var jsonRace = jsonParser.ProcessFileContent(jsonContent);

            RaceOutputter.OutputByHorsePrice(xmlRace);
            RaceOutputter.OutputByHorsePrice(jsonRace);
        }
    }
}
