namespace BuildYourKnowledge.Interfaces
{
    public interface IResultAPI
    {
        Task<string> CallAPI(string query, bool toDebug);
        void TestAPI();
    }
}