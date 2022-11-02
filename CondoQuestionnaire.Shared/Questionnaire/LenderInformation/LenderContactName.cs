namespace CondoQuestionnaire.Shared.Questionnaire.LenderInformation;

public class LenderContactName: IQuestion
{
    public QuestionType Type => QuestionType.String;
    public string Label => "Contact Name";
    public string Code => "G0:Q2";
}