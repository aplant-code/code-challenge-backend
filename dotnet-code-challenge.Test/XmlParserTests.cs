using System.Linq;
using dotnet_code_challenge.FileReader;
using dotnet_code_challenge.Parsers;
using Xunit;

namespace dotnet_code_challenge.Test
{
    public class XmlParserTests
    {
        private XmlFileParser _parser;
        
        public XmlParserTests()
        {
            _parser = new XmlFileParser();
        }

        [Fact]
        public void ShouldDesrializeXmlProperly()
        {
            var xmlContents = RaceFileReader.ReadFile("FeedData/Caulfield_Race1.xml");
            var race = _parser.ProcessFileContent(xmlContents);
            
            Assert.True(race.Name == "Evergreen Turf Plate");
            Assert.True(race.Horses.Count() == 2);
            
            // TODO: Round double to ensure no weirdness with precision
            Assert.True(race.Horses.First().Name == "Advancing" && race.Horses.First().Price == 4.2);
        }
    }
}