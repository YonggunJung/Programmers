using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 문자열로_변환
    {
        //문제 설명
        //정수 n이 주어질 때, n을 문자열로 변환하여
        //return하도록 solution 함수를 완성해주세요.

        //제한사항
        //1 ≤ n ≤ 10000

        //입출력 예
        //n             result
        //123	        "123"
        //2573	        "2573"

        //입출력 예 설명
        //입출력 예 #1
        //123을 문자열로 변환한 "123"을 return합니다.

        //입출력 예 #2
        //2573을 문자열로 변환한 "2573"을 return합니다.
        public string solution108(int n)
        {
            string answer = "";
            return answer + n;
        }
        //다른 사람 풀이
        //return n.ToString();
        //return string.Format("{0}",n)
    }
}
