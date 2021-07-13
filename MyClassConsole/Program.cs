using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.A = 10;
            my.HelloWorldTest();
            Console.ReadKey();
        }
    }
}
