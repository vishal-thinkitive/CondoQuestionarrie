namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8D : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Mandatory fee-based membership for use of project amenities or services";

    public string Code => "G1:Q8:8D";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}