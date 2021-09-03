using System;

namespace _24._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
           string n2 = "NuN";
            Console.WriteLine("Выберите валюту usd, euro, rub, som");
            string n1 = Console.ReadLine();
            if (n1 == "som")
            {
                Console.WriteLine("Выберите вторую волюту usd, euro, rub");
                n2 = Console.ReadLine();
            }
            Console.WriteLine("введите сумму конвертации");
            double s = Convert.ToDouble(Console.ReadLine());
                Converter conver = new Converter()
            { 
                a1 = n1,
                sum = s,
                a2 = n2
            };
            conver.GetConv();
        }
    }
    class Converter
    {
        public string a1;
        public string a2;
        public double convert;
        public double sum;
        public Converter() { }
        public Converter(string A1, string A2, double Sum)
        {
           a1 = A1; a2 = A2; convert = Sum;
        }
        public void GetConv()
        {
            if (a1 == "usd")
            {
                convert = sum * 1132.86 / 100;
                Console.WriteLine($"{sum} dollar = {Math.Round(convert, 2)} somoni");
            }
            else if (a1 == "som" && a2 == "usd")
            {
                convert = sum * 8.74 / 100;
                Console.WriteLine($"{sum} somoni = {Math.Round(convert, 2)} dollar");
            }
            else if (a1 == "euro")
            {
                convert = sum * 1345.52 / 100;
                Console.WriteLine($"{sum} evro = {Math.Round(convert, 2)} somoni");
            }
            else if (a1 == "som" && a2 == "euro")
            {
                convert = sum * 7.44 / 100;
                Console.WriteLine($"{sum} somoni = {Math.Round(convert, 2)} evro");
            }
            else if (a1 == "rub")
            {
                convert = sum * 15.45 / 100;
                Console.WriteLine($"{sum} rubl = {Math.Round(convert, 2)} somoni");
            }
            else if (a1 == "som" && a2 == "rub")
            {
                convert = sum * 647.60 / 100;
                Console.WriteLine($"{sum} somoni = {Math.Round(convert, 2)} rubl");
            }
            else Console.WriteLine("Введен не правильное значение");
        }
    }
}
