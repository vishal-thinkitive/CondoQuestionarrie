namespace CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation.DeveloperTransferredControl;

public class DeveloperTransferredControlConfirmationYesOption : IQuestion
{
    public QuestionType Type => QuestionType.Date;
    public string Label => "Date Transferred:";
    public string Code => "G2:Q2:Yes";
    
}