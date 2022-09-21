namespace TownhomeQuestionnaire.Core.Models;

public class QuestionnaireAnswer : BaseModel
{
    public string QuestionCode { get; set; }
    public string Value { get; set; }
    public dynamic BlobValue { get; set; }
    public Guid? QuestionnaireId { get; set; }
    public CondoQuestionnaire Questionnaire { get; set; }
}