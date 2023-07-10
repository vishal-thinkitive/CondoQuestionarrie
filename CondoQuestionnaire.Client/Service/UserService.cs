using CondoQuestionnaire.Client.Models;
using CondoQuestionnaire.Shared.Models;
using CondoQuestionnaire.Shared.Questionnaire;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Stripe.Checkout;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Client.Services
{
    public interface IUserService
    {
        User User { get; }
        CondoQuestionnaireApplication CondoQuestionnaireApplication { get; set; }
        bool RegisterUser { get; set; }
        Task LogIn(LogIn model);
        Task LogOut();
        Task Register(Register model);
        Task GetUser();
        Task Initialize();
        Task MakePayment(string email, double price);
        Task UpdateUser(string email, object user);
        Task UpdatePayment();
        Task Submit();

    }

    public class UserService : IUserService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private string _userKey = "user";
        private string _loggedInUserKey = "loggedInUser";
        public CondoQuestionnaireApplication CondoQuestionnaireApplication { get; set; }

        public User User { get; private set; }

        public bool RegisterUser { get; set; } = false;

        public List<User> UserList { get; private set; }


        public UserService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService)
        {
            UserList = new List<User>();
            CondoQuestionnaireApplication = new CondoQuestionnaireApplication()
            {
                Answers = new List<CondoQuestionnaireAnswer>()
            };
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task LogIn(LogIn model)
        {
            try
            {
                var logInRes = await _httpService.Post<LogInRes>("login", model);
                await _localStorageService.SetItem(_userKey, logInRes);
                await GetUser();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                    User.PaymentDone = userRes.data.PaymentDone;

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
            if (tempUser is not null && tempUser.data.Email is not null)
            {
                User = new User();
                User.UserName = tempUser.data.Name;
                User.Email = tempUser.data.Email;
                User.PaymentDone = tempUser.data.PaymentDone;
            }
        }
        public async Task MakePayment(string email, double price)
        {
            try
            {
                if (User is not null)
                {
                    var domain = "https://localhost:7094";
                    var options = new SessionCreateOptions
                    {
                        CustomerEmail = email,
                        LineItems = new List<SessionLineItemOptions>
                        {
                            new SessionLineItemOptions
                            {
                                PriceData = new SessionLineItemPriceDataOptions
                                {
                                    UnitAmount = (long)(price*100),
                                    Currency = "usd",
                                    ProductData = new SessionLineItemPriceDataProductDataOptions
                                    {
                                          Name = "Stubborn Attachments",
                                          Description="A Vision for a Society of Free, Prosperous, and Responsible Individuals : Book by Tyler Cowen",
                                    },
                                },
                                Quantity = 1,
                            },
                        },
                        Mode = "payment",
                        SuccessUrl = domain + "/PaymentDone",
                        CancelUrl = domain + "/login",
                    };

                    var service = new SessionService();
                    Session session = await service.CreateAsync(options);

                    _navigationManager.NavigateTo(session.Url);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task UpdatePayment()
        {
            if (_navigationManager.Uri.Contains("PaymentDone"))
            {
                await UpdateUser(User.Email, new { PaymentDone = true });
            }
        }

        public async Task UpdateUser(string email, object user)
        {
            await _httpService.Put("update/" + email, user);
            await GetUser();
            _navigationManager.NavigateTo("/questionnaire");
        }
        public async Task Submit()
        {
            var questionnaireRes = await _httpService.Post<object>("questionnaire", CondoQuestionnaireApplication);

        }
    }
}