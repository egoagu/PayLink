using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayLink.Models;
using PayLink.Models.GenerateLink;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace PayLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private const string PaymentBaseUrl = "https://egoagu.com/pay/"; //move to appsettings later

        private static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

        }

        [HttpPost]
        [Route("generate-paylink")]
        public PayLinkResponse GeneratePaymentLink(PayLinkRequest request)
        {
            try
            {
                string paymentLink = $"{PaymentBaseUrl}{GenerateRandomString(10)}".ToLower();

                return new PayLinkResponse
                {
                    ResponseCode = "00",
                    ResponseMessage = "Successful",
                    PaymentLink = paymentLink
                };


            }
            catch (Exception ex)
            {
                return new PayLinkResponse
                {
                    ResponseCode = "01",
                    ResponseMessage = $"An error occured: {ex.Message}"
                };
            }
        }

    }
}
