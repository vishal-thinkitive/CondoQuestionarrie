namespace CondoQuestionnaire.Shared.Questionnaire.AddendumInformation;

public class AddendumProjectInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Project Information";
    public string Code => "G8:Q1";
    
    public IEnumerable<IQuestion> Questions =>Enumerable.Empty<IQuestion>();
}