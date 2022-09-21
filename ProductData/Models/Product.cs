using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductData.Models
{
    public class Product
    {
        public int Id { get; set; }
        [ForeignKey("Brands")]
        public int BrandID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public virtual Brand Brands { get; set; }
    }
}