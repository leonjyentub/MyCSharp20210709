using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    class Program
    {
        static void changeArray(ref int[] arr)
        {
            arr = new int[] { 30, 40, 20, -10 };
            for(int i=0;i< arr.Length;i++)
            {
                arr[i] *= -1;
            }
        }
        static void Main(string[] args)
        {
            int[] data = { 0, 1, 2 };
            changeArray(ref data);
            foreach(int d in data)
            {
                Console.WriteLine()
            }
            Console.ReadKey();
        }
    }
}
