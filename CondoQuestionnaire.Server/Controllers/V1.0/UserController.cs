using CondoQuestionnaire.Server.DataModel;
using CondoQuestionnaire.Server.DataModel.JWT;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using CondoQuestionnaire.Server.Helper;
using CondoQuestionnaire.Server.Services;

namespace CondoQuestionnaire.Server.Controllers.V1._0
{
    [Route("api/{version:apiVersion}")]
    [ApiVersion("1")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceFactory ServiceFactory;
        private readonly JwtSettings jwtSettings;

        public UserController(JwtSettings jwtSettings)
        {
            ServiceFactory = new ServiceFactory();
            this.jwtSettings = jwtSettings;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult> GetAllUsers()
        {
            try
            {
                var userList = await ServiceFactory.UserService.GetAllUsers();
                if(userList is not null)
                {
                    return Ok(new {message = "User data fetched successfully", data = userList.Select(x=> new { x.Name, x.Email}) });
                }
                else
                {
                    throw new Exception("user data not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error occured while fetching users",error = ex.Message });
            }
        }
        
        [HttpGet("loggedInUser")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult> GetLoggedInUsers()
        {
            try
            {
                var user = await GetUserByToken();
                if (user is not null)
                {
                    return Ok(new {message = "User data fetched successfully", data = new { user.Name, user.Email, user.PaymentDone} });
                }
                else
                {
                    throw new Exception("user data not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error occured while fetching users",error = ex.Message });
            }
        }

        [HttpGet("{email}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult> GetUserBymail(string email)
        {
            try
            {
                var user = await ServiceFactory.UserService.GetUserByEmail(email);
                if(user is not null)
                {
                    return Ok(new 
                    {
                        message = "User data fetched successfully", 
                        data = new { user.Name, user.Email, user.PaymentDone} 
                    });
                }
                else
                {
                    throw new Exception("user data not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error occured while fetching users",error = ex.Message });
            }
        }


        [HttpPut("update/{email}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult> UpdateUser(string email)
        {
            try
            {
                var user = await ServiceFactory.UserService.GetUserByEmail(email);

                var stream = new StreamReader(Request.Body);
                var updateJson = await stream.ReadToEndAsync();
                var updateJObject = JObject.Parse(updateJson);

                var isUpdate = ConversionHelper.PathchObject(updateJObject, user);
                if (isUpdate)
                {
                    var result = await ServiceFactory.UserService.UpdateUserByEmail(email, user);
                    if (result)
                    {
                        return Ok(new { message = "User data updated successfully" });
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    return Ok(new { message = "User data is up to date!" });

                }

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error occured while fetching users", error = ex.Message });
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
