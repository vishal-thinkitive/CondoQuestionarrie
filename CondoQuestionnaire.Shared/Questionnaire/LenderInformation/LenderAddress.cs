namespace CondoQuestionnaire.Shared.Questionnaire.LenderInformation;

public class LenderAddress: IQuestion
{
    public QuestionType Type => QuestionType.Address;
    public string Label => "Lender Address";
    public string Code => "G0:Q3";
}