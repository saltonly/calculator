﻿using System;

namespace gitt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0; int n2 = 0;

            Console.WriteLine("  ^ Казалось бы калькулятор ^  \r");
            Console.WriteLine("_______________________________\n");

            // Ввод первого числа
            Console.WriteLine("Введите число и нажмите Enter)");
            n1 = Convert.ToInt32(Console.ReadLine());



            // Выбор действия
            Console.WriteLine("Выбирите действие:");
            Console.WriteLine("\ta - Сложение");
            Console.WriteLine("\ts - Вычитание");
            Console.WriteLine("\tm - Умножение");
            Console.WriteLine("\td - Деление");
            Console.Write("Что же вы выбирите?) ");

            // Математические операции
            switch (Console.ReadLine())
            {


            }

            // Закрытие проги
            Console.Write("Нажмите на любую кнопочку для закрытия ^ Казалось бы калькулятора ^) ");
            Console.ReadKey();
        }
    }
}
