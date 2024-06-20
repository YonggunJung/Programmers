using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 문자열_정수의_합
    {
        //문제 설명
        //한 자리 정수로 이루어진 문자열 num_str이 주어질 때,
        //각 자리수의 합을 return하도록 solution 함수를 완성해주세요.

        //제한사항
        //3 ≤ num_str ≤ 100

        //입출력 예
        //num_str           result
        //"123456789"	    45
        //"1000000"	        1

        //입출력 예 설명
        //입출력 예 #1
        //문자열 안의 모든 숫자를 더하면 45가 됩니다.

        //입출력 예 #2
        //문자열 안의 모든 숫자를 더하면 1이 됩니다.
        public int solution104(string num_str)
        {
            int answer = 0;
            foreach (char c in num_str)
            {
                answer += (int)c - '0';
            }
            return answer;
        }

        //다른 사람 풀이
        //return num_str.Select(s => s - '0').Sum();
    }
}
