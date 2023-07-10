using CondoQuestionnaire.Server.DataModel.JWT;
using CondoQuestionnaire.Server.DataModel;
using CondoQuestionnaire.Server.DataModel.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using CondoQuestionnaire.Server.Helper;
using CondoQuestionnaire.Server.Services;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Server.Controllers.V1._0
{
    [Route("api/{version:apiVersion}")]
    [ApiVersion("1.0")]
    [ApiController]
    public class QuestionnaireController : ControllerBase
    {
        private readonly IServiceFactory ServiceFactory;
        private readonly JwtSettings jwtSettings;

        public QuestionnaireController(JwtSettings jwtSettings)
        {
            ServiceFactory = new ServiceFactory();
            this.jwtSettings = jwtSettings;
        }

        [HttpPost]
        [Route("questionnaire")]
        public async Task<ActionResult> Questionnaire()
        {
            try
            {

                var stream = new StreamReader(Request.Body);
                var json = await stream.ReadToEndAsync();
                var jsonObject = JObject.Parse(json);


                var questionnaire = jsonObject.ToObject<CondoQuestionnaireApplication>();

                var user = await GetUserByToken();
                if(user != null)
                {
                    var pdfName = QuestionnaireHelper.CreateQuestionnaireForm(questionnaire);
                    SignMailHelper.SendSignMail(pdfName, user.Name ,user.Email, "nilesh.patil@thinkitive.com", "Nilesh Patil");
                }

                return Ok(new { message = "PDF created!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error occured!", error = ex.Message });
            }
        }


        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<Register?> GetUserByToken()
        {
            var tokenValue = Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value;

            var tempToken = tokenValue.ToString().Split(' ');

            string token = tempToken.LastOrDefault();

            if (token is not null)
            {
                var principal = JwtHelpers.GetPrincipalFromExpiredToken(token, jwtSettings);
                if (principal is not null
                    && principal.Identity is not null
                    && principal.Identity.Name is not null)
                {
                    var email = principal.Identity.Name;
                    var user = await ServiceFactory.UserService.GetUserByEmail(email);
                    if (user is not null)
                    {
                        return user;
                    }

                }
            }

            return null;
        }
    }
}
