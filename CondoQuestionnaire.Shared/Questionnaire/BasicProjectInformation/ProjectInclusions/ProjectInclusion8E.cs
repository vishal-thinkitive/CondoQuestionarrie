namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8E : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Non-incidental income from business operations";

    public string Code => "G1:Q8:8E";
    
}