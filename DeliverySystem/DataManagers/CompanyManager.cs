using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using DeliverySystem.DataModels;
using DeliverySystem.Repositories;


namespace DeliverySystem.DataManagers
{
    class CompanyManager
    {
        Company company = new Company();
        string path = @"..\..\..\DataStorage\company.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Company));


        // Добавить, удалить, изменить сотрудника

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                company = (Company)serializer.ReadObject(fs);
            }
        }
        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(fs, company.Employees);
            }
        }
        public void AddEmployee(Employee empToAdd)
		{
            company.Employees.Add(empToAdd);

            Console.WriteLine("\n>Employee has been added successfully");
        }
        public void DelEmployee(string empNameToDel)
        {
			foreach (Employee emp in company.Employees)
			{
                if (emp.FirstName == empNameToDel)
                {
                    company.Employees.Remove(emp);
                    break;
                }
			}

            Console.WriteLine("\n>Employee has been deleted successfully");
        }
        public void EditEmployee(string empNameToEdit,  double newRate)
		{
			foreach (Employee e in company.Employees)
			{
				if (e.FirstName == empNameToEdit)
				{
                    e.FirstName = empNameToEdit;
                    e.Rate = newRate;
                    break;
                }
			}
            Console.WriteLine("\n>Employee has been edited successfully");
        }
        public void DisplayAllEmps()
        {
            foreach (Employee e in company.Employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
