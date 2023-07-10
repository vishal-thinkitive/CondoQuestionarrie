namespace CondoQuestionnaire.Shared.Questionnaire.OwnershipAndOtherInformation;

public class UnitsUsedForNonResidentialOrCommercialSpaceTable : ITableQuestion
{
    public QuestionType Type => QuestionType.Table;
    public string Label => "If Yes , complete the following table:";
    public string Code => "G5:Q4:O1";
    public IDictionary<string, QuestionType> TableColumns => new Dictionary<string, QuestionType>
    {
        { "Type of Commercial or Non-Residential Use", QuestionType.Text },
        { "Name of Owner or Tenant", QuestionType.Text },
        { "Number of Units", QuestionType.Number },
        { "Square Footage", QuestionType.Number },
        { "Square Footage of Total Project Square Footage", QuestionType.Percentage }
    };

    public bool QuestionsHaveLabels => false;
    public IEnumerable<string> Labels => new List<string>
    {
        "1",
        "2",
        "3",
        "4",
    };
}