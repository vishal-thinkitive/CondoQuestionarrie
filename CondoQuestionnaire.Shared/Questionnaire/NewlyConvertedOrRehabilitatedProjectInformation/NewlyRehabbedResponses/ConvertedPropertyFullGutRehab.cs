namespace CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabbedResponses;

public class ConvertedPropertyFullGutRehab : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Was the conversion a full gut rehabilitation of the existing structure(s), including replacement of all major mechanical components?";
    public string Code => "G3:Q2:2C";
}