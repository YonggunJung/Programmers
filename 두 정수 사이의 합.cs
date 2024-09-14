using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 두_정수_사이의_합
    {
        //문제 설명
        //두 정수 a, b가 주어졌을 때
        //a와 b 사이에 속한 모든 정수의 합을 리턴하는 함수, solution을 완성하세요.
        //예를 들어 a = 3, b = 5인 경우, 3 + 4 + 5 = 12이므로 12를 리턴합니다.

        //제한 조건
        //a와 b가 같은 경우는 둘 중 아무 수나 리턴하세요.
        //a와 b는 -10,000,000 이상 10,000,000 이하인 정수입니다.
        //a와 b의 대소관계는 정해져있지 않습니다.

        //입출력 예
        //a     b	    return
        //3	    5	    12
        //3	    3	    3
        //5	    3	    12
        public long solution12(int a, int b)
        {
            long answer = 0;
            int temp = 0;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            for (long i = a; i <= b; i++)
            {
                answer += i;
            }
            return answer;
        }
        //다른사람 풀이
        // 다양한 수식이 나오는군
        //while (a != b)
        //{
        //    answer += a;
        //    a = (a > b) ? a - 1 : a + 1;
        //}
        //return answer + b;
        //다른사람 풀이2
        //return ((long)(Math.Abs(a - b) + 1) * (a + b)) / 2;
    }
}
