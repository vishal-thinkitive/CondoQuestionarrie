namespace CondoQuestionnaire.Core.CondoQuestionnaire.ProjectCompletionInformation;

public class ProjectCompletedConfirmation : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Is the project 100% complete, including all construction or renovation of units, common elements, and shared amenities for all project phases?";

    public string Code => "G2:Q1";
}