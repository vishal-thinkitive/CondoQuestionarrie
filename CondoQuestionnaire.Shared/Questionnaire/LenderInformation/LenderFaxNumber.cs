namespace CondoQuestionnaire.Shared.Questionnaire.LenderInformation;

public class LenderFaxNumber: IQuestion
{
    public QuestionType Type => QuestionType.PhoneNumber;
    public string Label => "Lender Fax Number";
    public string Code => "G0:Q5";
}