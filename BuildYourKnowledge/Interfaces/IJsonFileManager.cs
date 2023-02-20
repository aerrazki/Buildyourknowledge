using System.Text.Json.Nodes;

namespace BuildYourKnowledge.Interfaces
{
    public interface IJsonFileManager
    {
        JsonObject ReadFile(string jsonFile);
        void WriteNodeToFile();
        void WriteToFile(object obj, string jsonFile);
    }
}