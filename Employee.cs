using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.EmployeeApp
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;


        public string SocialSecurityNumber // свойство доступное только для чтения
        {
            get => empName;
        }

        //public int Age
        //{
        //    get { return empAge; }
        //    set { empAge = value; }
        //}
        // ИЛИ
        public int Age
        {
            get => empAge;
            set => empAge = value;
        }

        public int EmpID
        {
            get => empID; 
            set => empID = value;
        }

        public float CurrPay
        { 
            get => currPay;
            set => currPay = value;
        }

        public Employee() { }
        public Employee(string _empName, int _empID, float _currPay) : this(_empName, 0, _empID, _currPay) {}

        public Employee(string _empName, int _empAge, int _empID, float _currPay)
        {
            //if (_empName.Length > 15)
            //{
            //    Console.WriteLine("Длина имени не должна превышать 15 символов!!!");
            //}
            //else
            //{
            //    empName = _empName;
            //}
            // ИЛИ (чтобы не дублировать код в конструкторе и свойстве):
            Name = _empName;

            Age = _empAge;
            EmpID = _empID;
            CurrPay = _currPay;
        }

        public void GiveBonus(float amount)
        {
            CurrPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"ID: {EmpID}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Текущая выплата: {CurrPay}");
        }

        // 1. Доступ с помощью обычных методов --------------------------------------------------------
        //public string GetName()
        //{
        //    return empName;
        //}

        //public void SetName(string _empName)
        //{
        //    if(_empName.Length > 15)
        //    {
        //        Console.WriteLine("Длина имени не должна превышать 15 символов!!!");
        //    }
        //    else
        //    {
        //        empName = _empName;
        //    }
        //}

        // 2. Доступ с помощью свойств ----------------------------------------------------------------
        public string Name
        {
            get { return empName; }
            set
            {
                if(value.Length > 15)
                {
                    Console.WriteLine("Длина имени не должна превышать 15 символов!!!");
                }
                else
                {
                    empName = value;
                }
            }
        }
    }
}
