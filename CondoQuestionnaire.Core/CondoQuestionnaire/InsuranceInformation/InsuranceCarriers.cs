namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation;

public class InsuranceCarriers : ITableQuestion
{
    public QuestionType Type => QuestionType.Table;
    public string Label => "Supply the information requested below. Do NOT enter “contact agent.”";
    
    public string Code => "G6:Q3";
    public IDictionary<string, QuestionType> TableColumns => new Dictionary<string, QuestionType>
    {
        { "Type of Insurance", QuestionType.LabelOnly },
        { "Type of Insurance", QuestionType.Text },
        { "Type of Insurance", QuestionType.PhoneNumber },
        { "Type of Insurance", QuestionType.Text }
    };

    public bool QuestionsHaveLabels => true;
    public IEnumerable<string> Labels => new List<string>
    {
        "Hazard",
        "Liability",
        "Fidelity",
        "Flood"
    };
}