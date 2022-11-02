namespace CondoQuestionnaire.Shared.Questionnaire.LenderInformation;

public class LenderInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Lender Information";
    public string Code => "G0";
    public IEnumerable<IQuestion> Questions { get; }
    
    public LenderInformationSection()
    {
        Questions = new List<IQuestion>
        {
            new LenderName(),
            new LenderContactName(),
            new LenderAddress(),
            new LenderPhoneNumber(),
            new LenderFaxNumber(),
            new LenderEmail()
        }.AsReadOnly();
    }
}