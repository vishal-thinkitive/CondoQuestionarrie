namespace CondoQuestionnaire.Core.CondoQuestionnaire.FinancialInformation.MortgageeResponsibleForPayingAssessmentsOptions;

public class MortgageeResponsibleForPayingAssessments7To12MonthOption : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "7 to 12 months";
    public string Code => "G4:Q2:O2";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}