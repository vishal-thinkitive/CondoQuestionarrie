namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8F : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Supportive or continuing care for seniors or for residents with disabilities";

    public string Code => "G1:Q8:8F";
    
}