using CondoQuestionnaire.Server.DataModel;
using CondoQuestionnaire.Server.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Tests.TestAPI
{
    public class TestUserRegister
    {
        IServiceFactory _serviceFactory = new ServiceFactory();
        [Test]
        public async Task CheckUserRegister_WithRequiredFields()
        {
            //Arrange
            var register = new Register
            {
                Name = "Hello",
                Email = "hello@gmail.com",
                Password = "Hello@1234",
            };

            //Act
            var result = await _serviceFactory.RegisterService.RegisterUser(register);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public async Task CheckUserRegister_WithoutRequiredFields()
        {
            //Arrange
            var register = new Register
            {
                Name = "Hello",
                Email = "hello@gmail.com",
                
            };

            //Act
            var result = await _serviceFactory.RegisterService.RegisterUser(register);

            //Assert
            Assert.IsFalse(result);

        }
        [Test]
        public async Task ShouldVerifyEmail()
        {
            //Arrange
            string email = "";

            //Act
            var result = await _serviceFactory.RegisterService.VerifyEmail(email);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
