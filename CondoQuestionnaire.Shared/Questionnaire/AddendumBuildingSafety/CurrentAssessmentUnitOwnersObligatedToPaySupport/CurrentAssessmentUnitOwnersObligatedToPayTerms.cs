namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.CurrentAssessmentUnitOwnersObligatedToPaySupport;

public class CurrentAssessmentUnitOwnersObligatedToPayTerms : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "What are the terms of the special assessment(s)?";
    public string Code => "G9:10:10B";
}