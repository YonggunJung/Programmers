using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 문자열_곱하기
    {
        //문제 설명
        //문자열 my_string과 정수 k가 주어질 때, 
        //my_string을 k번 반복한 문자열을 return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //1 ≤ my_string의 길이 ≤ 100
        //my_string은 영소문자로만 이루어져 있습니다.
        //1 ≤ k ≤ 100

        //입출력 예
        //my_string     k       result
        //"string"	    3	    "stringstringstring"
        //"love"	    10	    "lovelovelovelovelovelovelovelovelovelove"

        //입출력 예 설명
        //입출력 예 #1
        //예제 1번의 my_string은 "string"이고
        //이를 3번 반복한 문자열은 "stringstringstring"이므로
        //이를 return 합니다.

        //입출력 예 #2
        //예제 2번의 my_string은 "love"이고
        //이를 10번 반복한 문자열은 "lovelovelovelovelovelovelovelovelovelove"이므로
        //이를 return 합니다.
        public string solution(string my_string, int k)
        {
            string answer = "";
            for (int i = 0; i<k; i++)
            {
                answer += my_string;
            }
            return answer;
        }
        //다른 사람 풀이
        //public string solution(string my_string, int k)
        //{
        //    return Enumerable.Range(0, k).Select(s => my_string).Aggregate((a, b) => a + b);
        //}

        //다른사람 풀이2
        //이거 괜찮아 보임 그런데 이러면 굳이 answer 정의 안해줘도 됨
        //public string solution(string my_string, int k)
        //{
        //    string answer = "";

        //    String repeat = String.Concat(Enumerable.Repeat(my_string, k));
        //    return repeat;


        }
}
