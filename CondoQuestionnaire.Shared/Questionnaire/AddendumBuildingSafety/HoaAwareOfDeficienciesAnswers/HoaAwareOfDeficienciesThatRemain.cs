namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.HoaAwareOfDeficienciesAnswers;

public class HoaAwareOfDeficienciesThatRemain : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "Of these deficiencies, what repairs/replacements remain to be completed?";
    public string Code => "G9:Q3:3B";
}