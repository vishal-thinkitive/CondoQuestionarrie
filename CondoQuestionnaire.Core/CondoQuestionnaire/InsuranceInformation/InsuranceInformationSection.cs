namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation;

public class InsuranceInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Insurance Information & Financial Controls";
    public string Code => "G6";
    public IEnumerable<IQuestionGroup> SubQuestions => Enumerable.Empty<IQuestionGroup>();
    public IEnumerable<IQuestion> Questions => Enumerable.Empty<IQuestion>();
}