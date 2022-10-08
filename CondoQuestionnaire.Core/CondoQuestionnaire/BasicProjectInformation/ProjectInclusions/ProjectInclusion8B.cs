namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8B : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Deed or resale restrictions";

    public string Code => "G1:Q8:8B";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}