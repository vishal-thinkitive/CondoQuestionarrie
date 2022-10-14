namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation;

public class HoaTaxId : IQuestion
{
    public QuestionType Type => QuestionType.String;
    public string Label => "HOA Tax ID #";
    public string Code => "G1:Q5";
}