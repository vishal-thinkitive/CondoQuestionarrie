namespace CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation;

public class InsuranceCarriers : ITableQuestion
{
    public QuestionType Type => QuestionType.Table;
    public string Label => "Supply the information requested below. Do NOT enter “contact agent.”";
    
    public string Code => "G6:Q3";
    public IDictionary<string, QuestionType> TableColumns => new Dictionary<string, QuestionType>
    {
        { "Type of Insurance", QuestionType.LabelOnly },
        { "Carrier/Agent Name", QuestionType.Text },
        { "Carrier/Agent Phone Number", QuestionType.PhoneNumber },
        { "Policy Number", QuestionType.Text }
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