using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //반복문(Loop) : while, do while, for, foreach


            /*
             while (조건식)
                반복실행 코드
             */
            //int i = 5;

            //while(i>0)
            //{
            //    Console.WriteLine(i);
            //    i -= 2;
            //}

            // do while문
            int ii = 5;
            do
            {
                Console.WriteLine(ii);
                ii -= 2;
            } while (ii > 0);

            /*
             * for(초기화; 조건식; 증강;)
             * {
             *      반복 실행 코드
             * }
             */

            Console.WriteLine("---------- for 문 ----------");
            for (int i=0; i<5; i++)
                Console.WriteLine(i);

            // 무한 반복문 : 무한히 반복되는 루프문
            // for(;;)
            //  반복 실행 코드

            // while(true)
            //  반복 실행 코드

            int aa = 0;
            while(true)
                Console.WriteLine(aa++);
        }
    }
}
