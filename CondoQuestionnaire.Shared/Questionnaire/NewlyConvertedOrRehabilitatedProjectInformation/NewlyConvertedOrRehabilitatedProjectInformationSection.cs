using CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabbedResponses;

namespace CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation;

public class NewlyConvertedOrRehabilitatedProjectInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Newly Converted or Rehabilitated Project Information";
    public string Code => "G3";
    public IEnumerable<IQuestion> Questions { get; }

    public NewlyConvertedOrRehabilitatedProjectInformationSection()
    {
        Questions = new List<IQuestion>
        {
            new ProjectConversionWithPast3Years(),
            new ConvertedPropertyYearConverted(),
            new ConvertedPropertyFullGutRehab(),
            new ConvertedPropertyLicensedEngineerStructurallySound(),
            new ConvertedPropertyAllRepairsComplete(),
            new ConvertedPropertyReplacementReservesAllocated(),
            new ConvertedPropertyReservesSufficient()
        }.AsReadOnly();
    }
}