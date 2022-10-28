namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumInformation;

public class AddendumProjectInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Project Information";
    public string Code => "G8:Q1";
    public IEnumerable<IQuestionGroup> SubQuestions => Enumerable.Empty<IQuestionGroup>();
    public IEnumerable<IQuestion> Questions =>Enumerable.Empty<IQuestion>();
}