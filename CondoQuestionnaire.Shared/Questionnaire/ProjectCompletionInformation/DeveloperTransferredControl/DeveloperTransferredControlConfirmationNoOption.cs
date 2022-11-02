namespace CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation.DeveloperTransferredControl;

public class DeveloperTransferredControlConfirmationNoOption : IQuestion
{
    public QuestionType Type => QuestionType.Date;
    public string Label => "Estimated date the transfer will occur:";
    public string Code => "G2:Q2:No";
    
}