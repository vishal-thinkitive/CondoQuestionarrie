namespace CondoQuestionnaire.Shared.Questionnaire.FinancialInformation;

public class FinancialInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Financial Information";
    public string Code => "G4";

    public IEnumerable<IQuestion> Questions { get; }

    public FinancialInformationSection()
    {
        Questions = new List<IQuestion>
        {
            new UnitOwners60DaysDelinquent(),
            new MortgageeResponsibleForPayingAssessments(),
            new HoaInvolvedInLitigation()
        }.AsReadOnly();
    }
}