namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation;

public class HoaManagementAddress : IQuestion
{
    public QuestionType Type => QuestionType.Address;
    public string Label => "HOA Management Address";
    public string Code => "G1:Q3";
}