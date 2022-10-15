namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation;

public class UnitsLocatedInFloodZone : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are units or common elements located in a flood zone?";
    public string Code => "G6:Q1";
}