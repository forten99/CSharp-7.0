using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OperatorEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트연산자 (쉬프트, &, |, ^)

            Console.WriteLine("---------- 쉬프트 연산 ----------");
            // 특정 형식에 맞춰 출력하는 포맷팅(Formattion) 기능
            int aa = 1, bb = 2, cc = 3;
            //Console.WriteLine("aa:{0} bb:{1} cc:{2}", aa, bb, cc);

            //int a = 100;
            //Console.WriteLine("{0:C}", a );
            int a = 1;
            Console.WriteLine("{0:D3} 0x{0:X8}", a);
            Console.WriteLine("{0:D3} 0x{0:X8}", a << 1);
            Console.WriteLine("{0:D3} 0x{0:X8}", a << 5);

            int b = 255;
            Console.WriteLine("{0:D3} 0x{0:X8}", b);
            Console.WriteLine("{0:D3} 0x{0:X8}", b >> 1);
            Console.WriteLine("{0:D3} 0x{0:X8}", b >> 2);
            Console.WriteLine("{0:D3} 0x{0:X8}", b >> 3);
            Console.WriteLine("{0:D3} 0x{0:X8}", b >> 4);
            Console.WriteLine("{0:D3} 0x{0:X8}", b >> 5);
            Console.WriteLine("{0:D3} 0x{0:X8}", b >> 6);
            Console.WriteLine("{0:D3} 0x{0:X8}", b >> 7);
            Console.WriteLine("{0:D3} 0x{0:X8}", b >> 8);

            int c = -255;
            Console.WriteLine("{0:D3} 0x{0:X8}", c);
            Console.WriteLine("{0:D3} 0x{0:X8}", c>>1);

            int x = 9;
            int y = 10;
            Console.WriteLine(x & y);
            Console.WriteLine(x | y);
            Console.WriteLine(x ^ y);

            // ~ : 보수 연산자(1, 0을 서로 뒤바꾸는 연산자)
            int xx = 255;
            Console.WriteLine("{0:D3} 0x{0:X8}", xx);
            Console.WriteLine("{0:D3} 0x{0:X8}", ~xx);
        }
    }
}
