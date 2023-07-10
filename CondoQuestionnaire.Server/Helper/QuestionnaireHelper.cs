using CondoQuestionnaire.Server.DataModel.Model;
using CondoQuestionnaire.Shared.Models;
using Stubble.Core.Builders;

namespace CondoQuestionnaire.Server.Helper
{
    public static class QuestionnaireHelper
    {
        public static string CreateQuestionnaireForm(CondoQuestionnaireApplication condoQuestionnaireApplication)
        {
            var htmlTemplate = System.IO.File.ReadAllText("sample.html");
            var builder = new StubbleBuilder();
            var boundTemplate = builder.Build().Render(htmlTemplate, condoQuestionnaireApplication);

            return boundTemplate;
        }
    }
}
