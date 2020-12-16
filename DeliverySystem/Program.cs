using System;
using DeliverySystem.UI_Controllers;
using DeliverySystem.DataManagers;

namespace DeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов управляющих классов
            MenuController ms = new MenuController();
            DialogController dc = new DialogController();
            CatalogManager cm = new CatalogManager();
            // Цикл перезапуска
            do
            {
                Console.Clear();
                ms.PrintGeneralMenu();

                switch (ms.GetChoice())
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("\n...Упс, что-то пошло не так (0_0)");
                        break;
                }
            } while (ms.AllowContinue());
        }
    }
}
