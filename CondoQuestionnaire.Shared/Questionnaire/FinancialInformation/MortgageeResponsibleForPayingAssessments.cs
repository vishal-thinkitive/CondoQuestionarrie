using CondoQuestionnaire.Shared.Questionnaire.FinancialInformation.MortgageeResponsibleForPayingAssessmentsOptions;

namespace CondoQuestionnaire.Shared.Questionnaire.FinancialInformation;

public class MortgageeResponsibleForPayingAssessments : IQuestion
{
    public QuestionType Type => QuestionType.Selection;
    public string Label => "In the event a lender acquires a unit due to foreclosure or a deed-in-lieu of foreclosure, is the mortgagee responsible for paying delinquent common expense assessments?";
    public string Code => "G4:Q2";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public string? Hint => "If Yes , for how long is the mortgagee responsible for paying common expense assessments? ( Select one)";

    public MortgageeResponsibleForPayingAssessments()
    {
        SubQuestions = new List<IQuestion>
        {
            new MortgageeResponsibleForPayingAssessments1To6MonthOption(),
            new MortgageeResponsibleForPayingAssessments7To12MonthOption(),
            new MortgageeResponsibleForPayingAssessmentsMoreThan12MonthsOption()
        }.AsReadOnly();
    }
}