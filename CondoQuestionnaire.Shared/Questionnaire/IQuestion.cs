namespace CondoQuestionnaire.Shared.Questionnaire;

public interface IQuestion
{
    QuestionType Type { get; }
    string Label { get; }
    string Code { get; }
    string? Hint => null;
    string ParentCode => Code.Split(':')[-2];
    
    IEnumerable<IQuestion> SubQuestions => Enumerable.Empty<IQuestion>();
}