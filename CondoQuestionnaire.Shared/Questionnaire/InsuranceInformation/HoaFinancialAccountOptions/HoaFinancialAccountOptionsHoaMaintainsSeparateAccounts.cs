namespace CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation.HoaFinancialAccountOptions;

public class HoaFinancialAccountOptionsHoaMaintainsSeparateAccounts : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "HOA maintains separate accounts for operating and reserve funds.";
    public string Code => "G6:Q2:O1";
    
}