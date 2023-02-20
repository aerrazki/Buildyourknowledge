using System.Text.Json.Nodes;
using BuildYourKnowledge.Interfaces;

namespace BuildYourKnowledge.Services
{
    public class JsonFileManager : IJsonFileManager
    {
        public JsonFileManager() { }
        public JsonFileManager(string jsonFile)
        {

            //Test if the json file exists 
            var questionsArr = new JsonObject
            {
                ["questions"] = new JsonArray(
                    new JsonObject
                    { }
                )
            };
            File.WriteAllText("questions.json", questionsArr.ToString());

        }
        public JsonObject ReadFile(string jsonFile)
        {

            return new JsonObject();
        }

        public void WriteToFile(Object obj, string jsonFile)
        {

        }

        public void WriteNodeToFile() { }

    }
}
