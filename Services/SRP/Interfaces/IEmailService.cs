using BestPractices.Models;

namespace BestPractices.Services.SRP.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(EmailData emailData);
    }
}
