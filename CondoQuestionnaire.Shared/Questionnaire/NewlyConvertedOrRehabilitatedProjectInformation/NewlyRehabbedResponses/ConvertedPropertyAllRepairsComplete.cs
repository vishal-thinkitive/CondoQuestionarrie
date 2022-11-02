namespace CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabbedResponses;

public class ConvertedPropertyAllRepairsComplete : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are all repairs affecting safety, soundness, and structural integrity complete?";
    public string Code => "G3:Q2:2E";
}