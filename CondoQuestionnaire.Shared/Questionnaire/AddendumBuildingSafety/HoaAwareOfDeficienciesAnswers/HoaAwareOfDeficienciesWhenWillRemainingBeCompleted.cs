namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.HoaAwareOfDeficienciesAnswers;

public class HoaAwareOfDeficienciesWhenWillRemainingBeCompleted : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "Of these deficiencies, when will the repairs/ replacements be completed?";
    public string Code => "G9:Q3:3C";
}