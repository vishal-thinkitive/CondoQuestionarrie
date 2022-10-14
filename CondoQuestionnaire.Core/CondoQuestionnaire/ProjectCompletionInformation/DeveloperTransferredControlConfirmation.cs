namespace CondoQuestionnaire.Core.CondoQuestionnaire.ProjectCompletionInformation;

public class DeveloperTransferredControlConfirmation : IQuestion
{
    public QuestionType Type => QuestionType.BooleanWithDateOption;
    public IQuestionGroup? Parent => null;
    public string Label { get; }
    public string Code => "G2:Q2";
}