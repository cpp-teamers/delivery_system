using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverySystem.UI_Controllers
{
    class MenuController
    {
        // Вывод на экран функций

        public void PrintCatalogManagerFunctions()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("    Функционал CatalogManager`a");
            Console.WriteLine("1. Добавить продукт");
            Console.WriteLine("2. Удалить продукт");
            Console.WriteLine("3. Изменить продукт");
            Console.WriteLine("4. Вывести на экран продукты");
            Console.WriteLine("5. Назад");
        }

        public void PrintCompanyManagerFunctions()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("    Функционал CompanyManager`a");
            Console.WriteLine("1. Добавить Сотрудника");
            Console.WriteLine("2. Удалить Сотрудника");
            Console.WriteLine("3. Изменить параметры Сотрудника");
            Console.WriteLine("4. Вывести на экран всех сотрудников");
            Console.WriteLine("5. Назад");
        }

        public void PrintCRMManagerFunctions()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("    Функционал CRMManager`a");
            Console.WriteLine("1. Добавить заказ");
            Console.WriteLine("2. Удалить заказ");
            Console.WriteLine("3. Изменить параметры заказа");
            Console.WriteLine("4. Вывести на экран все заказы");
            Console.WriteLine("5. Добавить клиента");
            Console.WriteLine("6. Удалить клиента");
            Console.WriteLine("7. Изменить параметры клиента");
            Console.WriteLine("8. Вывести на экран всех клиентов");
            Console.WriteLine("9. Назад");

        }

        public void PrintGeneralMenu()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("    Меню DeliveryCompany");
            Console.WriteLine("1. Работа с каталогом товаров");
            Console.WriteLine("2. Работа с сотрудниками компании");
            Console.WriteLine("3. Работа с заказами и клиентами");
            Console.WriteLine("4. Выход");
        }

        public int GetChoice()
        {
            Console.WriteLine("> Выберите нужную операцию:");
            return Convert.ToInt32(Console.ReadLine());
        }

        public bool AllowContinue()
        {
            Console.WriteLine("> Продолжить?(y/n) -> ");
            return ('y' == Convert.ToChar(Console.ReadLine()));
        }
    }
}
