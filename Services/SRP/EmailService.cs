using BestPractices.EmailConfiguration;
using BestPractices.Models;
using BestPractices.Services.SRP.Interfaces;
using Microsoft.Extensions.Options;
using System.Net.Mail;

namespace BestPractices.Services.SRP
{
    public class EmailService : IEmailService
    {
        EmailConfig _emailSettings = null;
        public EmailService(IOptions<EmailConfig> options)
        {
            _emailSettings = options.Value;
        }

        public bool SendEmail(EmailData emailData)
        {
            try
            {
                using (MailMessage emailMessage = new MailMessage())
                {
                    MailAddress emailFrom = new MailAddress(_emailSettings.Name, _emailSettings.EmailId);
                    emailMessage.From = emailFrom;

                    MailAddress emailTo = new MailAddress(emailData.EmailToName, emailData.EmailToId);
                    emailMessage.To.Add(emailTo);

                    emailMessage.Subject = emailData.EmailSubject;

                    emailMessage.Body = "This is just a sample email notification!...";


                    SmtpClient smtpEMialClient = new SmtpClient()
                    {
                        Host = _emailSettings.Host,
                        Port = _emailSettings.Port
                    };
                    smtpEMialClient.EnableSsl = true;

                    if (!string.IsNullOrEmpty(_emailSettings.Name))
                    {
                        smtpEMialClient.Credentials = new System.Net.NetworkCredential(
                               _emailSettings.Name,
                               _emailSettings.Password
                            );
                    }
                    smtpEMialClient.Send(emailMessage);
                    return true;
                }

            }
            catch (Exception ex)
            {
                //Log exception details here.....

                return false;
            }
        }
    }
}
