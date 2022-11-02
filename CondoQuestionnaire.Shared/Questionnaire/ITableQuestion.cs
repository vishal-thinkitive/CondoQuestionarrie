namespace CondoQuestionnaire.Shared.Questionnaire;

public interface ITableQuestion : IQuestion
{
    IDictionary<string, QuestionType> TableColumns { get; }
    bool QuestionsHaveLabels { get; }
    IEnumerable<string> Labels { get; }
}