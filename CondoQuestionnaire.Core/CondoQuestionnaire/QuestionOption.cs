namespace CondoQuestionnaire.Core.CondoQuestionnaire;

public interface IQuestionOption
{
    QuestionType Type { get; }
    string Label { get; }
    string Code { get; }
    string ParentCode => Code.Split(':')[-2];
    IEnumerable<IQuestion> AttachedQuestions { get; }
}