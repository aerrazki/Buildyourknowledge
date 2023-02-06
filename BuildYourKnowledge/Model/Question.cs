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

        public string[] Choices { get; set; }

        public string[] Answers { get; set; }
    }
}
