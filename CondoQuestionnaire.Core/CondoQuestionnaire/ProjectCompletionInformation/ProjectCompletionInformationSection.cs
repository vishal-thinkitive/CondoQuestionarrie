namespace CondoQuestionnaire.Core.CondoQuestionnaire.ProjectCompletionInformation;

public class ProjectCompletionInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Project Completion Information";
    public string Code => "G2";
    public IEnumerable<IQuestionGroup> SubQuestions { get; }
    public IEnumerable<IQuestion> Questions { get; }
}