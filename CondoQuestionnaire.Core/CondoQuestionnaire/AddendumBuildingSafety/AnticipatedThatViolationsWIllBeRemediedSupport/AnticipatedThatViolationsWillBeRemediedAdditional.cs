namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety.AnticipatedThatViolationsWIllBeRemediedSupport;

public class AnticipatedThatViolationsWillBeRemediedAdditional : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "If Yes provide details of the applicable jurisdiction’s requirement and the project’s plan to remediate the violation.";
    public string Code => "G9:Q5:Yes";
}