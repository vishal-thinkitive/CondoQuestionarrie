namespace CondoQuestionnaire.Core.CondoQuestionnaire.ProjectCompletionInformation.ProjectIncompleteItems;

public class IncompleteProjectAdditionalPhasing : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Is the project subject to additional phasing or annexation?";
    public string Code => "G2:Q1:1A";
}