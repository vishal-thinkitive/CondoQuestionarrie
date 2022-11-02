namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.HoaObtainedAnyLoansToFinanceImprovementsSupport;

public class HoaObtainedAnyLoansToFinanceImprovementsSupportTerms : IQuestion
{
    public QuestionType Type => QuestionType.Money;
    public string Label => "Terms of repayment?";
    public string Code => "G9:Q12:12B";
}