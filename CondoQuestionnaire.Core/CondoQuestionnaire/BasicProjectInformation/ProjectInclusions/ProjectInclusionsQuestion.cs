namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusionsQuestion : IQuestion
{
    public QuestionType Type => QuestionType.String;
    public string Label => "Name of Master or Umbrella Association (if applicable)";
    public string Code => "G1:Q8";
}