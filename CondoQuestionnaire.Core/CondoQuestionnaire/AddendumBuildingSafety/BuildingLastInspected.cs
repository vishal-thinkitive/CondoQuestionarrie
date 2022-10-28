namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety;

public class BuildingLastInspected : IQuestion
{
    public QuestionType Type => QuestionType.Date;
    public string Label => "When was the last building inspection by a licensed architect, licensed engineer, or any other building inspector?";
    public string Code => "G9:Q1";
}