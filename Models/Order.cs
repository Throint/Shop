namespace TestEFC.Models
{
    public class Order
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public string BuyerFirstName { get; set; }
        public string BuyerSecondName { get; set; }
        public string BuyerEmail { get; set; }
        public decimal TotalPrice { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string PayType { get; set; }
    }
    
}
