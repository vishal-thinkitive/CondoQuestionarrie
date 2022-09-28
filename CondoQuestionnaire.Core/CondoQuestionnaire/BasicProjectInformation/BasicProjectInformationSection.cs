namespace CondoQuestionnaire.Core.CondoQuestionnaire.BasicProjectInformation;

public class BasicProjectInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent { get; }
    public string Label => "IQuestionGroup";
    public string Code => "G1";
    public IEnumerable<IQuestionGroup> SubQuestions { get; }
    public IEnumerable<IQuestion> Questions { get; }
}