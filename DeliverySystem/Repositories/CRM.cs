using System;
using System.Collections.Generic;
using System.Text;
using DeliverySystem.DataModels;

namespace DeliverySystem.Repositories
{
    class CRM
    {
        // Список управления клиентами, заказами
        public List<Order> Orders { get; set; }
        public List<Client> Clients { get; set; }

        public CRM()
        {
            Orders = new List<Order>();
            Clients = new List<Client>();
        }
    }
}
