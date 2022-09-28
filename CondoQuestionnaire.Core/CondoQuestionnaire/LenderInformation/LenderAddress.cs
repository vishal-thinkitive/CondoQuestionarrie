namespace CondoQuestionnaire.Core.CondoQuestionnaire.LenderInformation;

public class LenderAddress: IQuestion
{
    public QuestionType Type => QuestionType.String;
    public string Label => "Lender Address";
    public string Code => "G0:Q3";
}