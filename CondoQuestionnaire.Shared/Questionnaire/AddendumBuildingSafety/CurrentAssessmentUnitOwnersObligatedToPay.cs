using CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.CurrentAssessmentUnitOwnersObligatedToPaySupport;

namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;

public class CurrentAssessmentUnitOwnersObligatedToPay : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are there any current special assessments unit owners/ cooperative shareholders are obligated to pay?";
    public string Code => "G9:Q10";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public CurrentAssessmentUnitOwnersObligatedToPay()
    {
        SubQuestions = new List<IQuestion>
        {
            new CurrentAssessmentUnitOwnersObligatedToPayTotal(),
            new CurrentAssessmentUnitOwnersObligatedToPayTerms(),
            new CurrentAssessmentUnitOwnersObligatedToPurpose()
        }.AsReadOnly();
    }
}