namespace CondoQuestionnaire.Core.CondoQuestionnaire.NewlyConvertedOrRehabilitatedProjectInformation;

public class NewlyConvertedOrRehabilitatedProjectInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Newly Converted or Rehabilitated Project Information";
    public string Code => "G3";
    public IEnumerable<IQuestionGroup> SubQuestions => Enumerable.Empty<IQuestionGroup>();
    public IEnumerable<IQuestion> Questions => Enumerable.Empty<IQuestion>();
}