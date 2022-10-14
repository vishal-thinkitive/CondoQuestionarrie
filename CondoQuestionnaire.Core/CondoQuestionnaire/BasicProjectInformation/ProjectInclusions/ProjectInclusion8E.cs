namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8E : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Non-incidental income from business operations";

    public string Code => "G1:Q8:8E";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}