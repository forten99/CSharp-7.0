using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 매개변수
            //int a = 100;
            //int b = 200;

            //int res = Multiply(a, b);

            //Console.WriteLine(res);

            int aa = 100;
            int bb = 111;

            Console.WriteLine("aa : {0}, bb:{1}", aa, bb);
            Swap(ref aa, ref bb);
            Console.WriteLine("aa : {0}, bb:{1}", aa, bb);
        }

        // 참조에 의한 매개변수 전달
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //static int Multiply(int x, int y)
        //{
        //    int result = x * y;
        //    return result;
        //}
    }
}
