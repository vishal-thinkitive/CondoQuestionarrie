namespace CondoQuestionnaire.Core.CondoQuestionnaire.LenderInformation;

public class LenderName: IQuestion
{
    public QuestionType Type => QuestionType.String;
    public string Label => "Lender Name";
    public string Code => "G0:Q1";
    public string ParentCode => "G0";
}