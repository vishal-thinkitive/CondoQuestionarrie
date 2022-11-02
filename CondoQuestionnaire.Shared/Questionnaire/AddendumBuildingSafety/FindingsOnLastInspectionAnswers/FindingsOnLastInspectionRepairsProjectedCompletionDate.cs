namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.FindingsOnLastInspectionAnswers;

public class FindingsOnLastInspectionRepairsProjectedCompletionDate : IQuestion
{
    public QuestionType Type => QuestionType.Date;
    public string Label => "When will the repairs/replacements be completed?";
    public string Code => "G9:Q2:2C";
}