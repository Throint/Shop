using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestEFC.ModelView
{
    public class CreateItem
    {
        public string Name { get; set; }
        public string Desription { get; set; }


        public decimal Price { get; set; }

        public IFormFile FormFile { get; set; }
        

        public static long Count { get; set; }
    }
}
