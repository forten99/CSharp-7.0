using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_SwitchEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Switch 문
                
                switch (조건식)
                {
                case 상수1 : 
                    실행코드
                    break;
                case 상수2 :
                    실행코드
                    break;
                case 상수3 :
                    실행코드
                    break;
                case 상수4 :
                    실행코드
                    break;
                default:
                    실행코드
                    break;
                }
            */

            Console.Write("요일을 입력하세요(월, 화, 수, 목, 금, 토, 일) : ");
            string weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "월":
                    Console.WriteLine("Monday");
                    break;
                case "화":
                    Console.WriteLine("Tuesday");
                    break;
                case "수":
                    Console.WriteLine("Wednesday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friay");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                case "일":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("요일을 입력하세요!!!!");
                    break;

            }
            
        }
    }
}
