namespace CondoQuestionnaire.Shared.Questionnaire.OwnershipAndOtherInformation;

public class TotalSquareFootageOfCommercialSpaceEntry : IQuestion
{
    public QuestionType Type => QuestionType.Number;
    public string Label => "Total square footage of commercial space:";
    public string Code => "G5:Q5:O1";
}