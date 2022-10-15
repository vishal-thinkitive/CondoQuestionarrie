namespace CondoQuestionnaire.Core.CondoQuestionnaire;

public interface IQuestionGroup
{
    IQuestionGroup? Parent { get; }
    string Label { get; }
    string Code { get; }
    IEnumerable<IQuestionGroup> SubQuestions { get; }
    IEnumerable<IQuestion> Questions { get; }
}