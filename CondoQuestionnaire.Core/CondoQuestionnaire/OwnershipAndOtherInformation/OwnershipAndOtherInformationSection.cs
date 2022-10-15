namespace CondoQuestionnaire.Core.CondoQuestionnaire.OwnershipAndOtherInformation;

public class OwnershipAndOtherInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Ownership & Other Information";
    public string Code => "G5";
    public IEnumerable<IQuestionGroup> SubQuestions => Enumerable.Empty<IQuestionGroup>();
    public IEnumerable<IQuestion> Questions => Enumerable.Empty<IQuestion>();
}