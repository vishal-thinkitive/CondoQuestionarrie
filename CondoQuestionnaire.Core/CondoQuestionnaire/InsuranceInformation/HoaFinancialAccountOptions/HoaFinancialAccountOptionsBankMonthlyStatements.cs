namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation.HoaFinancialAccountOptions;

public class HoaFinancialAccountOptionsBankMonthlyStatements : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "The bank sends copies of monthly bank statements directly to the HOA.";
    public string Code => "G6:Q2:O3";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}