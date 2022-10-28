namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety.PlannedAssessmentsUnitOwnersObligatedToPaySupport;

public class PlannedAssessmentsUnitOwnersObligatedToPayTerms : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "What will be the terms of the special assessments?";
    public string Code => "G9:Q11:11B";
}