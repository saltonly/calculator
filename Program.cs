using System;

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

            // Ввод второго числа
            Console.WriteLine("Введите еще одно число и нажмите Enter)");
            n2 = Convert.ToInt32(Console.ReadLine());

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
                case "a":
                    Console.WriteLine($"Вот такие пироги): {n1} + {n2} = " + (n1 + n2));
                    break;
                case "s":
                    Console.WriteLine($"Вот такие пироги): {n1} - {n2} = " + (n1 - n2));
                    break;
                case "m":
                    Console.WriteLine($"Вот такие пироги): {n1} * {n2} = " + (n1 * n2));
                    break;
                case "d":
                    Console.WriteLine($"Вот такие пироги): {n1} / {n2} = " + (n1 / n2));
                    break;
            }

            // Закрытие проги
            Console.Write("Нажмите на любую кнопочку для закрытия ^ Казалось бы калькулятора ^) ");
            Console.ReadKey();
        }
    }
}
