namespace TestEFC.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Desription { get; set; }

        
        public decimal Price { get; set; }
        public byte[] Img { get; set; }
        public static long Count { get; set; }
    }
    
}
