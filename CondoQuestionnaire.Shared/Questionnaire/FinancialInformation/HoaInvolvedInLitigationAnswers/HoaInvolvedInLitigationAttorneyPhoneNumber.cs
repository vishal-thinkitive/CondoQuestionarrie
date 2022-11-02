namespace CondoQuestionnaire.Shared.Questionnaire.FinancialInformation.HoaInvolvedInLitigationAnswers;

public class HoaInvolvedInLitigationAttorneyPhoneNumber : IQuestion
{
    public QuestionType Type => QuestionType.PhoneNumber;
    public string Label => "Attorney Phone Number:";
    public string Code => "G4:Q3:O2";
    
}