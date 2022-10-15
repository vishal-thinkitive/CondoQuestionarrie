namespace CondoQuestionnaire.Core.CondoQuestionnaire.OwnershipAndOtherInformation;

public class TotalSquareFootageOfCommercialSpace : IQuestion
{
    public QuestionType Type => QuestionType.LabelOnly;
    public string Label => "What is the total square footage of commercial space in the building that is separate from the residential HOA? Include above and below grade space used for commercial purposes, such as public parking facilities, retail space, apartments, commercial offices, and so on.";
    public string Code => "G5:Q5";
}