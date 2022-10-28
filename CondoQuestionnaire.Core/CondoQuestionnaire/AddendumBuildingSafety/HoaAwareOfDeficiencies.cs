namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety;

public class HoaAwareOfDeficiencies : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Is the HOA/Cooperative Corporation aware of any deficiencies related to the safety, soundness, structural integrity, or habitability of the project’s building(s)?";
    public string Code => "G9:Q3";
}