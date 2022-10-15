namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation.HoaFinancialAccountOptions;

public class HoaFinancialAccountOptions2DirectorsRequiredToSignChecks : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Two members of the HOA Board of Directors are required to sign any check written on the reserve account.";
    public string Code => "G6:Q2:O4";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}