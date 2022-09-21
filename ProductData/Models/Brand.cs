using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductData.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}