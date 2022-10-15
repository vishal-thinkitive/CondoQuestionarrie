namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation.UnitsLocatedInFloodZoneOptions;

public class UnitsLocatedInFloodZoneSelectionMaximumNfp : IQuestion
{
    public QuestionType Type => QuestionType.LabelOnly;
    public string Label => "Maximum coverage per condominium available under the National Flood Insurance Program";
    public string Code => "G6:Q1:Sel:O2";
}