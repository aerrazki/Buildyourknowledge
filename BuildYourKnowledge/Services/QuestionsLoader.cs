using BuildYourKnowledge.Model;

namespace BuildYourKnowledge.Services
{
    public abstract class QuestionsLoader
    {
        public abstract IList<Question> GetQuestions();
        public abstract Question GetQuestion(int id);
    }
}
