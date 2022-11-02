namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation;

public class HoaName : IQuestion
{
    public QuestionType Type => QuestionType.String;
    public string Label => "HOA Name (if different from Project Legal Name)";
    public string Code => "G1:Q4";
}