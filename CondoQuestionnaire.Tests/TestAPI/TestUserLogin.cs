using CondoQuestionnaire.Server.Controllers.V1._0;
using CondoQuestionnaire.Server.DataModel;
using CondoQuestionnaire.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Threading.Tasks;
using CondoQuestionnaire.Server.DataModel.JWT;

namespace CondoQuestionnaire.Tests.TestAPI
{
    [TestFixture]
    public class TestUserLogin
    {
        private JwtSettings _jwtSettings;

        IServiceFactory _serviceFactory = new ServiceFactory();

        [Test]
        public async Task CheckUserLogin_ForValidCredentials()
        {
            //Arrange
            var login = new LogIn
            {
                UserName = "Test1234@gmail.com",
                Password = "Test@1234",
            };

            //Act

            var result = await _serviceFactory.LogInService.LogInUser(login);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result);


        }


        [Test]
        public async Task CheckUserLogin_ForInvalidCredentials()
        {
            //Arrange
            var login = new LogIn
            {
                UserName = "Test@gmail.com",
                Password = "Test@12",
            };

            //Act

            var result = await _serviceFactory.LogInService.LogInUser(login);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result);

        }

        [Test]
        public async Task IfUserLogOut()
        {
            // Arrange
            var _logInController = new LogInController(_jwtSettings);

            // Act
            var result = await _logInController.LogOut() as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
            Assert.AreEqual("Logged out successfully", result.Value.GetType().GetProperty("value")?.GetValue(result.Value));

        }



    }

}
