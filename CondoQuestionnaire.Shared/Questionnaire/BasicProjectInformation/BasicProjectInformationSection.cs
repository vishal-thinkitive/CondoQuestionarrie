using CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation.ProjectInclusions;

namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation;

public class BasicProjectInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent { get; }
    public string Label => "Basic Information";
    public string Code => "G1";
    public IEnumerable<IQuestion> Questions { get; }

    public BasicProjectInformationSection()
    {
        Questions = new List<IQuestion>
        {
            new ProjectLegalName(),
            new ProjectPhysicalAddress(),
            new HoaManagementAddress(),
            new HoaName(),
            new HoaTaxId(),
            new HoaManagementTaxId(),
            new NameOfUmbrellaAssociation(),
            new ProjectInclusionsQuestion()
        }.AsReadOnly();
    }
}