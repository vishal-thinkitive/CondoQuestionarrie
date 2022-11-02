namespace CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation.HoaFinancialAccountOptions;

public class HoaFinancialAccountOptionsManagementCompanyCannotWithdrawFromReserve : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "The Management Company does not have the authority to draw checks on, or transfer funds from, the reserve account of the HOA.";
    public string Code => "G6:Q2:O6";
    
}