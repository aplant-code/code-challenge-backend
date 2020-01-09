using System.Linq;
using dotnet_code_challenge.FileReader;
using dotnet_code_challenge.Parsers;
using Xunit;

namespace dotnet_code_challenge.Test
{
    public class JsonParserTests
    {
        private JsonFileParser _parser;
        
        public JsonParserTests()
        {
            _parser = new JsonFileParser();
        }

        [Fact]
        public void ShouldDesrializeJsonProperly()
        {
            var jsonContents = RaceFileReader.ReadFile("FeedData/Wolferhampton_Race1.json");
            var race = _parser.ProcessFileContent(jsonContents);
            
            Assert.True(race.Name == "13:45 @ Wolverhampton");
            Assert.True(race.Horses.Count() == 2);
            
            // TODO: Round double to ensure no weirdness with precision
            Assert.True(race.Horses.First().Name == "Toolatetodelegate" && race.Horses.First().Price == 10.0);
        }
    }
}