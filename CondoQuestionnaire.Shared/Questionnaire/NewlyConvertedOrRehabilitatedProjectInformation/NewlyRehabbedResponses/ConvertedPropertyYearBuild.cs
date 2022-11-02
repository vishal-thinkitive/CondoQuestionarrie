namespace CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabbedResponses;

public class ConvertedPropertyYearBuild : IQuestion
{
    public QuestionType Type => QuestionType.YearOnly;
    public string Label => "In what year was the property built?";
    public string Code => "G3:Q2:2A";
}