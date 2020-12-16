using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverySystem.DataModels
{
    class Client
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public override string ToString()
        {
            return $"\n\n===========================" +
                $"\n ->{Name}<-" +
                $"\n ID клиента: {Id}" +
                $"\n Пароль: {Password}" +
                $"\n Местонахождение: {Location}.";
        }
    }
}
