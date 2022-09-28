namespace CondoQuestionnaire.Core.CondoQuestionnaire.LenderInformation;

public class LenderEmail: IQuestion
{
    public QuestionType Type => QuestionType.PhoneNumber;
    public string Label => "Lender Email Address";
    public string Code => "G0:Q6";
}