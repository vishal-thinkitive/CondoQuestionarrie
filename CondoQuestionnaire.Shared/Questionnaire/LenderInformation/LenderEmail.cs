namespace CondoQuestionnaire.Shared.Questionnaire.LenderInformation;

public class LenderEmail: IQuestion
{
    public QuestionType Type => QuestionType.Email;
    public string Label => "Lender Email Address";
    public string Code => "G0:Q6";
}