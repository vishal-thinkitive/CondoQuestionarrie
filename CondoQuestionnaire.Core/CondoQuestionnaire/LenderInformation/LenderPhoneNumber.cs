namespace CondoQuestionnaire.Core.CondoQuestionnaire.LenderInformation;

public class LenderPhoneNumber: IQuestion
{
    public QuestionType Type => QuestionType.PhoneNumber;
    public string Label => "Lender Phone Number";
    public string Code => "G0:Q4";
}