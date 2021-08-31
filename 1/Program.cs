using System;

namespace _24._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
           string a2 = "NuN";
            Console.WriteLine("Выберите валюту usd, euro, rub, som");
            string a1 = Console.ReadLine();
            if (a1 == "som")
            {
                Console.WriteLine("Выберите вторую волюту usd, euro, rub");
                a2 = Console.ReadLine();
            }
            Console.WriteLine("введите сумму конвертации");
            double s = Convert.ToDouble(Console.ReadLine());
                Converter conver = new Converter()
            {
                m1 = a1,
                sum = s,
                m2 = a2
            };
            conver.GetConv();
        }
    }
    class Converter
    {
        public string m1;
        public string m2;
        public double convert;
        public double sum;
        public Converter() { }
        public Converter(string M1, string M2, double Sum)
        {
           m1 = M1; m2 = M2; convert = Sum;
        }
        public void GetConv()
        {
            if (m1 == "usd")
            {
                convert = sum * 1132.86 / 100;
                Console.WriteLine($"{sum} dollar = {Math.Round(convert, 2)} somoni");
            }
            else if (m1 == "som" && m2 == "usd")
            {
                convert = sum * 8.74 / 100;
                Console.WriteLine($"{sum} somoni = {Math.Round(convert, 2)} dollar");
            }
            else if (m1 == "euro")
            {
                convert = sum * 1345.52 / 100;
                Console.WriteLine($"{sum} evro = {Math.Round(convert, 2)} somoni");
            }
            else if (m1 == "som" && m2 == "euro")
            {
                convert = sum * 7.44 / 100;
                Console.WriteLine($"{sum} somoni = {Math.Round(convert, 2)} evro");
            }
            else if (m1 == "rub")
            {
                convert = sum * 15.45 / 100;
                Console.WriteLine($"{sum} rubl = {Math.Round(convert, 2)} somoni");
            }
            else if (m1 == "som" && m2 == "rub")
            {
                convert = sum * 647.60 / 100;
                Console.WriteLine($"{sum} somoni = {Math.Round(convert, 2)} rubl");
            }
            else Console.WriteLine("Введен не правильное значение");
        }
    }
}
