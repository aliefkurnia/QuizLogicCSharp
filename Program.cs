using System;
using System.Globalization;
using System.Collections.Generic;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nomor 1
            //Console.Write("Enter Number Integer: ");
            //var input = Console.ReadLine();
            //int[] arrayInput = input.Select(x => int.Parse(x.ToString())).ToArray();
            //int jumlah = arrayInput.Sum();
            //Console.WriteLine("Total Sum : " + jumlah);

            //Nomor 2
            //Console.Write("Enter Number Integer: ");
            //var input = Console.ReadLine();
            //int[] arrayInput = input.Select(x => int.Parse(x.ToString())).ToArray();
            //int jumlah = arrayInput.Count();
            //Console.WriteLine("Total Count : " + jumlah);

            //Nomor 3
            //Console.Write("Enter Number Integer: ");
            //var input = Console.ReadLine();
            //int[] arrayInput =input.Select(x => int.Parse(x.ToString())).ToArray();
            //foreach (var item in arrayInput.Reverse())
            //{
            //    Console.Write($"{item} ");
            //}


            //Nomor 4
            //int max = int.MinValue;
            //while (true)
            //{
            //    Console.Write("Enter Integer [Type 0 to exit] : ");
            //    int input = int.Parse(Console.ReadLine());
            //    if (input == 0)
            //    {
            //        break;
            //    }
            //    if (input > max)
            //    {
            //        max = input; 
            //    }
            //}
            //        Console.WriteLine("Angka Terbesar : " + max);

            //Nomor 5
            //Console.Write("Enter Number Integer: ");
            //int input = int.Parse(Console.ReadLine());
            //for (int i = 1; i < input; i++)
            //{
            //    if(input % i == 0)
            //    Console.Write(i + " ");
            //}


            //Nomor 6
            //Console.Write("Enter limit number: ");
            //int range = int.Parse(Console.ReadLine());
            //for (int i = 2; i < range; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //        Console.Write($"{i}  ");

            ///Nomor 7
            //Console.Write("Enter Strings: ");
            //string input;
            //input=Console.ReadLine();
            //string[] kata = input.Split(' ');

            //for (int i = 0; i < kata.Length; i++)
            //{
            //    kata[i] = kata[i][0] + new string('*', kata[i].Length - 2) + kata[i][kata[i].Length - 1]; 
            //}

            //foreach (string k in kata)
            //{
            //    Console.Write(k + " ");
            //}

            //Nomor 8
            //int sabtu = Convert.ToInt32(DayOfWeek.Saturday);
            // int hariini = Convert.ToInt32(DateTime.Today.DayOfWeek);
            // int hasil = (sabtu - hariini+7)%7;
            // Console.Write("Hari Sabtu: ");
            // Console.WriteLine(DateTime.Today.AddDays(hasil).ToShortDateString());
            // Console.WriteLine($"{hasil} Hari Lagi");

            //Nomor 9
            //string inputString;
            //string findString;
            //Console.Write("Enter String: ");
            //inputString = Console.ReadLine();
            //Console.Write("Find String: ");
            //findString = Console.ReadLine();
            //int count = 0;
            //int index = inputString.IndexOf(findString);
            //while (index != -1)
            //{
            //    count++;
            //    index = inputString.IndexOf(findString, index + findString.Length);
            //}
            //Console.WriteLine("Total kata yang muncul: " + count + " dari text: "+ inputString);

            //Nomor 10
            //int[] numbers = new int[5];
            //int firstGreatest, secondGreatest;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter number {0}: ", i + 1);
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //firstGreatest = numbers[0];
            //secondGreatest = numbers[0];
            //for (int i = 1; i < 5; i++)
            //{
            //    if (numbers[i] > firstGreatest)
            //    {
            //        secondGreatest = firstGreatest;
            //        firstGreatest = numbers[i];
            //    }
            //    else if (numbers[i] > secondGreatest && numbers[i] != firstGreatest)
            //    {
            //        secondGreatest = numbers[i];
            //    }
            //}
            //Console.WriteLine("Second greatest: ", secondGreatest);

            //Nomor 11
            Console.Write(CheckKurawal("{}}"));

            //Nomor 12
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 10; j >= 5 + i; j--)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("====================================================");
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + i - 1 + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("====================================================");

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 3; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("====================================================");
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5 - i; j++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

        }


        public static bool CheckKurawal(string input)
        {
            int count = 0;
            foreach (var item in input)
            {
                if (item == '{')
                    count++;
                if (item == '}')
                    count--;
                if (count < 0)
                    return false;
            }
            return true;

        }
    }
}  





