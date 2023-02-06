using BuildYourKnowledge.Model;

namespace BuildYourKnowledge.Services
{
    public abstract class QuestionsLoader
    {
        public abstract List<Question> GetQuestions();
    }
}
