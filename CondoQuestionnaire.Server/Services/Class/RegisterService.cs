using CondoQuestionnaire.Server.DataModel;
using CondoQuestionnaire.Server.DataModel.Model;
using CondoQuestionnaire.Server.Services.Interface;

namespace CondoQuestionnaire.Server.Services.Class
{
    public class RegisterService : BaseService, IRegisterService
    {
        public async Task<bool> RegisterUser(Register registerUser)
        {
            try
            {
                registerUser.Password = Encrypt(Encrypt(registerUser.Password));
                var result = await RepositoryFactory.RegisterRepository.RegisterUser(registerUser);
                if (result)
                {
                    await SendMail(registerUser);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task SendMail(Register user)
        {
            var body = 
                "<h2>Hi," +
                user.Name + //User name 
                "</h2>" +
                "Please verify your mail!<br/>" + //Email body text
                "<a href=\"" +
                "https://localhost:7094/verifyEmail/" + //Pur here Url from AppSetting 
                user.Email +
                "\"> <button type=\"submit\"> Verify </button> </a>";
            var subject = "Yerify your email";
            
            var request = new MailRequest
            {
                ToEmail = user.Email,
                Subject = subject,
                Body = body
            };

            var mailService = new MailService();
            await mailService.SendEmailAsync(request);
        }

        public async Task<bool> VerifyEmail(string email)
        {
            try
            {
                var result = await RepositoryFactory.UserRepository.GetUserByEmail(email);
                if (result is not null)
                {
                    result.IsRegistered = true;
                    
                    await RepositoryFactory.UserRepository.UpdateUserByEmail(email, result);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
