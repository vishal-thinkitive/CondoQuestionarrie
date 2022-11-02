namespace CondoQuestionnaire.Shared.Questionnaire.FinancialInformation.HoaInvolvedInLitigationAnswers;

public class HoaInvolvedInLitigationAttorneyName : IQuestion
{
    public QuestionType Type => QuestionType.Text;
    public string Label => "Attorney Name:";
    public string Code => "G4:Q3:O1";
    
}