namespace CondoQuestionnaire.Core.CondoQuestionnaire.FinancialInformation;

public class FinancialInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Financial Information";
    public string Code => "G4";
    public IEnumerable<IQuestionGroup> SubQuestions => Enumerable.Empty<IQuestionGroup>();
    public IEnumerable<IQuestion> Questions => Enumerable.Empty<IQuestion>();
}