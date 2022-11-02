namespace CondoQuestionnaire.Shared.Questionnaire.OwnershipAndOtherInformation;

public class UnitsOwnedByTheSameIndividual : ITableQuestion
{
    public QuestionType Type => QuestionType.Table;
    public string Label => "Complete the following table if more than one unit is owned by the same individual or entity.";
    public string Code => "G5:Q2";
    public IDictionary<string, QuestionType> TableColumns => new Dictionary<string, QuestionType>
    {
        { "Individual / Entity Name", QuestionType.Text },
        { "Developer or Sponsor (Yes or No)", QuestionType.Boolean },
        { "Number of Units Owned", QuestionType.Number },
        { "Percentage Owned of Total Project Units", QuestionType.Percentage },
        { "Number Leased at Market Rent", QuestionType.Number },
        { "Number Leased under Rent Control", QuestionType.Number }
    };

    public bool QuestionsHaveLabels => false;
    public IEnumerable<string> Labels => Enumerable.Empty<string>();
}