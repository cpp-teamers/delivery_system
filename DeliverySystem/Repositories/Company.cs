using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using DeliverySystem.DataModels;

namespace DeliverySystem.Repositories
{
    class Company
    {
        // Список сотрудников
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
        }

    }
}
