namespace CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabbedResponses;

public class ConvertedPropertyLicensedEngineerStructurallySound : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Does the report from the licensed engineer indicate that the project is structurally sound, and that the condition and remaining useful life of the project’s major components are sufficient?";
    public string Code => "G3:Q2:2D";
}