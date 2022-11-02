namespace CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation.UnitsLocatedInFloodZoneOptions;

public class UnitsLocatedInFloodZoneSelection100Percent : IQuestion
{
    public QuestionType Type => QuestionType.LabelOnly;
    public string Label => "100% replacement cost";
    public string Code => "G6:Q1:Sel:O1";
}