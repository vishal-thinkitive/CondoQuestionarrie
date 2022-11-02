namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.FindingsOnLastInspectionAnswers;

public class FindingsOnLastInspectionRepairsRemaining : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "What repairs/replacements remain to be completed?";
    public string Code => "G9:Q2:2B";
}