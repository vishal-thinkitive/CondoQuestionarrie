namespace CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation.ProjectIncompleteItems;

public class IncompleteProjectNumberOfCompletedPhases : IQuestion
{
    public QuestionType Type => QuestionType.Number;
    public string Label => "How many phases have been completed?";
    public string Code => "G2:Q1:1C";
}