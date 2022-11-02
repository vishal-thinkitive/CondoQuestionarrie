using CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation.DeveloperTransferredControl;

namespace CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation;

public class DeveloperTransferredControlConfirmation : IQuestion
{
    public QuestionType Type => QuestionType.BooleanWithDateOption;
    public IQuestionGroup? Parent => null;
    public string Label { get; }
    public string Code => "G2:Q2";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public DeveloperTransferredControlConfirmation()
    {
        SubQuestions = new List<IQuestion>
        {
            new DeveloperTransferredControlConfirmationYesOption(),
            new DeveloperTransferredControlConfirmationNoOption()
        }.AsReadOnly();
    }
}