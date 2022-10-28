namespace CondoQuestionnaire.Core.CondoQuestionnaire.AddendumBuildingSafety;

public class AnticipatedThatViolationsWillBeRemedied
{
    public QuestionType Type => QuestionType.Boolean;

    public string Label =>
        "Is it anticipated the project will, in the future, have such violation(s)?";
    
    public string Code => "G9:Q5";
}