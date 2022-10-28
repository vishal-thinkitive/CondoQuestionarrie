namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety;

public class HoaObtainedAnyLoansToFinanceImprovements : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Has the HOA obtained any loans to finance improvements or deferred maintenance?";
    public string Code => "G9:Q12";
}