using CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation.ProjectIncompleteItems;

namespace CondoQuestionnaire.Shared.Questionnaire.ProjectCompletionInformation;

public class ProjectCompletedConfirmation : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Is the project 100% complete, including all construction or renovation of units, common elements, and shared amenities for all project phases?";

    public string Code => "G2:Q1";

    public IEnumerable<IQuestion> SubQuestions { get; }

    public ProjectCompletedConfirmation()
    {
        SubQuestions = new List<IQuestion>
        {
            new IncompleteProjectAdditionalPhasing(),
            new IncompleteProjectLegallyPhased(),
            new IncompleteProjectNumberOfCompletedPhases(),
            new IncompleteProjectNumberOfLegallyPlannedPhases(),
            new IncompleteProjectNumberOfPlannedUnits(),
            new IncompleteProjectAmenitiesComplete()
        }.AsReadOnly();
    }
}