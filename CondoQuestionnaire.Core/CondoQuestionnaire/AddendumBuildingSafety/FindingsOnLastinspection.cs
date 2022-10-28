namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety;

public class FindingsOnLastInspection : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Did the last inspection have any findings related to the safety, soundness, structural integrity, or habitability of the project’s building(s)?";
    public string Code => "G9:Q2";
}