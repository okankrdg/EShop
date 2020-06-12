using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Product:BaseEntity
    {
        public string  ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string PhotoPath { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
