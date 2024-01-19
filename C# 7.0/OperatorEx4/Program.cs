using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("{0:D3} 0x{0:X8}", a << 5);
            
        }
    }
}
