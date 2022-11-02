using CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation.UnitsLocatedInFloodZoneOptions;

namespace CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation;

public class UnitsLocatedInFloodZone : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are units or common elements located in a flood zone?";
    public string Code => "G6:Q1";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public UnitsLocatedInFloodZone()
    {
        SubQuestions = new List<IQuestion>
        {
            new UnitsLocatedInFloodZoneSelection()
        }.AsReadOnly();
    }
}