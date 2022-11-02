namespace CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabbedResponses;

public class ConvertedPropertyYearConverted : IQuestion
{
    public QuestionType Type => QuestionType.YearOnly;
    public string Label => "In what year was the property converted?";
    public string Code => "G3:Q2:2B";
}