using CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;
using CondoQuestionnaire.Shared.Questionnaire.AddendumInformation;
using CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation;
using CondoQuestionnaire.Shared.Questionnaire.FinancialInformation;
using CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation;
using CondoQuestionnaire.Shared.Questionnaire.LenderInformation;
using CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation;
using CondoQuestionnaire.Shared.Questionnaire.OwnershipAndOtherInformation;
using CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation;

namespace CondoQuestionnaire.Shared.Questionnaire;

public class CondoLenderQuestionProvider
{
    private IEnumerable<IQuestionGroup> Groups;

    public CondoLenderQuestionProvider()
    {
        Groups = new List<IQuestionGroup>
        {
            new LenderInformationSection(),
            new BasicProjectInformationSection(),
            new ProjectCompletionInformationSection(),
            new NewlyConvertedOrRehabilitatedProjectInformationSection(),
            new FinancialInformationSection(),
            new OwnershipAndOtherInformationSection(),
            new InsuranceInformationSection(),
            new BuildingSafetySection(),
            new AddendumProjectInformationSection(),
        };
    }
}