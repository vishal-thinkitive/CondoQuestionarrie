using CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.FindingsOnLastInspectionAnswers;

namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;

public class FindingsOnLastInspection : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Did the last inspection have any findings related to the safety, soundness, structural integrity, or habitability of the project’s building(s)?";
    public string Code => "G9:Q2";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public FindingsOnLastInspection()
    {
        SubQuestions = new List<IQuestion>
        {
            new FindingsOnLastInspectionRepairsCompleted(),
            new FindingsOnLastInspectionRepairsRemaining(),
            new FindingsOnLastInspectionRepairsProjectedCompletionDate()
        }.AsReadOnly();
    }
}