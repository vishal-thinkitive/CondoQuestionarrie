using CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;
using CondoQuestionnaire.Shared.Questionnaire.AddendumInformation;
using CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation;
using CondoQuestionnaire.Shared.Questionnaire.FinancialInformation;
using CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation;
using CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation;
using CondoQuestionnaire.Shared.Questionnaire.OwnershipAndOtherInformation;
using CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation;

namespace CondoQuestionnaire.Shared.Questionnaire;

public class CondoBuildingQuestionProvider
{
    public IEnumerable<IQuestionGroup> Groups;

    public CondoBuildingQuestionProvider()
    {
        Groups = new List<IQuestionGroup>
            {
                new BasicProjectInformationSection(),
                new ProjectCompletionInformationSection(),
                new NewlyConvertedOrRehabilitatedProjectInformationSection(),
                new FinancialInformationSection(),
                new OwnershipAndOtherInformationSection(),
                new InsuranceInformationSection(),
                new BuildingSafetySection(),
                new AddendumProjectInformationSection()
            }
            .AsReadOnly();
    }
}