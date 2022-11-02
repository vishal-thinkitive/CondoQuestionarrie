namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.FindingsOnLastInspectionAnswers;

public class FindingsOnLastInspectionRepairsCompleted : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "If Yes, have recommended repairs/replacements been completed?";
    public string Code => "G9:Q2:2A";
}