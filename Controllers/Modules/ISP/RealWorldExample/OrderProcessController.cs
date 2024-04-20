using BestPractices.Services.LSP.BaseClass;
using BestPractices.Services.LSP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BestPractices.Services.ISP;
using BestPractices.Services.ISP.Interfaces;

namespace BestPractices.Controllers.Modules.ISP.RealWorldExample
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProcessController : ControllerBase
    {
        private IPaymentOnline _paymentOnline;
        private IPaymentOffline _paymentOffline;
        public OrderProcessController(OrderWithOnlinePayment paymentOnline,OrderWithCashPayment paymentCash)
        {
            _paymentOnline = paymentOnline;
            _paymentOffline = paymentCash;

        }

        [HttpPost("OrderWithCreditCardPayment")]
        public object OrderWithCreditCardPayment()
        {
            return Ok("MakePaymentByCreditCard => Amount => " + _paymentOnline.MakePaymentByCreditCard(5000));
            //MakePaymentByCreditCard => Amount => True
        }

        [HttpPost("OrderWithNetBankingPayment")]
        public object OrderWithNetBankingPayment()
        {
            return Ok("MakePaymentByNetBanking => Amount => " + _paymentOnline.MakePaymentByNetBanking(5000));
            //MakePaymentByNetBanking => Amount => True
        }

        [HttpPost("OrderWithCashPayment")]
        public object OrderWithCashPayment()
        {
            return Ok("MakePaymentByCash => Amount => " + _paymentOffline.MakePaymentByCash(2500));
            //MakePaymentByCash => Amount => True
        }
    }
}
