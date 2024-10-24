using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// О инкапсуляции данных
namespace _20.EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Обзор работы инкапсуляции *****\n");
            // 1. --------------------------------------------------------------------------
            //Console.WriteLine("Создали сотрудника без параметров");
            //Employee app = new Employee();
            //Console.WriteLine("Присвоили бонус через метод");
            //app.GiveBonus(1000);
            //app.DisplayStats();
            //Console.WriteLine("Присвоили имя через метод");
            //app.SetName("Marv");
            //Console.WriteLine($"Имя сотрудника: {app.GetName()}");

            // 2. --------------------------------------------------------------------------
            //Console.WriteLine("Создали сотрудника c параметрами");
            //Employee app = new Employee("Marvin", 456, 30000);
            //Console.WriteLine("Присвоили бонус через метод");
            //app.GiveBonus(1000);
            //app.DisplayStats();
            //Console.WriteLine("Присвоили имя через свойство");
            //app.Name = "Mary"; // Как будто открытые данные, но Name это свойство которое работает с empName (private)
            //Console.WriteLine($"Имя сотрудника: {app.Name}");

            // 3. --------------------------------------------------------------------------
            //Employee app = new Employee();
            //app.Age++;
            Console.ReadLine();
        }
    }
}
