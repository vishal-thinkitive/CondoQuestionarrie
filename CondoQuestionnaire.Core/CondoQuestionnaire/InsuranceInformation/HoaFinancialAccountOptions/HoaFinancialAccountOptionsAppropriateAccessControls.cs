namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation.HoaFinancialAccountOptions;

public class HoaFinancialAccountOptionsAppropriateAccessControls : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Appropriate access controls are in place for each account.";
    public string Code => "G6:Q2:O2";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}