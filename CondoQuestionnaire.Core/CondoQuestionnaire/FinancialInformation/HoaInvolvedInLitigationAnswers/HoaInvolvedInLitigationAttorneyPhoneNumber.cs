namespace CondoQuestionnaire.Core.CondoQuestionnaire.FinancialInformation.HoaInvolvedInLitigationAnswers;

public class HoaInvolvedInLitigationAttorneyPhoneNumber : IQuestionOption
{
    public QuestionType Type => QuestionType.PhoneNumber;
    public string Label => "Attorney Phone Number:";
    public string Code => "G4:Q3:O2";
    public IEnumerable<IQuestion> AttachedQuestions => Enumerable.Empty<IQuestion>();
}