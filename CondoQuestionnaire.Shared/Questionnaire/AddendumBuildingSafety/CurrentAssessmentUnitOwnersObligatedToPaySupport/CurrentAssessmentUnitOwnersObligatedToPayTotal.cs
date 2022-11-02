namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.CurrentAssessmentUnitOwnersObligatedToPaySupport;

public class CurrentAssessmentUnitOwnersObligatedToPayTotal : IQuestion
{
    public QuestionType Type => QuestionType.Money;
    public string Label => "What is the total amount of the special assessment(s)?";
    public string Code => "G9:10:10A";
}