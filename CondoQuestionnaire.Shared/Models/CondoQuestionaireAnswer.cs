using CondoQuestionnaire.Shared.Questionnaire;

namespace CondoQuestionnaire.Shared.Models;

public class CondoQuestionnaireAnswer
{
    public string? QuestionCode { get; set; }
    public QuestionType? QuestionType { get; set; }
    public object? Data { get; set; }
    public string? StringData { get; set; }
    // TODO: Add way to link to a submission to Fannie Mae
}