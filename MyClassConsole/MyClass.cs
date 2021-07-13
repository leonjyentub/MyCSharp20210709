using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassConsole
{
    class MyClass
    {
        private int a;

        public int A { get; set; }
        public void HelloWorldTest()
        {
            Console.WriteLine($"A = {this.A}");
        }
    }
}
