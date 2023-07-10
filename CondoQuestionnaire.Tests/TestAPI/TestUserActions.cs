using CondoQuestionnaire.Server.Controllers.V1._0;
using CondoQuestionnaire.Server.DataModel;
using CondoQuestionnaire.Server.DataModel.JWT;
using CondoQuestionnaire.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Tests.TestAPI
{
    public class TestUserActions
    {
        private JwtSettings _jwtSettings;
        private IServiceFactory _serviceFactory;
        
        private UserController _userController;
        private DefaultHttpContext httpContext;
        private Register expectedUser;

        [SetUp]
        public void SetUp()
        {
         _serviceFactory = new ServiceFactory();
        _jwtSettings = new JwtSettings()
            {
                IssuerSigningKey = "64A63153-11C1-4919-9133-EFAF99A9B456"
            };
            httpContext = new DefaultHttpContext();
            _userController = new UserController(_jwtSettings)
            {
                ControllerContext = new ControllerContext()
                {
                    HttpContext = httpContext
                }
            };


            expectedUser = new Register
            {
                Name = "Test1234",
                Email = "Test1234@gmail.com",
                Password = "Test@1234", 
                PaymentDone = true,
                IsRegistered = false
            };

        }


        [Test]
        public async Task GetUserByToken_WithValidToken_ReturnsUser()
        {
            //Arrange
            httpContext.Request.Headers["Authorization"] = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiVGVzdDEyMzRAZ21haWwuY29tIiwiZW1haWwiOiJUZXN0MTIzNEBnbWFpbC5jb20iLCJuYW1laWQiOiIwZGY3M2NlMS1iYzA3LTRiN2EtODgxMi1iOWM2MDJmYWNmNWEiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiJKdWwgTW9uIDEwIDIwMjMgMTI6MjA6NTcgUE0iLCJuYmYiOjE2ODg5NjgyNTcsImV4cCI6MTY4ODk3MTg1NywiaWF0IjoxNjg4OTY4MjU3LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjcxODIiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OioifQ.NdJBZehLZUBHevpREfE_FuKROJ1DqwrhCWFHU_cDjME";

            // Act
            var result = await _userController.GetUserByToken();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedUser.Name, result.Name);
            Assert.AreEqual(expectedUser.Email, result.Email);
            Assert.AreEqual(expectedUser.PaymentDone, result.PaymentDone);
            Assert.AreEqual(expectedUser.IsRegistered, result.IsRegistered);
        }



        [Test]
        public async Task GetUserByToken_WithInvalidToken_ReturnsUnauthorized()
        {
            // Arrange
            httpContext.Request.Headers["Authorization"] = "invalid token";

            // Assert
            Assert.That(async () => await _userController.GetUserByToken(), Throws.TypeOf<ArgumentException>());
        }


        [Test]
        public async Task ShouldGetLoggedInUsers()
        {
            //Arrange
            httpContext.Request.Headers["Authorization"] = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiVGVzdDEyMzRAZ21haWwuY29tIiwiZW1haWwiOiJUZXN0MTIzNEBnbWFpbC5jb20iLCJuYW1laWQiOiIwZGY3M2NlMS1iYzA3LTRiN2EtODgxMi1iOWM2MDJmYWNmNWEiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiJKdWwgTW9uIDEwIDIwMjMgMTI6MjA6NTcgUE0iLCJuYmYiOjE2ODg5NjgyNTcsImV4cCI6MTY4ODk3MTg1NywiaWF0IjoxNjg4OTY4MjU3LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjcxODIiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OioifQ.NdJBZehLZUBHevpREfE_FuKROJ1DqwrhCWFHU_cDjME";

            // Act
            var result = await _userController.GetLoggedInUsers() as OkObjectResult;

            //Assert
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.AreEqual("User data fetched successfully", okResult.Value.GetType().GetProperty("message").GetValue(okResult.Value, null));

            var data = okResult.Value.GetType().GetProperty("data").GetValue(okResult.Value, null);
            Assert.NotNull(data);
            Assert.AreEqual(expectedUser.Name, data.GetType().GetProperty("Name").GetValue(data, null).ToString());
            Assert.AreEqual(expectedUser.Email, data.GetType().GetProperty("Email").GetValue(data, null).ToString());
            Assert.AreEqual(expectedUser.PaymentDone, (bool)data.GetType().GetProperty("PaymentDone").GetValue(data, null));

        }

        [Test]
        public async Task ShouldGetAllUsers()
        {
            //Arrange
            var register = new Register
            {
                Name = "Hello",
                Email = "hello@gmail.com",
                Password = "Hello@1234",
            };
            await _serviceFactory.RegisterService.RegisterUser(register);

            //Act
            var userList = await _serviceFactory.UserService.GetAllUsers();
            var data = userList.FirstOrDefault(x => x.Name == register.Name);
          
            //Assert
            Assert.IsNotNull(data);
            Assert.AreEqual(register.Name, data.Name);

        }
        

        [Test]
        public async Task CheckGetUserByEmail_withValidEmail()
        {
            //Arrange
            string email = "Test1234@gmail.com";

            //Act
            var user = await _serviceFactory.UserService.GetUserByEmail(email);

            //Assert

            Assert.IsNotNull(user);
            Assert.AreEqual(email, user.Email);

        }

        [Test]
        public async Task CheckGetUserByEmail_withInvalidEmail()
        {
            //Arrange
            string email = "Test@gmail.com";

            //Act
            var user = await _serviceFactory.UserService.GetUserByEmail(email);

            //Assert

            Assert.IsNotNull(user);
            Assert.AreNotEqual(email, user.Email);

        }

        [Test]
        public async Task CheckUpdateUser_WithValidEmail()
        {
            //Arrange
            string email = "Test1234@gmail.com";

            var user = await _serviceFactory.UserService.GetUserByEmail(email);

            //Act
            var result = _serviceFactory.UserService.UpdateUserByEmail(email, user);

            //Assert
            Assert.IsNotNull(result);

        }

       



    }
}