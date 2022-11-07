namespace CondoQuestionnaire.Shared.Questionnaire.OwnershipAndOtherInformation;

public class InformationRegardingOwnershipOfUnits : ITableQuestion
{
    public QuestionType Type => QuestionType.Table;
    public string Label => "Complete the following information concerning ownership of units:";
    public string Code => "G5:Q1";
    public IDictionary<string, QuestionType> TableColumns { get; } = new Dictionary<string, QuestionType>
    {
        { "", QuestionType.LabelOnly },
        { "Entire Project", QuestionType.Number },
        { "Subject Legal Phase (in which the unit is located), \nIf Applicable", QuestionType.Text }
    };

    public bool QuestionsHaveLabels => true;
    public IEnumerable<string> Labels => new List<string>
    {
        "Total number of units",
        "Total number of units sold and closed",
        "Total number of units under bona-fide sales contracts",
        "Total number of units sold and closed or under contract to owner-occupants",
        "Total number of units sold and closed or under contract to second home owners",
        "Total number of units sold and closed or under contract to investor owners",
        "Total number of units being rented by developer, sponsor, or converter",
        "Total number of units owned by the HOA"
    };
}