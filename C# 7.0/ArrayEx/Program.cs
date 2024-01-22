using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ArrayEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열(Array) : 일련의 동일한 데이터 타입 요소들로 구성된 데이터 집합

            // 배열 선언 형식
            // 데이터형식[] 배열이름 = new 데이터형식[배열의 크기];

            // 1차원 배열
            // string[] members = new string[10];

            // string[] members = new stirng[3] {"kim", "lee", "park"}를 축약하면
            // string[] members = {"kim", "lee", "park"};

            // 2차원 배열
            // 선언 형식
            // 데이터 형식[,] 배열 이름 = new 데이터형식[2차원크기, 1차원크기]

            // string[,] depts = new string[2,2] {{"김과장", "영업부", {"박과장", "홍보부"}};
            // 위의 선언을 축약 --> string[,] depts = {{"김과장", "영업부", {"박과장", "홍보부"}};

            //int score1 = 77;
            //int score2 = 80;
            //int score3 = 90;
            //int score4 = 60;
            //int score5 = 88;

            //int sum = score1 + score2 + score3 + score4 + score5;

            //int[] score = new int[5] { 77, 80, 90, 60, 88 };
            //int[] score = { 77, 80, 90, 60, 88 };

            int[] score = new int[5];
            score[0] = 77;
            score[1] = 80;
            score[2] = 90;
            score[3] = 60;
            score[4] = 88;

            int sum = 0;

            //for(int i=0; i<score.Length; i++) 
            //    sum += score[i];

            // foreach문 사용
            // foreach( 데이터형식 변수명 in 배열/컬렉션 )
            //      반복 실행 코드

            foreach (int scoreData in score)
                sum += scoreData;

            Console.WriteLine(sum);

        }
    }
}
