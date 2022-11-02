namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.HoaAwareOfDeficienciesAnswers;

public class HoaAwareOfDeficienciesListDeficiencies : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "If Yes , what are the deficiencies?";
    public string Code => "G9:Q3:3A";
}