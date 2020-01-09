using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Parsers
{
    public interface IFileParser
    {
        Race ProcessFileContent(string fileContent);
    }
}