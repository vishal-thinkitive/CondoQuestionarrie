namespace CondoQuestionnaire.Core.CondoQuestionnaire.InsuranceInformation;

public class HoaFinancialAccount : IQuestion
{
    public QuestionType Type => QuestionType.MultiSelect;
    public string Label => "Check all of the following that apply regarding HOA financial accounts:";
    public string Code => "G6:Q2";
}