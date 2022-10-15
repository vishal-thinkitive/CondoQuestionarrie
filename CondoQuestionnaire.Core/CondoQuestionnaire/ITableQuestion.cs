namespace CondoQuestionnaire.Core.CondoQuestionnaire;

public interface ITableQuestion : IQuestion
{
    IDictionary<string, QuestionType> TableColumns { get; }
    bool QuestionsHaveLabels { get; }
    IEnumerable<string> Labels { get; }
}