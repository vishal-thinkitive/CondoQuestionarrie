namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumInformation;

public class ProjectAddress : IQuestion
{
    public QuestionType Type => QuestionType.Address;
    public string Label => "Project Address:";
    public string Code => "G8:Q1:O2";
}