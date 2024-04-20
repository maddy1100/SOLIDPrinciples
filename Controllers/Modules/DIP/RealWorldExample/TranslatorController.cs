using BestPractices.Models;
using BestPractices.Services.DIP;
using BestPractices.Services.DIP.Interfaces;
using BestPractices.Services.SRP.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestPractices.Controllers.Modules.DIP.RealWorldExample
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslatorController : ControllerBase
    {
        private ITranslator _translator;
        public TranslatorController(EnglishTranslator translator)
        {
            _translator = translator;
        }

        [HttpPost("TranslateToEnglish")]
        public string TranslateToEnglish()
        {
            return _translator.Translate("ಧನ್ಯವಾದಗಳು");
        }
    }
}
