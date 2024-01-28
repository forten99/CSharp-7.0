using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 메소드 오버로딩 : 하나의 메소드 이름으로 여러 개의 기능을 구현할 수 있도록 하는 것
            int a = Sum(1, 2);
            int b = Sum(1, 2, 3);
            double c = Sum(1.1, 10);
            double d = Sum(11, 1.1);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        static int Sum(int i, int j)
        {
            Console.WriteLine(" Sum(int i, int j) 메소드 호출하기");
            return i + j;
        }

        static int Sum(int i, int j, int k)
        {
            Console.WriteLine(" Sum(int i, int j, int k) 메소드 호출하기");
            return (i + j + k);
        }

        static double Sum(double m, int n)
        {
            Console.WriteLine(" Sum(double m, int n) 메소드 호출하기");
            return m + n;
        }
        static double Sum(int m, double n)
        {
            Console.WriteLine(" Sum(int m, double n) 메소드 호출하기");
            return m + n;
        }

    }
}
