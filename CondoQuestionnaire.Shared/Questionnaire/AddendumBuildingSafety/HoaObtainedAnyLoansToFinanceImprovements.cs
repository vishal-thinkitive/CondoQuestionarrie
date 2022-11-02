using CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.HoaObtainedAnyLoansToFinanceImprovementsSupport;

namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;

public class HoaObtainedAnyLoansToFinanceImprovements : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Has the HOA obtained any loans to finance improvements or deferred maintenance?";
    public string Code => "G9:Q12";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public HoaObtainedAnyLoansToFinanceImprovements()
    {
        SubQuestions = new List<IQuestion>
        {
            new HoaObtainedAnyLoansToFinanceImprovementsSupportAmount(),
            new HoaObtainedAnyLoansToFinanceImprovementsSupportTerms()
        }.AsReadOnly();
    }
}