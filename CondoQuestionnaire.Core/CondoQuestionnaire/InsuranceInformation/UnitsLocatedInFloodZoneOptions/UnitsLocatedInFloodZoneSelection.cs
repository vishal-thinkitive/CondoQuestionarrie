namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation.UnitsLocatedInFloodZoneOptions;

public class UnitsLocatedInFloodZoneSelection : IQuestion
{
    public QuestionType Type => QuestionType.Selection;
    public string Label => "If Yes , flood coverage is in force equaling ( Select only one option below ):";
    public string Code => "G6:Q1:Sel";
}