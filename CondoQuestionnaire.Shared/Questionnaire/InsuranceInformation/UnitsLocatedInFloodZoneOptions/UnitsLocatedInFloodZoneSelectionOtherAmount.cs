namespace CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation.UnitsLocatedInFloodZoneOptions;

public class UnitsLocatedInFloodZoneSelectionOtherAmount : IQuestion
{
    public QuestionType Type => QuestionType.Money;
    public string Label => "Some other amount ( Enter amount here )";
    public string Code => "G6:Q1:Sel:O3";
}