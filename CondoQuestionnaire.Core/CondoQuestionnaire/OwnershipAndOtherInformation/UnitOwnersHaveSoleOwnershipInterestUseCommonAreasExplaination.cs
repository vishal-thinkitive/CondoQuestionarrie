namespace CondoQuestionnaire.Core.CondoQuestionnaire.OwnershipAndOtherInformation;

public class UnitOwnersHaveSoleOwnershipInterestUseCommonAreasExplanation : IQuestion
{
    public QuestionType Type => QuestionType.Text;

    public string Label =>
        "If No , explain who has ownership interest in and rights to use the project amenities and common areas:";

    public string Code => "G5:Q3:O1";
}