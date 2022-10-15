namespace CondoQuestionnaire.Core.CondoQuestionnaire.FinancialInformation.HoaInvolvedInLitigationAnswers;

public class HoaInvolvedInLitigationAttorneyName : IQuestionOption
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "Attorney Name:";
    public string Code => "G4:Q3:O1";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}