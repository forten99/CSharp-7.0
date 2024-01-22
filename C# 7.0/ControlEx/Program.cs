using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("----------- 메뉴 -----------");
                Console.WriteLine();
                Console.WriteLine("1. 사이다");
                Console.WriteLine("2. 콜라");
                Console.WriteLine("3. 오렌지주스");
                Console.WriteLine("4. 커피");
                Console.WriteLine();

                Console.Write("메뉴 번호를 입력하세요(종료는 Q를 누르세요 ==> ");
                string answer = Console.ReadLine();

                if (answer == "Q" || answer == "q") break;

                if (answer == "1") Console.WriteLine("사이다 가격 : 1,000원");
                else if (answer == "2") Console.WriteLine("콜라 가격 : 1,200원");
                else if (answer == "3") Console.WriteLine("오렌지주스 가격 : 2,000원");
                else if (answer == "4") Console.WriteLine("커피 가격 : 2,000원");
                else Console.WriteLine("잘못 입력하셨습니다.");
            }
        }
    }
}
