namespace CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabbedResponses;

public class ConvertedPropertyReservesSufficient : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are the project’s reserves sufficient to fund the improvements? ";
    public string Code => "G3:Q2:2G";
}