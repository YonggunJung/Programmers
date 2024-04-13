using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    
    internal class 수_조작하기_1
    {
        //문제 설명
        //정수 n과 문자열 control이 주어집니다.
        //control은 "w", "a", "s", "d"의 4개의 문자로 이루어져 있으며,
        //control의 앞에서부터 순서대로 문자에 따라 n의 값을 바꿉니다.

        //"w" : n이 1 커집니다.
        //"s" : n이 1 작아집니다.
        //"d" : n이 10 커집니다.
        //"a" : n이 10 작아집니다.
        //위 규칙에 따라 n을 바꿨을 때 가장 마지막에 나오는 n의 값을 return 하는 solution 함수를 완성해 주세요.

        //제한사항
        //-100,000 ≤ n ≤ 100,000
        //1 ≤ control의 길이 ≤ 100,000
        //control은 알파벳 소문자 "w", "a", "s", "d"로 이루어진 문자열입니다.

        //입출력 예
        //n     control             result
        //0	    "wsdawsdassw"	      -1

        //입출력 예 설명
        //입출력 예 #1
        //수 n은 control에 따라 다음과 같은 순서로 변하게 됩니다.
        //0 → 1 → 0 → 10 → 0 → 1 → 0 → 10 → 0 → -1 → -2 → -1
        //따라서 -1을 return 합니다.
        public int solution25(int n, string control)
        {
            int answer = 0;
            foreach(char c in control)
            {
                if (c == 'w')
                    n += 1;
                else if (c == 's')
                    n -= 1;
                else if (c == 'd')
                    n += 10;
                else if (c == 'a')
                    n -= 10;
            }
            answer = n;
            return answer;
        }
        //다른 사람 풀이
      //  return control.Sum(c =>
      //  'w' == c? 1 :
      //  's' == c? -1 :
      //  'd' == c? 10 :
      //  'a' == c? -10 : 0
      //) + n;

        // switch case문도 많이 썻는데 그게 더 이득인가??
    }
}
