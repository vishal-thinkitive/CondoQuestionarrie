namespace CondoQuestionnaire.Shared.Questionnaire;

public interface IQuestionGroup
{
    IQuestionGroup? Parent { get; }
    string Label { get; }
    string Code { get; }
    IEnumerable<IQuestion> Questions { get; }
}