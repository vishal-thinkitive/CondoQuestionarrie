namespace CondoQuestionnaire.Core.CondoQuestionnaire.ProjectCompletionInformation.DeveloperTransferredControl;

public class DeveloperTransferredControlConfirmationNoOption : IQuestionOption
{
    public QuestionType Type => QuestionType.Date;
    public string Label => "Estimated date the transfer will occur:";
    public string Code => "G2:Q2:No";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}