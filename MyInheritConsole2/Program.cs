using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritConsole2
{
    class A
    {
        public void Method_1()
        {
            Console.WriteLine("A-Method_1 running");
        }

        public virtual void Method_2()
        {
            Console.WriteLine("A-Method_2 running");
        }
    }

    class B : A
    {
        public new void Method_1()
        {
            Console.WriteLine("B-Method_1 running");
        }
        public override void Method_2()
        {
            Console.WriteLine("B-Method_2 running");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Method_1();
            a.Method_2();
            B b = new B();
            b.Method_1();
            b.Method_2();
            A c = new B();
            c.Method_1();
            c.Method_2();
            Console.ReadKey();
        }
    }
}
