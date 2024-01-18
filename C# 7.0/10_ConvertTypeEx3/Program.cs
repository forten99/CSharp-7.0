using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ConvertTypeEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             부호있는 정수형과 부호없는 정수형 사이의 형변환
             byte, sbyte
             
             int uint, short ushort, long ulong
             */

            //byte bb = 255;

            //sbyte sb = (sbyte)bb;

            //Console.WriteLine(bb);
            //Console.WriteLine(sb);

            //Console.ReadKey();

            int ia = 600;
            Console.WriteLine(ia);

            uint ua = (uint)ia;
            Console.WriteLine(ua);


            int iaa = -40;
            Console.WriteLine(iaa);

            uint uaa = (uint)iaa;
            Console.WriteLine(uaa);

            Console.ReadKey();
        }
    }
}
