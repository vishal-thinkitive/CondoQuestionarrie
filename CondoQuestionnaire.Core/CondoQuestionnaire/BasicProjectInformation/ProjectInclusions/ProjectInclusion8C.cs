namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8C : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Manufactured homes";

    public string Code => "G1:Q8:8C";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}