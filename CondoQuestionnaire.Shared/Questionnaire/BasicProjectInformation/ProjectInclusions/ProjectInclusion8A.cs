namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation.ProjectInclusions;

public class ProjectInclusion8A : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Hotel/motel/resort activities, mandatory or voluntary rental-pooling arrangements, or other restrictions on the unit owner's ability to occupy the unit";

    public string Code => "G1:Q8:8A";
}