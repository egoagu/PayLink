namespace PayLink.Models.GenerateLink
{
    public class PayLinkRequest
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Amount { get; set; }

    }
}