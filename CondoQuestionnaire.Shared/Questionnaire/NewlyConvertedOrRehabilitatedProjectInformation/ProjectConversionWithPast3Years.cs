using CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation.NewlyRehabbedResponses;

namespace CondoQuestionnaire.Shared.Questionnaire.NewlyConvertedOrRehabilitatedProjectInformation;

public class ProjectConversionWithPast3Years : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Is the project a conversion within the past 3 years of an existing structure that was used as an apartment, hotel/resort, retail or professional business, industrial or for other non-residential use?";
    public string Code => "G3:Q1";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public ProjectConversionWithPast3Years()
    {
        SubQuestions = new List<IQuestion>
        {
            new ConvertedPropertyYearBuild(),
            new ConvertedPropertyYearConverted()
        }.AsReadOnly();
    }
}