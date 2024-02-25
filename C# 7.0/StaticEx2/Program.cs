using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEx2
{
    class MyClass
    {
        public static int Global_Count = 0;
    }

    class DemoClass1
    {
        public DemoClass1()
        {
            MyClass.Global_Count++;
        }
    }

    class DemoClass2
    {
        public DemoClass2()
        {
            MyClass.Global_Count++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"(Global_Count : {MyClass.Global_Count})");
            new DemoClass1();
            new DemoClass1();
            new DemoClass2();

            Console.WriteLine($"(Global_Count : {MyClass.Global_Count})");
        }
    }
}
