using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_IfElseEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* if문
             
            if (조건식)
            {
                조건식이 참인 경우 실행할 코드
            }

            */

            //int j = 100;

            //if ((j % 2) == 0)
            //    Console.WriteLine("짝수");
            //else
            //    Console.WriteLine("홀수");

            //int i = 0;

            //if (i < 0)
            //    Console.WriteLine("음수");
            //else if (i == 0)
            //    Console.WriteLine("0");
            //else
            //    Console.WriteLine("양수");

            // Console.ReadLine() : 사용자로부터 입력받은 문자열을 리턴함
            Console.Write("당신의 나이를 입력하세요 : ");
            string userAge = Console.ReadLine();
            int age = int.Parse(userAge);

            if (age > 18)
                Console.WriteLine("당신은 성인입니다.");
            else if (age >= 14)
                Console.WriteLine("당신은 청소년입니다.");
            else
                Console.WriteLine("당신은 소인입니다.");
        }
    }
}
