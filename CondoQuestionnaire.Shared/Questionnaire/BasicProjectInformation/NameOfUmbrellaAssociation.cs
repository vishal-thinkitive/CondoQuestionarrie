namespace CondoQuestionnaire.Shared.Questionnaire.BasicProjectInformation;

public class NameOfUmbrellaAssociation : IQuestion
{
    public QuestionType Type => QuestionType.String;
    public string Label => "Name of Master or Umbrella Association (if applicable)";
    public string Code => "G1:Q7";
}