using System;
using System.Collections.Generic;
using System.Text;
using DeliverySystem.DataModels;

namespace DeliverySystem.Repositories
{
    class Catalog
    {
        // Список товаров
        public string Name { get; set; }
        public List<Product> Products { get; set;}

        public Catalog()
        {
            Products = new List<Product>();
        }
    }
}
