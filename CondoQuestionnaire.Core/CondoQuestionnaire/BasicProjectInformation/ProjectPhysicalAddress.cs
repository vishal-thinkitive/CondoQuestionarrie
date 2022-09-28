namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation;

public class ProjectPhysicalAddress : IQuestion
{
    public QuestionType Type => QuestionType.Address;
    public string Label => "Project Physical Address";
    public string Code => "G1:Q2";
}