namespace CondoQuestionnaire.Core.CondoQuestionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabedResponses;

public class ConvertedPropertyYearConverted : IQuestion
{
    public QuestionType Type => QuestionType.YearOnly;
    public string Label => "In what year was the property converted?";
    public string Code => "G3:Q2:2B";
}