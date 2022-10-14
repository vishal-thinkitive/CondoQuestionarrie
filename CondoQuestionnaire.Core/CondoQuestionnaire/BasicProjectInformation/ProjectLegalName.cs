namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation;

public class ProjectLegalName : IQuestion
{
    public QuestionType Type => QuestionType.String;
    public string Label => "Project Legal Name";
    public string Code => "G1:Q1";
}