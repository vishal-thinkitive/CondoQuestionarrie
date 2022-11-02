using CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety.AnticipatedThatViolationsWIllBeRemediedSupport;

namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;

public class AnticipatedThatViolationsWillBeRemedied : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Is it anticipated the project will, in the future, have such violation(s)?";
    
    public string Code => "G9:Q5";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public AnticipatedThatViolationsWillBeRemedied()
    {
        SubQuestions = new List<IQuestion>
        {
            new AnticipatedThatViolationsWillBeRemediedAdditional()
        }.AsReadOnly();
    }
}