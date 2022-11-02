namespace CondoQuestionnaire.Shared.Questionnaire.FinancialInformation.MortgageeResponsibleForPayingAssessmentsOptions;

public class MortgageeResponsibleForPayingAssessmentsMoreThan12MonthsOption : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "More than 12 months";
    public string Code => "G4:Q2:O3";
    
}