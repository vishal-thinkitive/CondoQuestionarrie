namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety.HoaObtainedAnyLoansToFinanceImprovementsSupport;

public class HoaObtainedAnyLoansToFinanceImprovementsSupportAmount : IQuestion
{
    public QuestionType Type => QuestionType.Money;
    public string Label => "Amount Borrowed";
    public string Code => "G9:Q12:12A";
}