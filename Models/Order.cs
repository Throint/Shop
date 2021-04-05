using System.ComponentModel.DataAnnotations.Schema;

namespace TestEFC.Models
{
    public class Order
    {
        public long Id { get; set; }
        public string ItemsId { get; set; }
        public string BuyerFirstName { get; set; }
        public string BuyerSecondName { get; set; }
        public string BuyerEmail { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal TotalPrice { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public OrderStatus Status { get; set; }
        public string PayType { get; set; }
    }
    
}
