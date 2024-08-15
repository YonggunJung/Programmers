﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 최빈값_구하기
    {
        //문제 설명
        //최빈값은 주어진 값 중에서 가장 자주 나오는 값을 의미합니다.
        //정수 배열 array가 매개변수로 주어질 때,
        //최빈값을 return 하도록 solution 함수를 완성해보세요.
        //최빈값이 여러 개면 -1을 return 합니다.

        //제한사항
        //0 < array의 길이 < 100
        //0 ≤ array의 원소 < 1000

        //입출력 예
        //array                     result
        //[1, 2, 3, 3, 3, 4]            3
        //[1, 1, 2, 2]                 -1
        //[1]                           1

        //입출력 예 설명
        //입출력 예 #1
        //[1, 2, 3, 3, 3, 4] 에서 1은 1개 2는 1개 3은 3개 4는 1개로 최빈값은 3입니다.

        //입출력 예 #2
        //[1, 1, 2, 2] 에서 1은 2개 2는 2개로 최빈값이 1, 2입니다.최빈값이 여러 개이므로 -1을 return 합니다.

        //입출력 예 #3
        //[1] 에는 1만 있으므로 최빈값은 1입니다.
        public int solution212(int[] array)
        {
            int answer = 0;
            int before = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int count = array.Count(x => x == array[i]);
                if (before < count || answer == array[i])
                {
                    before = count;
                    answer = array[i];
                }
                else if (before == count)
                {
                    answer = -1;
                }
            }

            return answer;

            // 이거 왜 안될까 ㅠㅠ
            //int s = 0;
            //List<int> li = new List<int>(array.Distinct().ToList());
            //List<int> li2 = new List<int>();
            //for (int i = 0; i < li.Count; i++)
            //{
            //    li2.Add(array.Count(n => n == li[i]));
            //}
            //int max = li2.Max();
            //int maxidx = li.IndexOf(max);
            //answer = array[maxidx];

            //for (int i = 0; i < li2.Count; i++)
            //{
            //    if (li2[i] >= max)
            //        s++;
            //}
            //if (s >= 2)
            //    answer = -1;

            //if (array.Length == 1)
            //    answer = array[0];
        }
    }
}
