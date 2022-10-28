namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety;

public class BuildingSafetySection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Building Safety, Soundness, Structural Integrity, and Habitability";
    public string Code => "G9";
    public IEnumerable<IQuestionGroup> SubQuestions => Enumerable.Empty<IQuestionGroup>();
    public IEnumerable<IQuestion> Questions => Enumerable.Empty<IQuestion>();
}