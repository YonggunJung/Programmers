using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 한_번만_등장한_문자
    {
        //문제 설명
        //문자열 s가 매개변수로 주어집니다.
        //s에서 한 번만 등장하는 문자를 사전 순으로 정렬한 문자열을
        //return 하도록 solution 함수를 완성해보세요. 한 번만 등장하는 문자가 없을 경우 빈 문자열을 return 합니다.

        //제한사항
        //0 < s의 길이 < 1,000
        //s는 소문자로만 이루어져 있습니다.

        //입출력 예
        //s                     result
        //"abcabcadc"	        "d"
        //"abdc"	            "abcd"
        //"hello"	            "eho"

        //입출력 예 설명
        //입출력 예 #1
        //"abcabcadc"에서 하나만 등장하는 문자는 "d"입니다.

        //입출력 예 #2
        //"abdc"에서 모든 문자가 한 번씩 등장하므로 사전 순으로 정렬한 "abcd"를 return 합니다.

        //입출력 예 #3
        //"hello"에서 한 번씩 등장한 문자는 "heo"이고 이를 사전 순으로 정렬한 "eho"를 return 합니다.
        public string solution145(string s)
        {
            // 생각보다 어려웠음
            string answer = "";
            string answer2 = "";
            foreach (char c in s)
            {
                if (s.Count(x => x == c) == 1) answer2 += c;
            }
            char[] ch = answer2.ToCharArray();
            Array.Sort(ch);
            for (int i = 0; i<ch.Length; i++)
            {
                answer += ch[i];
            }
            return answer;
        }
        // 다른 사람 풀이
        // 이런식으로 풀려고 했었지만 내 생각 만이 간단하진 않음
        //string answer = string.Concat(s.Where(x => s.Count(o => o == x) == 1).OrderBy(x => x));
    }
}
