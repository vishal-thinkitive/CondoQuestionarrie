namespace CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation.HoaFinancialAccountOptions;

public class HoaFinancialAccountOptionsAppropriateAccessControls : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Appropriate access controls are in place for each account.";
    public string Code => "G6:Q2:O2";
    
}