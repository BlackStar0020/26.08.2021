﻿using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Ali = new Employee()
            {
                Name = "Али",
                LastName = "Алиев",
                profession = "консультант"
            };
            Ali.GetInfo();
            Employee Bekali = new Employee()
            {
                Name = "Бекали",
                LastName = "Беков",
                profession = "эксперт"
            };
            Bekali.GetInfo();
            Employee Abdullo = new Employee()
            {
                Name = "Абдулло",
                LastName = "Абдуллоев",
                profession = "специалист"
            };
            Abdullo.GetInfo();
        }
    }
    class Employee
    {
        public string Name;
        public string LastName;
        public string profession;
        public double Salary;
        public double tax;
        public Employee() { }
        public Employee(string prof, double salary, string name, string lastName, double Csalary) 
        {
            profession = prof; Salary = salary; Name = name; LastName = lastName; tax = Csalary;
        }
        public void GetInfo()
        {
            if (profession == "консультант") Salary = 800;
            else if (profession == "эксперт") Salary = 2000;
            else if (profession == "специалист") Salary = 5000;
            else Console.WriteLine("такой должности в системе нет");
            tax = (Salary * 14) / 100;
            Console.WriteLine($"Имя: {Name}, Фамилия: {LastName}, Должность: {profession}, Зарплата: {Salary}, налог: {tax}, чистая зарплата {Salary - tax}");
        }
    }
}
