using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Parsers
{
    public class XmlFileParser : IFileParser
    {
        public Race ProcessFileContent(string fileContent)
        {
            var xmlDoc = XDocument.Parse(fileContent);
            var race = xmlDoc.Descendants("race").First();
            var prices = race.Descendants("prices").First().Descendants("horse");
            var horses = race.Descendants("horses").First().Descendants("horse");

            return new Race
            {
                Name = race.Attribute("name").Value,
                Horses = horses.Select(horse =>
                {
                    return new Horse
                    {
                        Name = horse.Attribute("name").Value,
                        Price = double.Parse(prices
                            .Where(p => p.Attribute("number").Value == horse.Descendants("number").First().Value)
                            .Select(p => p.Attribute("Price").Value).First())
                    };
                })
            };
        }
    }
}