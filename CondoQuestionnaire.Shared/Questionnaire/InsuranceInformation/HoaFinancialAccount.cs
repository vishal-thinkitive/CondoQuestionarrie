using CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation.HoaFinancialAccountOptions;

namespace CondoQuestionnaire.Shared.Questionnaire.InsuranceInformation;

public class HoaFinancialAccount : IQuestion
{
    public QuestionType Type => QuestionType.MultiSelect;
    public string Label => "Check all of the following that apply regarding HOA financial accounts:";
    public string Code => "G6:Q2";
    public IEnumerable<IQuestion> SubQuestions { get; }

    public HoaFinancialAccount()
    {
        SubQuestions = new List<IQuestion>
        {
            new HoaFinancialAccountOptionsHoaMaintainsSeparateAccounts(),
            new HoaFinancialAccountOptionsAppropriateAccessControls(),
            new HoaFinancialAccountOptionsBankMonthlyStatements(),
            new HoaFinancialAccountOptions2DirectorsRequiredToSignChecks(),
            new HoaFinancialAccountOptionsManagementCompanyMaintainsSeparateRecords(),
            new HoaFinancialAccountOptionsManagementCompanyCannotWithdrawFromReserve()
        }.AsReadOnly();
    }
}