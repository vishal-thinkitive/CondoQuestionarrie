namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8Additional : IQuestionOption
{
    public QuestionType Type => QuestionType.Text;

    public string Label =>
        "Provide additional detail here, if applicable (optional)";

    public string Code => "G1:Q8:Additional";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}