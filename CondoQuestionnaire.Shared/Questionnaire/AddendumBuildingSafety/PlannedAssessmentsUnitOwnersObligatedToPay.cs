using CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.PlannedAssessmentsUnitOwnersObligatedToPaySupport;

namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;

public class PlannedAssessmentsUnitOwnersObligatedToPay : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are there any planned special assessments that unit owners/ cooperative shareholders will be obligated to pay?";
    public string Code => "G9:Q11";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public PlannedAssessmentsUnitOwnersObligatedToPay()
    {
        SubQuestions = new List<IQuestion>
        {
            new PlannedAssessmentsUnitOwnersObligatedToPayTotal(),
            new PlannedAssessmentsUnitOwnersObligatedToPayTerms(),
            new PlannedAssessmentsUnitOwnersObligatedToPayPurpose()
        }.AsReadOnly();
    }
}