namespace CondoQuestionnaire.Core.CondoQuestionnaire.LenderInformation;

public class LenderInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Lender Information";
    public string Code => "G0";
    public IEnumerable<IQuestionGroup> SubQuestions { get; }
    public IEnumerable<IQuestion> Questions { get; }
}