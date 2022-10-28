namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety.CurrentAssessmentUnitOwnersObligatedToPaySupport;

public class CurrentAssessmentUnitOwnersObligatedToPurpose : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "What is the purpose of the special assessment(s)?";
    public string Code => "G9:10:10C";
}