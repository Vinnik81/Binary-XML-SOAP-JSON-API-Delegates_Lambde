using System;
using System.Collections.Generic;

namespace HomeWork_Delegates
{
    class Program
    {
        delegate bool Filter(int num);
        static List<int> Func(List<int> arr, Filter filter)
        {
            List<int> newArr = new List<int>();
            for (int i = 0; i < arr.Count; i++)
                if (filter(arr[i])) newArr.Add(arr[i]);
            return newArr;
        }
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Номер задания:\n1 - Вывод чётных чисел;\n2 - Вывод нечётных чисел;\n3 - Вывод чисел больше 5;" +
                "\n4 - Вывод чисел меньше 5;\n5 - Вывод чисел, которые не делятся на 2 и 3;\n6 - Вывод чисел больше n.");
            Console.Write("Введите номер задания: ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: var newArr = Func(arr, x => x % 2 == 0);
                    foreach (var item in newArr) Console.Write($"{item}\t"); break;
                case 2: var newBrr = Func(arr, x => x % 2 != 0);
                    foreach (var item in newBrr) Console.Write($"{item}\t"); break;
                case 3: var newCrr = Func(arr, x => x > 5);
                    foreach (var item in newCrr) Console.Write($"{item}\t"); break;
                case 4: var newDrr = Func(arr, x => x < 5);
                    foreach (var item in newDrr) Console.Write($"{item}\t"); break;
                case 5: var newErr = Func(arr, x => x % 2 != 0 && x % 3 != 0);
                    foreach (var item in newErr) Console.Write($"{item}\t"); break;
                case 6: Console.Write("Введите число: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n >= 0 || n < arr.Count)
                    {
                        var newFrr = Func(arr, x => x > n);
                        foreach (var item in newFrr) Console.Write($"{item}\t"); 
                    }
                    break;
                default: if (number <= 0 || number > 6) Console.WriteLine("Неправильный номер задания!"); break;
            }
        }
    }
}
