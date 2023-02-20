namespace BuildYourKnowledge.Services
{
    public class ConfigAPI
    {
        public static string API_KEY = "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";
        public static string API_URI = "https://api.openai.com/v1/completions";
        public static string API_AUTH = $"Bearer {API_KEY}";
        public static string MODEL = "text-davinci-003";
        public static int MAX_TOKENS = 1000;
    }
}
