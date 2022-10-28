namespace CondoQuestionnaire.Core.CondoQuestionnaire;

public interface IQuestion
{
    QuestionType Type { get; }
    string Label { get; }
    string Code { get; }
    string? Hint => null;
    string ParentCode => Code.Split(':')[-2];
}