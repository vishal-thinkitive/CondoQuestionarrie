namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8D : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Mandatory fee-based membership for use of project amenities or services";

    public string Code => "G1:Q8:8D";
    
}