namespace CondoQuestionnaire.Shared.Questionnaire.OwnershipAndOtherInformation;

public class OwnershipAndOtherInformationSection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Ownership & Other Information";
    public string Code => "G5";
    
    public IEnumerable<IQuestion> Questions { get; }

    public OwnershipAndOtherInformationSection()
    {
        Questions = new List<IQuestion>
        {
            new InformationRegardingOwnershipOfUnits(),
            new UnitsOwnedByTheSameIndividual(),
            new UnitOwnersHaveSoleOwnershipInterestUseCommonAreas(),
            new UnitsUsedForNonResidentialOrCommercialSpace(),
            new TotalSquareFootageOfCommercialSpace()
        }.AsReadOnly();
    }
}