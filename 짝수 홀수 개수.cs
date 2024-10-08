﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 짝수_홀수_개수
    {
        //문제 설명
        //정수가 담긴 리스트 num_list가 주어질 때,
        //num_list의 원소 중 짝수와 홀수의 개수를 담은 배열을
        //return 하도록 solution 함수를 완성해보세요.

        //제한사항
        //1 ≤ num_list의 길이 ≤ 100
        //0 ≤ num_list의 원소 ≤ 1,000

        //입출력 예
        //num_list              result
        //[1, 2, 3, 4, 5]       [2, 3]
        //[1, 3, 5, 7]          [0, 4]

        //입출력 예 설명
        //입출력 예 #1
        //[1, 2, 3, 4, 5] 에는 짝수가 2, 4로 두 개, 홀수가 1, 3, 5로 세 개 있습니다.

        //입출력 예 #2
        //[1, 3, 5, 7] 에는 짝수가 없고 홀수가 네 개 있습니다.
        public int[] solution200(int[] num_list)
        {
            int[] answer = new int[2];
            int odd = 0;
            
            for (int i = 0; i<num_list.Length; i++)
            {
                if (num_list[i] % 2 == 1)
                    odd++;
            }
            answer[1] = odd;
            answer[0] = num_list.Length - odd;
            return answer;
        }
    }
}
