﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueEx
{
    // Queue : 선입선출(FIFO)의 자료구조
    //  - Enqueue : 데이터 입력
    //  - Dequeue : 데이터 출력
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(100);
            q.Enqueue(200);
            q.Dequeue();
            q.Enqueue(22.5);
            // object aa = (int)q.Dequeue();
            q.Enqueue("가나다");

            while(q.Count > 0)
                Console.WriteLine(q.Dequeue());
            
        }
    }
}
