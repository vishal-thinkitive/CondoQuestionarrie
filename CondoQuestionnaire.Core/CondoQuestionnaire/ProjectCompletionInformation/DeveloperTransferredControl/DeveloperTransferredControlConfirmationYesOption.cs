namespace CondoQuestionnaire.Core.CondoQuestionnaire.ProjectCompletionInformation.DeveloperTransferredControl;

public class DeveloperTransferredControlConfirmationYesOption : IQuestionOption
{
    public QuestionType Type => QuestionType.Date;
    public string Label => "Date Transferred:";
    public string Code => "G2:Q2:Yes";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}