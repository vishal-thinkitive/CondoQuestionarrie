namespace CondoQuestionnaire.Shared.Questionnaire.FinancialInformation.MortgageeResponsibleForPayingAssessmentsOptions;

public class MortgageeResponsibleForPayingAssessments1To6MonthOption : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "1 to 6 months";
    public string Code => "G4:Q2:O1";
    
}