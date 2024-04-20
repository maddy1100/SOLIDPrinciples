using BestPractices.Models;
using BestPractices.Services.SRP.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BestPractices.Controllers.Modules.SRP.RealWorldExample
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("SendEmail")]
        public bool SendEmail(EmailData emailData)
        {
            return _emailService.SendEmail(emailData);
        }
    }
}
