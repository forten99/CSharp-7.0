using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int count, int sum, double average) GetAverage(List<int> data) // 튜플 리턴타입
            {
                int cnt = 0, sum = 0;
                double avg = 0;

                foreach(var i in data)
                {
                    cnt++;
                    sum += i;
                }

                avg = sum / cnt;
                return (cnt, sum, avg);
            }

            var dataList = new List<int> { 10, 11, 22, 33, 44 };

            var result = GetAverage(dataList);

            Console.WriteLine($"{result.count}, {result.sum}, {result.average}");
            Console.WriteLine($"{result.Item1}, {result.Item2}, {result.Item3}");
        }
    }
}
