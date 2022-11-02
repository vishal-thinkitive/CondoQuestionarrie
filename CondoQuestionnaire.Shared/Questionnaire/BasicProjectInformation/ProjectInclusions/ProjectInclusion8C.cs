namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8C : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Manufactured homes";

    public string Code => "G1:Q8:8C";
    
}