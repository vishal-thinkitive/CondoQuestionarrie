namespace CondoQuestionnaire.Core.CondoQuestionnaire.OwnershipAndOtherInformation;

public class UnitOwnersHaveSoleOwnershipInterestUseCommonAreas : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Do the unit owners have sole ownership interest in and the right to use the project amenities and common areas?";
    public string Code => "G5:Q3";
}