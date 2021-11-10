using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Random rand = new Random();
        Console.WriteLine("Сколько чисел вывести?");
        string s = Console.ReadLine();
        int a = Convert.ToInt32(s);
        for (int i = 0; i < a; i++)
        {
            string stepValue = Convert.ToInt32(Math.Pow(a, 2)).ToString();
            int startIndex = stepValue.Length / 4;
            int b = a.ToString().Length;            
            Console.WriteLine(rand.Next(100));
        }
    }
}