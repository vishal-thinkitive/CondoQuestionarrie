using CondoQuestionnaire.Server.DataModel.Model;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using CondoQuestionnaire.Server.Services.Interface;

namespace CondoQuestionnaire.Server.Services.Class
{
    public class MailService : BaseService, IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService()
        {
            _mailSettings = new MailSettings
            {
                Mail= "noreply.townhouse@gmail.com",
                DisplayName= "No-replay",
                Password= "ayuxxumvawirzltr",
                Host= "smtp.gmail.com",
                Port= 587
            };
        }

        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
            if (mailRequest.Attachments != null)
            {
                byte[] fileBytes;
                foreach (var file in mailRequest.Attachments)
                {
                    if (file.Length > 0)
                    {
                        using (var ms = new MemoryStream())
                        {
                            file.CopyTo(ms);
                            fileBytes = ms.ToArray();
                        }
                        builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                    }
                }
            }
            builder.HtmlBody = mailRequest.Body;
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}
