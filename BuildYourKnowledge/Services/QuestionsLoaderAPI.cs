using BuildYourKnowledge.Model;

namespace BuildYourKnowledge.Services
{
    public class QuestionsLoaderAPI : QuestionsLoader
    {
        private readonly ResultAPI _resultApi = new ResultAPI();
        public QuestionsLoaderAPI()
        {

        }

        public override List<Question> GetQuestions()
        {
            //Get the questions from API result
            throw new NotImplementedException();
        }

        public override Question GetQuestion(int id)
        {
            throw new NotImplementedException();
        }
    }
}
