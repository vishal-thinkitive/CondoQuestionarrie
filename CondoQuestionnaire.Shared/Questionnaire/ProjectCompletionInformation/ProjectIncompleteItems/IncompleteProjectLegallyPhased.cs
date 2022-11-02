namespace CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation.ProjectIncompleteItems;

public class IncompleteProjectLegallyPhased : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Is the project legally phased?";
    public string Code => "G2:Q1:1B";
}