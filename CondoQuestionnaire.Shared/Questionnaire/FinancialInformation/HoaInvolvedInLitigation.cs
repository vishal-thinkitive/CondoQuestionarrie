using CondoQuestionnaire.Shared.Questionnaire.FinancialInformation.HoaInvolvedInLitigationAnswers;

namespace CondoQuestionnaire.Shared.Questionnaire.FinancialInformation;

public class HoaInvolvedInLitigation : IQuestion
{
    public QuestionType Type => QuestionType.Boolean;
    public string Label => "Is the HOA involved in any active or pending litigation?";
    public string Hint => "If Yes , attach documentation regarding the litigation from the attorney or the HOA. Provide the attorney’s name and contact information:";
    public string Code => "G4:Q3";

    public IEnumerable<IQuestion> SubQuestions { get; }

    public HoaInvolvedInLitigation()
    {
        SubQuestions = new List<IQuestion>
        {
            new HoaInvolvedInLitigationAttorneyName(),
            new HoaInvolvedInLitigationAttorneyPhoneNumber()
        }.AsReadOnly();
    }
}