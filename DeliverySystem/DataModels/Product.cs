using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverySystem.DataModels
{
    class Product
    {
        public string NameProduct { get; set; }
        public string Producer { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"\n===========================" +
                $"\n -> {NameProduct} <-" +
                $"\n {Producer}" +
                $"\n {Weight} кг" +
                $"\n {Price} $";
        }
    }
}
