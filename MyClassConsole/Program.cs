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
            MyClass my = new MyClass()
            {
                Name = "JJ",
                Score = 60
            };

            MyClass mate = new MyClass("John", 100);
            my.HelloWorldTest();
            mate.HelloWorldTest();
            Console.ReadKey();
        }
    }
}
