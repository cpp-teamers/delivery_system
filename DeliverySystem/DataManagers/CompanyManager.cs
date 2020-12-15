using System;
using System.Collections.Generic;
using System.Text;

// use 2 library
using DeliverySystem.DataModels;

namespace DeliverySystem.DataManagers
{
    class CompanyManager
    {
        public List<Employee> employees { get; set; } = new List<Employee>();


        // Добавить, удалить, изменить сотрудника

        public void AddEmployee(Employee empToAdd)
		{
            // Add employee logic
            employees.Add(empToAdd);
		}

        public void DelEmployee(string empNameToDel)
        {
			// Delete employee by name  logic
			foreach (Employee emp in employees)
			{
                if (emp.Name == empNameToDel)
                {
                    employees.Remove(emp);
                    break;
                }
			}
        }

        public void EditEmployee(string name)
		{
            // Edit employee by name  logic

            // Dialog Menu for getting new data for editting
            

            // finding employee for edit


        }
    }
}
