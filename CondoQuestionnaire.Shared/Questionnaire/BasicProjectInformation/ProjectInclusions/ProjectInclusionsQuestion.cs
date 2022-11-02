namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusionsQuestion : IQuestion
{
    public QuestionType Type => QuestionType.LabelOnly;
    public string Label => "Does the project contain any of the following? Check all that apply:";
    public string Code => "G1:Q8";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public ProjectInclusionsQuestion()
    {
        SubQuestions = new List<IQuestion>
        {
            new ProjectInclusion8A(),
            new ProjectInclusion8B(),
            new ProjectInclusion8C(),
            new ProjectInclusion8D(),
            new ProjectInclusion8E(),
            new ProjectInclusion8F(),
            new ProjectInclusion8Additional()
        };
    }
}