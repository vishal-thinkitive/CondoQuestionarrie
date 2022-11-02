namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8B : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Deed or resale restrictions";

    public string Code => "G1:Q8:8B";
    
}