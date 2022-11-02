namespace CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation;

public class ProjectCompletionInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Project Completion Information";
    public string Code => "G2";
    public IEnumerable<IQuestion> Questions { get; }

    public ProjectCompletionInformationSection()
    {
        Questions = new List<IQuestion>
        {
            new ProjectCompletedConfirmation(),
            new DeveloperTransferredControlConfirmation()
        }.AsReadOnly();
    }
}