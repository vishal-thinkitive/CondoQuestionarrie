namespace CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabbedResponses;

public class ConvertedPropertyReplacementReservesAllocated : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are replacement reserves allocated for all capital improvements? ";
    public string Code => "G3:Q2:2F";
}