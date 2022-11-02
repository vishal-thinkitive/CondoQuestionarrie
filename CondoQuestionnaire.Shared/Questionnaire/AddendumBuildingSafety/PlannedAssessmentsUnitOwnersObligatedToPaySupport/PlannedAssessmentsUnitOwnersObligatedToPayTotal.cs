namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.PlannedAssessmentsUnitOwnersObligatedToPaySupport;

public class PlannedAssessmentsUnitOwnersObligatedToPayTotal : IQuestion
{
    public QuestionType Type => QuestionType.Money;
    public string Label => "What will be the total amount of the special assessments?";
    public string Code => "G9:Q11:11A";
}