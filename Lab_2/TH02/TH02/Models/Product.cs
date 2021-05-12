using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TH02.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int ProductPrice { get; set; }
        public string Image { get; set; }
    }
}
