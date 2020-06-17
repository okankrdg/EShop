using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ApplicationCore.Entities
{
    public class BasketItem: BaseEntity
    {
        public int BasketId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int ProductId { get; set; }
    }
}
