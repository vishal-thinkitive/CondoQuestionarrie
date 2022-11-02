namespace CondoQuestionnaire.Shared.Questionnaire.AddendumBuildingSafety;

public class BuildingSafetySection : IQuestionGroup
{
    public IQuestionGroup? Parent => null;
    public string Label => "Building Safety, Soundness, Structural Integrity, and Habitability";
    public string Code => "G9";
    
    public IEnumerable<IQuestion> Questions { get; }

    public BuildingSafetySection()
    {
        Questions = new List<IQuestion>
        {
            new BuildingLastInspected(),
            new FindingsOnLastInspection(),
            new HoaAwareOfDeficiencies(),
            new OutStandingViolationsRegardingIntegrity(),
            new AnticipatedThatViolationsWillBeRemedied(),
            new FundingAvailableForRepairs(),
            new ProjectHasScheduleForDeferredMaintenance(),
            new HoaDidReserveStudyInTheLast3Years(),
            new CurrentReserveAccountBalance(),
            new CurrentAssessmentUnitOwnersObligatedToPay(),
            new PlannedAssessmentsUnitOwnersObligatedToPay(),
            new HoaObtainedAnyLoansToFinanceImprovements()
        }.AsReadOnly();
    }
}