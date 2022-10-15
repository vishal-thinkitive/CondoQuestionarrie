namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation.HoaFinancialAccountOptions;

public class HoaFinancialAccountOptionsManagementCompanyMaintainsSeparateRecords : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "The Management Company maintains separate records and bank accounts for each HOA that uses its services.";
    public string Code => "G6:Q2:O5";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}