using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestEFC.Models
{
   public class CartList
    {
        public List<Item> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
