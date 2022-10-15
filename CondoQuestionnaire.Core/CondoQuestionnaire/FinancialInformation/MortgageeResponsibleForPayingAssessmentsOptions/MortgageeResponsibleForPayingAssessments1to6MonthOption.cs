namespace CondoQuestionnaire.Core.CondoQuestionnaire.FinancialInformation.MortgageeResponsibleForPayingAssessmentsOptions;

public class MortgageeResponsibleForPayingAssessments1To6MonthOption : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "1 to 6 months";
    public string Code => "G4:Q2:O1";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}