namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;

public class HoaDidReserveStudyInTheLast3Years : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Has the HOA/Cooperative Corporation had a reserve study completed on the project within the past 3 years?";
    public string Code => "G9:Q8";
}