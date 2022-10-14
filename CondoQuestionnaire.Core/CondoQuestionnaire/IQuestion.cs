namespace CondoQuestionnaire.Core.CondoQuestionnaire;

public interface IQuestion
{
    QuestionType Type { get; }
    string Label { get; }
    string Code { get; }
    string ParentCode => Code.Split(':')[-2];
}