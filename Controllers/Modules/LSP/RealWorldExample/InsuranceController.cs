using BestPractices.Services.LSP;
using BestPractices.Services.LSP.BaseClass;
using Microsoft.AspNetCore.Mvc;

namespace BestPractices.Controllers.Modules.LSP.RealWorldExample
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private Insurance _motorInsurance;

        [HttpGet("TwoWheelerInsurance")]
        public object TwoWheelerInsurance()
        {
            _motorInsurance = new TwoWheelerInsurance();
            return Ok("TwoWheelerInsurance => PassengerCover => " + _motorInsurance.GetPassengerCover());
            //TwoWheelerInsurance => PassengerCover => False
        }
        [HttpGet("PrivateCarInsurance")]
        public object PrivateCarInsurance()
        {
            _motorInsurance = new PrivateCarInsurance();
            return Ok("PrivateCarInsurance => PassengerCover => " + _motorInsurance.GetPassengerCover());
            //PrivateCarInsurance => PassengerCover => False
        }

        [HttpGet("CommercialVehicleInsurance")]
        public object CommercialVehicleInsurance()
        {
            _motorInsurance = new CommercialVehicleInsurance();
            return Ok("CommercialVehicleInsurance => PassengerCover => " + _motorInsurance.GetPassengerCover());
            //CommercialVehicleInsurance => PassengerCover => True
        }
    }
}
