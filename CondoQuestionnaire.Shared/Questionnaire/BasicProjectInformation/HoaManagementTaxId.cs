namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation;

public class HoaManagementTaxId : IQuestion
{
    public QuestionType Type => QuestionType.String;
    public string Label => "HOA Management Company Tax ID #";
    public string Code => "G1:Q6";
}