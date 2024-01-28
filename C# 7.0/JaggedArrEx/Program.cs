using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 가변배열(Jagged Array)

            // 선언 형식
            // 데이터 형식 [][] 배열이름 = new 데이터형식[가변배열의 크기][];

            //int[][] arr = new int[3][];
            //arr[0] = new int[5] { 1, 2, 3, 4, 5 };
            //arr[1] = new int[3] { 11, 22, 33 };
            //arr[2] = new int[2] { 20, 30 };

            //int[][] arr2 = new int[2][];
            //arr2[0] = new int[6]{ 11,122,222,3333,4444,5454};
            //arr2[1] = new int[3] { 1, 2, 3 };

            int[][] jArr = new int[3][];

            jArr[0] = new int[4] { 1, 2, 3, 4 };
            jArr[1] = new int[] { 10, 11, 12, 22, 33, 44 };
            jArr[2] = new int[] { 20, 30 };

            foreach (int[] arr in jArr)
            {
                Console.Write("배열의 크기(길이) : {0}, >>> ", arr.Length);
                foreach(int element in arr)
                {
                    Console.Write("{0} ",element);
                }
                Console.WriteLine();
            }

            string[][] jArr2 = new string[2][] {
                new string[] {"홍길동", "임꺽정"},
                new string[] {"김말똥", "강길동", "고길동", "홍길동"}
            };

            foreach (string[] strArr in jArr2)
            {
                Console.Write("배열의 크기(길이) : {0}, >>> ", strArr.Length);
                foreach(string element in strArr)
                {
                    Console.Write("{0}, ", element);
                }
                Console.WriteLine() ;
            }

        }
    }
}
