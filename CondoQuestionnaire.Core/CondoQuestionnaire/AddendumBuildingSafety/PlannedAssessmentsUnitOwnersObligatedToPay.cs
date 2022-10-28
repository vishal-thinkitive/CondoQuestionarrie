namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety;

public class PlannedAssessmentsUnitOwnersObligatedToPay : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are there any planned special assessments that unit owners/ cooperative shareholders will be obligated to pay?";
    public string Code => "G9:Q11";
}