namespace CondoQuestionnaire.Core.CondoQuestionnaire.FinancialInformation;

public class UnitOwners60DaysDelinquent : IQuestion
{
    public QuestionType Type => QuestionType.Number;
    public string Label => "How many unit owners are 60 or more days delinquent on common expense assessments?";
    public string Code => "G4:Q1";
}