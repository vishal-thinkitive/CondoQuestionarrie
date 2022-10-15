namespace CondoQuestionnaire.Core.CondoQuestionnaire.FinancialInformation;

public class HoaInvolvedInLitigation : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Is the HOA involved in any active or pending litigation? ";
    public string Code => "G4:Q3";
}