using System.Collections.Generic;
using dotnet_code_challenge.Models;
using Newtonsoft.Json;
using System.Linq;

namespace dotnet_code_challenge.Parsers
{
    public class JsonFileParser : IFileParser
    {
        public Race ProcessFileContent(string fileContent)
        {
            dynamic fileObject = JsonConvert.DeserializeObject(fileContent);
            dynamic raceContent = fileObject.RawData;
            
            // TODO: Currently assuming based on data there is only ever one market - handle multiple markets instead?
            IEnumerable<dynamic> horses = raceContent.Markets[0].Selections;

            return new Race
            {
                Name = raceContent.FixtureName,
                Horses = horses.Select(horse =>
                {
                    return new Horse
                    {
                        Name = horse.Tags.name,
                        Price = horse.Price
                    };
                })
            };
        }
    }
}