using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverySystem.DataModels
{
    class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public string AdressRecipient { get; set; }
        public DateTime DateOfCreation { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; }
        public void DisplayOrder()
        {
            // Список товаров
            Console.WriteLine("\n Список товаров для заказа: ");
            foreach (var product in Products)
                Console.WriteLine(product);
            // Остальные характеристики заказа
            Console.WriteLine($" Финальная цена: {TotalPrice} $");
            Console.WriteLine($" Дата создания заказа: {DateOfCreation}");
            Console.WriteLine($" Адресс получателя: {AdressRecipient}");
        }
    }
}
