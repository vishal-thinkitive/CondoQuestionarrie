using CondoQuestionnaire.Server.Controllers.V1._0;
using CondoQuestionnaire.Server.DataModel.JWT;
using CondoQuestionnaire.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Tests.TestAPI
{
    public class TestQuestionnaire
    {

        private JwtSettings _jwtSettings;
        private IServiceFactory _serviceFactory;

        private QuestionnaireController _questionnaireController;
        private DefaultHttpContext httpContext;

        [SetUp]
        public void SetUp()
        {
            _serviceFactory = new ServiceFactory();
            _jwtSettings = new JwtSettings()
            {
                IssuerSigningKey = "64A63153-11C1-4919-9133-EFAF99A9B456"
            };
            httpContext = new DefaultHttpContext();
            _questionnaireController = new QuestionnaireController(_jwtSettings)
            {
                ControllerContext = new ControllerContext()
                {
                    HttpContext = httpContext
                }
            };

        }

        //[Test]
        //public async Task ShouldQuestionnaire()
        //{
        //    //Arrange
        //    httpContext.Request.Headers["Authorization"] = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiVGVzdDEyMzRAZ21haWwuY29tIiwiZW1haWwiOiJUZXN0MTIzNEBnbWFpbC5jb20iLCJuYW1laWQiOiIxY2I0MDJhOC0xODYzLTRlZTUtYjEyOC03ZmJiMzUzN2U3YWYiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiJKdWwgVGh1IDA2IDIwMjMgMTY6NDQ6MDIgUE0iLCJuYmYiOjE2ODg2Mzg0NDIsImV4cCI6MTY4ODY0MjA0MiwiaWF0IjoxNjg4NjM4NDQyLCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjcxODIiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OioifQ.yVuys5bHqMUNBXjvrW2fO9gXUh1wifCr0HbZQgsqEvE";

        //    //Act
        //    var result = _questionnaireController.Questionnaire();

        //    //Assert
        //    Assert.IsNotNull(result);

        //}

        [Test]
        public async Task GetUserByToken_WithValidToken_ReturnsUser()
        {
            //Arrange
            httpContext.Request.Headers["Authorization"] = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiVGVzdDEyMzRAZ21haWwuY29tIiwiZW1haWwiOiJUZXN0MTIzNEBnbWFpbC5jb20iLCJuYW1laWQiOiIxY2I0MDJhOC0xODYzLTRlZTUtYjEyOC03ZmJiMzUzN2U3YWYiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiJKdWwgVGh1IDA2IDIwMjMgMTY6NDQ6MDIgUE0iLCJuYmYiOjE2ODg2Mzg0NDIsImV4cCI6MTY4ODY0MjA0MiwiaWF0IjoxNjg4NjM4NDQyLCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjcxODIiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OioifQ.yVuys5bHqMUNBXjvrW2fO9gXUh1wifCr0HbZQgsqEvE";

            // Act
            var result = await _questionnaireController.GetUserByToken();

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
