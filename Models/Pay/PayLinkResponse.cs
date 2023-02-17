namespace PayLink.Models.GenerateLink
{
    public class PayLinkResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string PaymentLink { get; set; }

    }
}