using Condo_Questionnaire.Client.Models;
using IronPdf;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Condo_Questionnaire.Client.Services
{
    public interface IUserService
    {
        User User { get; }
        bool RegisterUser { get; set; }
        Task Initialize();
        Task LogIn(LogIn model);
        Task LogOut();
        Task Register(Register model);
        Task GetUser();
        void CreatePDF(Instructions instructions);
        Task Submit(Questionnaire questionnaire);

    }

    public class UserService : IUserService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private string _userKey = "user";
        private string _loggedInUserKey = "loggedInUser";

        public User User { get; private set; }

        public bool RegisterUser { get; set; } = false;

        public List<User> UserList { get; private set; }

        public UserService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService)
        {
            UserList = new List<User>();
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task LogIn(LogIn model)
        {
            var logInRes = await _httpService.Post<LogInRes>("login", model);
            await _localStorageService.SetItem(_userKey, logInRes);
            await GetUser();
        }

        public async Task GetUser()
        {
            try
            {
                var userRes = await _httpService.Get<UserRes>("loggedInUser");
                if (userRes != null)
                {
                    await _localStorageService.SetItem(_loggedInUserKey, userRes);

                    User = new User();

                    User.Email = userRes.data.Email;
                    User.UserName = userRes.data.Name;
                    
                    _navigationManager.NavigateTo("/questionnaire");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task LogOut()
        {
            User = null;
            await _localStorageService.RemoveItem(_loggedInUserKey);
            _navigationManager.NavigateTo("/");
        }

        public async Task Register(Register model)
        {
            await _httpService.Post("register", model);
            RegisterUser = false;
        }

        public async Task Initialize()
        {
            var tempUser = await _localStorageService.GetItem<UserRes>(_loggedInUserKey);
            if (tempUser is not null)
            {
                User = new User();
                User.UserName = tempUser.data.Name;
                User.Email = tempUser.data.Email;
            }
        }

        public void CreatePDF(Instructions instructions)
        {
            var htmlToPdf = new HtmlToPdf();
            var file = htmlToPdf.RenderHtmlFileAsPdf("sample.html");
            var form = file.Form;

            form.Fields[0].Value = instructions.formDueDate;
            form.Fields[1].Value = instructions.lenderName;
            form.Fields[2].Value = instructions.lenderPhoneNumber;
            form.Fields[3].Value = instructions.contactName;
            form.Fields[4].Value = instructions.lenderFaxNumber;
            form.Fields[5].Value = instructions.lenderAddress;
            form.Fields[6].Value = instructions.lenderAddress;

            file.SaveAs("demores5.pdf");
        }

        public async Task Submit(Questionnaire questionnaire)
        {
            var questionnaireRes = await _httpService.Post<object>("questionnaire", questionnaire);

        }
    }
}