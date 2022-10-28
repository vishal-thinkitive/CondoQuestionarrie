namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety;

public class CurrentAssessmentUnitOwnersObligatedToPay : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are there any current special assessments unit owners/ cooperative shareholders are obligated to pay?";
    public string Code => "G9:Q10";
}