namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety;

public class OutStandingViolationsRegardingIntegrity : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Are there any outstanding violations of jurisdictional requirements (zoning ordinances, codes, etc.) related to the safety, soundness, structural integrity, or habitability of the project’s building(s)?";

    public string? Hint => "If Yes, provide notice from the applicable jurisdictional entity.";
    
    public string Code => "G9:Q4";
}