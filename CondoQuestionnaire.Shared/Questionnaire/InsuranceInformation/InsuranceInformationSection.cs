namespace CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation;

public class InsuranceInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Insurance Information & Financial Controls";
    public string Code => "G6";

    public IEnumerable<IQuestion> Questions { get; }

    public InsuranceInformationSection()
    {
        Questions = new List<IQuestion>
        {
            new UnitsLocatedInFloodZone(),
            new HoaFinancialAccount(),
            new InsuranceCarriers()
        }.AsReadOnly();
    }
}