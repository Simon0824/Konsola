using System;
using System.ComponentModel.Design;
namespace Zadanie
{
    class Mainik
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbe a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz liczbe b:");
            int b = int.Parse(Console.ReadLine());
            bool cos = true;
            while (cos = true)
            {
                if (a != b)
                {
                    if (a > b)
                    {
                        a /= a - b;
                        Console.WriteLine(a);
                        cos = false;
                    }
                    else
                    {
                        b /= b - a;
                        cos = true;
                    }
                }
                else
                {
                    Console.WriteLine(a);
                    cos = false;
                }
            }
        }
    }
}
