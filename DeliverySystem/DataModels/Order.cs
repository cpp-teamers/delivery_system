using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverySystem.DataModels
{
    class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public string AdressRecipient { get; set; }
        public DateTime DateOfCreation { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
