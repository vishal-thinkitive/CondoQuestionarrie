namespace CondoQuestionnaire.Core.CondoQuestionnaire.FinancialInformation;

public class MortgageeResponsibleForPayingAssessments : IQuestion
{
    public QuestionType Type => QuestionType.Selection;
    public string Label => "How many unit owners are 60 or more days delinquent on common expense assessments?";
    public string Code => "G4:Q2";
}