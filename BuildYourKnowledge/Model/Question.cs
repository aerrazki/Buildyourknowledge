namespace BuildYourKnowledge.Model
{
    public class Question
    {
        public Question()
        {

        }
        public Question(int id) { }
        public int _Id { get; set; }
        public string _Question { get; set; }

        public string[] _Choices { get; set; }

        public string[] _Answers { get; set; }
    }
}
