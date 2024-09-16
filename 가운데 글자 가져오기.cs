using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 가운데_글자_가져오기
    {
        //문제 설명
        //단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요.
        //단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.

        //재한사항
        //s는 길이가 1 이상, 100이하인 스트링입니다.

        //입출력 예
        //s                     return
        //"abcde"	            "c"
        //"qwer"	            "we"
        public string solution21(string s)
        {
            string answer = "";
            if (s.Length % 2 == 1)
                answer += s[s.Length/2];
            else
                answer = s.Substring(s.Length/2-1,2);
            return answer;
        }
        
        //다른사람 풀이
        // 깔끔하네
        //int n = (s.Length + 1) % 2;
        //int l = s.Length / 2 - n;
        //return s.Substring(l, n + 1);
    }
}
