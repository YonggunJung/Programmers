﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 자릿수_더하기
    {
        //문제 설명
        //정수 n이 매개변수로 주어질 때 n의 각 자리 숫자의 합을 return하도록 solution 함수를 완성해주세요

        //제한사항
        //0 ≤ n ≤ 1,000,000

        //입출력 예
        //n             result
        //1234	            10
        //930211	        16

        //입출력 예 설명
        //입출력 예 #1
        //1 + 2 + 3 + 4 = 10을 return합니다.

        //입출력 예 #2
        //9 + 3 + 0 + 2 + 1 + 1 = 16을 return합니다.
        public int solution137(int n)
        {
            int answer = 0;
            while (n > 0)
            {
                answer += n % 10;
                n /= 10;
            }
            return answer;
        }
        // 다른 사람 풀이
        // 이건 뭘까?
        //return n.ToString().Sum(x => Int32.Parse(x.ToString()));;
    }
}
