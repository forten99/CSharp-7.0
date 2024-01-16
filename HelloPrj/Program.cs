using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPrj
{
    internal class Program
    {
        // 프로그램의 시작과 끝
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello C#!!");
            //Console.WriteLine(args.Length);


            Console.WriteLine("Hello!!" + args[0]);

            foreach (string str in args)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
