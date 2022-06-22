using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //public delegate void Print();
        //delegate bool Sort(string tmp);

        //static public void Hi(Print print)
        //{
        //    Console.WriteLine("Hello");
        //}
        //static public void H2()
        //{
        //    Console.WriteLine("H2");
        //}
        //static public bool IsEmpty(string name)
        //{
        //    return !string.IsNullOrEmpty(name);
        //}



        // delegate string Print(string str);
        delegate void Print(int a, int b);

        static void Hi()
        {
            Console.WriteLine("Hi");
        }
        static void Bye()
        {
            Console.WriteLine("Bye");
        }

        //delegate bool Filter(int num);

        //static List<int> Func(List<int> arr, Filter filter)//?????????????????????????????????
        //{
        //    List<int> newArr = new List<int>();
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        if (filter(arr[i]))
        //        {
        //            newArr.Add(arr[i]);
        //        }
        //    } 
        //    return newArr;
        //}



        delegate bool Filter(int num);

        static List<int> Func(List<int> arr, Filter filter)
        {
            List<int> newArr = new List<int>();
            for (int i = 0; i < arr.Count; i++) if (filter(arr[i])) newArr.Add(arr[i]);

            return newArr;
        }


        //static List<int> EvenNumbers(List<int> arr)
        //{
        //    List<int> newArr = new List<int>();
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        if (arr[i] % 2 == 0)
        //        {
        //            newArr.Add(arr[i]);
        //        }
        //    }
        //    return newArr;
        //}
        //static List<int> OddNumbers(List<int> arr)
        //{
        //    List<int> newArr = new List<int>();
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        if (arr[i] % 2 != 0)
        //        {
        //            newArr.Add(arr[i]);
        //        }
        //    }
        //    return newArr;
        //}

        static bool EvenNumber(int x)
        {
            return x % 2 == 0;
        }
        static void Main(string[] args)
        {

            List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var newArr = Func(arr, x=>x%2==0);
            //var newArr = Func(arr, x => x % 2 != 0);
            // var newArr = EvenNumbers(arr);
            // var newArr = OddNumbers(arr);

            var newArr = Func(arr, EvenNumber);
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }


            //List<int> arr  = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////var newArr = Func(arr, x=>x%2==0);
            ////var newArr = Func(arr, x => x % 2 != 0);
            //var newArr = Func(arr, x => x % 3 == 0);

            //foreach (var item in newArr)
            //{
            //    Console.WriteLine(item);
            //}




            //Print print = ( x, y) =>
            //{
            //   Console.WriteLine(x + y);
            // };

            //Print test = (int x, int y) => Console.WriteLine(x + y);
            //test += (int x, int y) => Console.WriteLine(x - y); ;
            //test -= (int x, int y) => Console.WriteLine(x - y); ;
            //test += (int x, int y) => Console.WriteLine(x * y); ;
            //test += (int x, int y) => Console.WriteLine(x / y); ;

            //test(10,10);

            //print(10, 20);
            ///////////////////////////////////////////////
            //Print print1 = delegate ()
            //{
            //    Console.WriteLine("Good");
            //};

            //Print print1 = delegate (string str)
            //{
            //    Console.WriteLine(str);
            //};

            //Print print1 = delegate (string str)
            //{
            //    return str;
            //};

            //     Print print1 =  (string str) => str;
            // print1 = (string str) => str+" Abdullayev";

            //print1 = (string str) => 
            //{ 
            //    str += " Abdullayev";
            //    return str;
            //};

            //if (true) Console.WriteLine("10");
            //else Console.WriteLine(20); Console.WriteLine(20); Console.WriteLine(20); Console.WriteLine(20);

            // 10 20 20 20 
            //  Console.WriteLine(print1("Farid"));
            /////////
            //////////////////////////////////////////////////////////////////
            // Print print = null ;// = Hi;
            //print += Bye;


            //print -= Bye;
            //print();

            //Print print1 = Hi;
            //Print print2 = Bye;
            //// Print print3 = print1 + print2;
            //Print print3 = print1 ;
            // print3 +=  print2;


            //print?.Invoke();

            //Print print = Hi;
            //print += H2;

            //print();


            //Hi(H2);


            //  Sort sort = IsEmpty;
            ////  Predicate<string> predicate = IsEmpty;
            //  List<string> arr = new List<string>();
            //  arr.Add("Hello");
            //  arr.Add(null); // null
            //  arr.Add(""); // empty
            //  arr.Add(" ");// 1
            //  arr.Add("    "); // 3
            //  Console.WriteLine(arr.Count);
            //  foreach (var item in arr)
            //  {
            //      Console.WriteLine(item);
            //  }
            //  arr  = arr.FindAll(IsEmpty);
            //  Console.WriteLine("---------------------");
            //  Console.WriteLine(arr.Count);

            //  foreach (var item in arr)
            //  {
            //      Console.WriteLine(item);
            //  }


        }
    }
}