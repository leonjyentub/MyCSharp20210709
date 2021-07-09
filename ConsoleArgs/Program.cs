using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArgs
{
    class Program
    {
        /**
         * swap函數，會把兩個整數的值進行交換，並且回傳加總的結果
         */
        static int swap(ref int a, ref int b)
        {
            Console.WriteLine($"1. a = {a}, b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"2. a = {a}, b = {b}");
            return a + b;
        }
        static int swap2(int a, int b)
        {
            Console.WriteLine($"1. a = {a}, b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"2. a = {a}, b = {b}");
            return a + b;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c = swap(ref a, ref b);
            int c2 = swap2(a, b);
            Console.WriteLine($"3. a = {a}, b = {b}, c = {c}");
            Console.ReadKey();
        }
    }
}
