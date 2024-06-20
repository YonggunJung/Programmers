using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 문자열을_정수로_변환하기
    {
        //문제 설명
        //숫자로만 이루어진 문자열 n_str이 주어질 때,
        //n_str을 정수로 변환하여 return하도록 solution 함수를 완성해주세요.

        //제한사항
        //1 ≤ n_str ≤ 5
        //n_str은 0부터 9까지의 정수 문자로만 이루어져 있습니다.

        //입출력 예
        //n_str                 result
        //"10"	                10
        //"8542"	            8542

        //입출력 예 설명
        //입출력 예 #1
        //"10"을 정수로 바꾸면 10입니다.

        //입출력 예 #2
        //"8542"를 정수로 바꾸면 8542입니다.
        public int solution105(string n_str)
        {
            int answer = int.Parse(n_str);

            return answer;
        }
    }
}
