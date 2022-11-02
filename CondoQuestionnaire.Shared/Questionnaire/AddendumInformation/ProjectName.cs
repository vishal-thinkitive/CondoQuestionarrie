namespace CondoQuestionnaire.Shared.Questionnaire.AddendumInformation;

public class ProjectName : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "Project Name:";
    public string Code => "G8:Q1:O1";
}