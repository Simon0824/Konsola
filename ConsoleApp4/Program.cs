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
            if (a != b)
            {
                if(a > b)
                {
                    a /= a - b;
                    Console.WriteLine(a);
                }
                else
                {
                    b /= b - a;
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
