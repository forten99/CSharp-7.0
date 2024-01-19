using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 논리연산자
            Console.WriteLine("-------------- AND ---------------");
            Console.WriteLine(10 > 5 && 10 < 100);
            Console.WriteLine(10 > 5 && 10 < 5);
            Console.WriteLine(10 < 5 && 10 > 9);
            Console.WriteLine(10 < 5 && 10 < 9);

            Console.WriteLine("-------------- OR ---------------");
            Console.WriteLine(10 > 5 || 10 < 100);
            Console.WriteLine(10 > 5 || 10 < 5);
            Console.WriteLine(10 < 5 || 10 > 9);
            Console.WriteLine(10 < 5 || 10 < 9);

            // ! (Not 연산자)
            Console.WriteLine("-------------- NOT ---------------");
            Console.WriteLine(!true);
            Console.WriteLine(!false);
        }
    }
}
