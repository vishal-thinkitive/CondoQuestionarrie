namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation.HoaFinancialAccountOptions;

public class HoaFinancialAccountOptionsHoaMaintainsSeparateAccounts : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "HOA maintains separate accounts for operating and reserve funds.";
    public string Code => "G6:Q2:O1";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}