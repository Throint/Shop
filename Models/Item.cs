using System.ComponentModel.DataAnnotations.Schema;

namespace TestEFC.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Desription { get; set; }

        [Column(TypeName = "decimal(7, 2)")]
        public decimal Price { get; set; }
        public byte[] Img { get; set; }
        public static long Count { get; set; }
    }
    
}
