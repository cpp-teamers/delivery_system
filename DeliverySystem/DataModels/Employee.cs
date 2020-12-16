using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverySystem.DataModels
{
    class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Age { get; set; }
        public string Position { get; set; }
        public double Rate { get; set; }
        public override string ToString()
        {
            return $"\n===================================" +
                $"-> {FirstName,5}{SecondName,20} <-" +
                $"\n Возраст: {Age} лет" +
                $"\n Должность: {Position}" +
                $"\n Рейтинг: {Rate} баллов";
        }
    }
}
