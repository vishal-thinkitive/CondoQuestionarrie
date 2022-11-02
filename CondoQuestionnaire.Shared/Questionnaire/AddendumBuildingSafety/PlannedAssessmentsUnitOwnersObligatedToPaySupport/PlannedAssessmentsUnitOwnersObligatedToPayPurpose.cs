namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.PlannedAssessmentsUnitOwnersObligatedToPaySupport;

public class PlannedAssessmentsUnitOwnersObligatedToPayPurpose : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "What will be the purpose of the special assessments?";
    public string Code => "G9:Q11:11C";
}