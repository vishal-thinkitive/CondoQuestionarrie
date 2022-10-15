namespace CondoQuestionnaire.Core.CondoQuestionnaire.FinancialInformation.MortgageeResponsibleForPayingAssessmentsOptions;

public class MortgageeResponsibleForPayingAssessmentsMoreThan12MonthsOption : IQuestionOption
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "More than 12 months";
    public string Code => "G4:Q2:O3";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}