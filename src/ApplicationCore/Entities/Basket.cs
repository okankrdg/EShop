using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Basket:BaseEntity
    {
        public string BuyerId { get; set; }
        public List<BasketItem> Items { get; set; }
    }
}
