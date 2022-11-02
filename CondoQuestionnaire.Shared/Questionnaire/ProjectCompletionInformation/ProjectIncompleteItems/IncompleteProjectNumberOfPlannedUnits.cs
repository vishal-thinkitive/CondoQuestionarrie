namespace CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation.ProjectIncompleteItems;

public class IncompleteProjectNumberOfPlannedUnits : IQuestion
{
    public QuestionType Type => QuestionType.Number;
    public string Label => "How many total units are planned for the project?";
    public string Code => "G2:Q1:1E";
}