﻿namespace src
{
    internal class Program
    {
        //task1
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number <= 999 && number >= 100)
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine(counter);
        //}

        //task2
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number % 2 == 0)
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine(counter);
        //}

        //task3
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number % 2 != 0)
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine(counter);
        //}

        //task4
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number % 3 == 0 || number % 7 == 0)
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine(counter);
        //}

        //task5
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    var sum = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number <= 99 && number >= 10 && number % 2 != 0)
        //        {
        //            counter++;
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine($"miqdori: {counter} \nyig'indisi: {sum}");
        //}

        //task6
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var temp = elements[0];
        //    elements[0] = elements[length - 1];
        //    elements[length - 1] = temp;
        //    Print(elements);
        //}

        //task7
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var firstTripleSum = elements[0] + elements[1] + elements[2];
        //    Console.WriteLine(firstTripleSum);
        //}

        //task8
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var firstTripleSum = elements[length - 1] + elements[length - 2] + elements[length - 3];
        //    Console.WriteLine(firstTripleSum);
        //}

        //task9
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var countOdd = 0;
        //    var countEven = 0;
        //    foreach (var element in elements)
        //    {
        //        if (element % 2 == 0)
        //        {
        //            countOdd++;
        //        }
        //        else
        //        {
        //            countEven++;
        //        }
        //    }
        //    if (countEven > countOdd)
        //    {
        //        Console.WriteLine(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //    }
        //}

        //task10
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    for (int i = 0; i < length; i++)
        //    {
        //        if (elements[i] % 2 == 0)
        //        {
        //            elements[i] *= 3;
        //        }
        //    }
        //    Print(elements);
        //}

        //task11
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var test = true;
        //    foreach (var element in elements)
        //    {
        //        if (element % 5 != 0)
        //        {
        //            test = false;
        //            break;
        //        }
        //    }
        //    Console.WriteLine(test);
        //}

        //task12
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var firstElement = elements[0] >= 10 && elements[0] <= 99;
        //    var secondElement = elements[1] >= 10 && elements[1] <= 99;
        //    var thirdElement = elements[2] >= 10 && elements[2] <= 99;
        //Console.WriteLine(firstElement is true && secondElement is true && thirdElement is true);
        //}

        //task13
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var firstTwoElements = elements[0] % 2 == 0 && elements[1] % 2 == 0;
        //    var lastTwoElements = elements[length - 1] % 2 != 0 && elements[length - 2] % 2 != 0;
        //    Console.WriteLine(firstTwoElements is true && lastTwoElements is true);
        //}

        //task14
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    elements.Sort();
        //    Console.WriteLine(elements[0]);
        //}


        public static void FillList(List<int> digits, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i}: ");
                var number = int.Parse(Console.ReadLine());
                digits.Add(number);
            }
        }

        public static void Print(List<int> numbers)
        {
            foreach (var digit in numbers)
            {
                Console.WriteLine(digit);
            }
        }
    }
}
