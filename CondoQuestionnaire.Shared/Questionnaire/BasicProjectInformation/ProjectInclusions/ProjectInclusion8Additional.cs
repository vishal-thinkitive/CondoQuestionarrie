namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8Additional : IQuestion
{
    public QuestionType Type => QuestionType.Text;

    public string Label =>
        "Provide additional detail here, if applicable (optional)";

    public string Code => "G1:Q8:Additional";
    
}