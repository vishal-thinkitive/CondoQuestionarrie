namespace CondoQuestionnaire.Core.CondoQuestionnaire.ProjectCompletionInformation.ProjectIncompleteItems;

public class IncompleteProjectAmenitiesComplete : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are all planned amenities and common facilities fully complete?";
    public string Code => "G2:Q1:1F";
}