namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;

public class CurrentReserveAccountBalance : IQuestion
{
    public QuestionType Type => QuestionType.Money;
    public string Label => "What is the total of the current reserve account balance(s)?";
    public string Code => "G9:Q9";
}