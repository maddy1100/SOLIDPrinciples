using BestPractices.Models;
using BestPractices.Services.OCP;
using BestPractices.Services.OCP.Interfaces;
using BestPractices.Services.SRP.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestPractices.Controllers.Modules.OCP.RealWorldExample
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderFileUploadController : ControllerBase
    {
        [HttpPost("UploadXMLOrderFile")]
        public object UploadXMLOrderFile()
        {
            return new UploadXMLOrderFile().ProcessOrderFile();
        }
        [HttpPost("UploadJSONOrderFile")]
        public object UploadJSONOrderFile()
        {
            return new UploadJSONOrderFile().ProcessOrderFile();
        }
    }
}
