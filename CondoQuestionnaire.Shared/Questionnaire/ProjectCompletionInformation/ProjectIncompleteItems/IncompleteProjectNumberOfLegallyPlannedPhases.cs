namespace CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation.ProjectIncompleteItems;

public class IncompleteProjectNumberOfLegallyPlannedPhases : IQuestion
{
    public QuestionType Type => QuestionType.Number;
    public string Label => "How many total phases are legally planned for the project?";
    public string Code => "G2:Q1:1D";
}