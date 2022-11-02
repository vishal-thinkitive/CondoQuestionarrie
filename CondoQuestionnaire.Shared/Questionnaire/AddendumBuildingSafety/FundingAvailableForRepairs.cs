namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;

public class FundingAvailableForRepairs : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Does the project have a funding plan for its deferred maintenance components/items to be repaired or replaced?";
    public string Code => "G9:Q6";
}