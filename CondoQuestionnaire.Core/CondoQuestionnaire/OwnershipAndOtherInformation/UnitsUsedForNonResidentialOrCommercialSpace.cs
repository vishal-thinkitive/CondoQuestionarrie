namespace CondoQuestionnaire.Core.CondoQuestionnaire.OwnershipAndOtherInformation;

public class UnitsUsedForNonResidentialOrCommercialSpace : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Are any units or any part of the building used for non-residential or commercial space?";
    public string Code => "G5:Q4";
}