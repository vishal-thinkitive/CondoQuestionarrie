using DocuSign.eSign.Client;
using Org.BouncyCastle.Cms;
using Stubble.Core.Classes;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.IO;
using static DocuSign.eSign.Client.Auth.OAuth;
using static DocuSign.eSign.Client.Auth.OAuth.UserInfo;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;
using Document = DocuSign.eSign.Model.Document;
using UserInfo = DocuSign.eSign.Client.Auth.OAuth.UserInfo;

namespace CondoQuestionnaire.Server.Helper
{
    public static class SignMailHelper
    {
        public static void SendSignMail(
            string docPdf = "pdfFile",
            string signerName = "Test name",
            string signerEmail = "pepaco1486@sopulit.com",
            string ccEmail = "abhishekchidrawar@gmail.com",
            string ccName = "")
        {

            Console.ForegroundColor = ConsoleColor.White;
            OAuthToken? accessToken = null;
            try
            {
                accessToken = AuthenticateWithJWT(
                    "ESignature",
                    "730754fc-31c6-4a67-80be-99d6de9f30d6", //ConfigurationManager.AppSettings["ClientId"], 
                    "3ec20a03-7cfc-4a5d-aeac-6d1504349321", //ConfigurationManager.AppSettings["ImpersonatedUserId"],
                    "account-d.docusign.com", //ConfigurationManager.AppSettings["AuthServer"], 
                    "private.key"); //ConfigurationManager.AppSettings["PrivateKeyFile"]);
            }
            catch (ApiException apiExp)
            {
                // Consent for impersonation must be obtained to use JWT Grant
                if (apiExp.Message.Contains("consent_required"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unable to send envelope; Exiting. Please rerun the console app once consent was provided");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(-1);
                }
            }

            var apiClient = new ApiClient();
            apiClient.SetOAuthBasePath("account-d.docusign.com");//ConfigurationManager.AppSettings["AuthServer"]);
            UserInfo userInfo = apiClient.GetUserInfo(accessToken.access_token);
            Account acct = userInfo.Accounts.FirstOrDefault();

            string envelopeId = SendEnvelopeViaEmail(signerEmail, signerName, ccEmail, ccName, accessToken.access_token, acct.BaseUri + "/restapi", acct.AccountId, "", docPdf, "sent");

        }

        /// <summary>
        /// Creates an envelope that would include two documents and add a signer and cc recipients to be notified via email
        /// </summary>
        /// <param name="signerEmail">Email address for the signer</param>
        /// <param name="signerName">Full name of the signer</param>
        /// <param name="ccEmail">Email address for the cc recipient</param>
        /// <param name="ccName">Name of the cc recipient</param>
        /// <param name="accessToken">Access Token for API call (OAuth)</param>
        /// <param name="basePath">BasePath for API calls (URI)</param>
        /// <param name="accountId">The DocuSign Account ID (GUID or short version) for which the APIs call would be made</param>
        /// <param name="docPdf">String of bytes representing the document (pdf)</param>
        /// <param name="docDocx">String of bytes representing the Word document (docx)</param>
        /// <param name="envStatus">Status to set the envelope to</param>
        /// <returns>EnvelopeId for the new envelope</returns>
        private static string SendEnvelopeViaEmail(string signerEmail, string signerName, string ccEmail, string ccName, string accessToken, string basePath, string accountId, string docDocx, string docPdf, string envStatus)
        {
            // Step 1 start
            EnvelopeDefinition env = MakeEnvelope(signerEmail, signerName, ccEmail, ccName, docDocx, docPdf, envStatus);
            var apiClient = new DocuSignClient(basePath);
            apiClient.Configuration.DefaultHeader.Add("Authorization", "Bearer " + accessToken);

            EnvelopesApi envelopesApi = new(apiClient);
            EnvelopeSummary results = envelopesApi.CreateEnvelope(accountId, env);
            return results.EnvelopeId;
            // Step 1 end
        }

        private static EnvelopeDefinition MakeEnvelope(string signerEmail, string signerName, string ccEmail, string ccName, string docDocx, string docPdf, string envStatus)
        {

            string doc2DocxBytes = "";//Convert.ToBase64String(System.IO.File.ReadAllBytes(docDocx));
            string doc3PdfBytes = Convert.ToBase64String(System.IO.File.ReadAllBytes(docPdf));// Add encode logic here
            int pageCount = 5;

            // Step 3 start
            EnvelopeDefinition env = new()
            {
                EmailSubject = "Please sign this document set",
            };

            Document doc1 = new()
            {
                DocumentBase64 = doc3PdfBytes,
                Name = "Form Questionnaire", // can be different from actual file name
                FileExtension = "pdf",
                DocumentId = "1",
            };

            env.Documents = new List<Document> { doc1 }; //{ doc1, doc2, doc3 };

            Signer signer1 = new()
            {
                Email = signerEmail,
                Name = signerName,
                RecipientId = "1",
                RoutingOrder = "1",
            };

            CarbonCopy cc1 = new()
            {
                Email = ccEmail,
                Name = ccName,
                RecipientId = "2",
                RoutingOrder = "2",
            };


            SignHere signHere1 = new();
            Tabs signer1Tabs = new()
            {
                SignHereTabs = new List<SignHere> { signHere1 },
            };
            for (int i = 1; i <= pageCount; i++)
            {
                signHere1 = new()
                {
                    DocumentId = "1",
                    PageNumber = i.ToString(),
                    Source = "Questionnaire_API.pdf",
                    TabType = "signhere",
                    XPosition = "500",
                    YPosition = "700",
                    Name = "Questionnaire_api",
                    Optional = "false",
                    ScaleValue = "1",
                    StampType = "signature",
                };
                signer1Tabs.SignHereTabs.Add(signHere1);
            }
            signer1.Tabs = signer1Tabs;

            Recipients recipients = new()
            {
                Signers = new List<Signer> { signer1 },
                CarbonCopies = new List<CarbonCopy> { cc1 },
            };
            env.Recipients = recipients;
            env.Status = envStatus;

            return env;
            // Step 3 end
        }

        private static OAuthToken AuthenticateWithJWT(string api, string clientId, string impersonatedUserId, string authServer, string privateKeyFile)
        {
            var apiClient = new DocuSignClient();
            var scopes = new List<string>
                {
                    "signature",
                    "impersonation",
                };

            return apiClient.RequestJWTUserToken(
                clientId,
                impersonatedUserId,
                authServer,
                DSHelper.ReadFileContent(DSHelper.PrepareFullPrivateKeyFilePath(privateKeyFile)),
                1,
                scopes);
        }
    }

    internal class DSHelper
    {
        internal static string PrepareFullPrivateKeyFilePath(string fileName)
        {
            const string DefaultRSAPrivateKeyFileName = "private.key";

            var fileNameOnly = Path.GetFileName(fileName);
            if (string.IsNullOrEmpty(fileNameOnly))
            {
                fileNameOnly = DefaultRSAPrivateKeyFileName;
            }

            var filePath = Path.GetDirectoryName(fileName);
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Directory.GetCurrentDirectory();
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && Directory.GetCurrentDirectory().Contains("bin"))
            {
                fileNameOnly = DefaultRSAPrivateKeyFileName;
                filePath = Path.GetFullPath(Path.Combine(filePath, @"../../.."));
            }

            return Path.Combine(filePath, fileNameOnly);
        }

        internal static byte[] ReadFileContent(string path)
        {
            return File.ReadAllBytes(path);
        }
    }
}
