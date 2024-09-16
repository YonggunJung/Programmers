using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 문자열_내림차순으로_배치하기
    {
        //문제 설명
        //문자열 s에 나타나는 문자를 큰것부터 작은 순으로 정렬해 새로운 문자열을 리턴하는 함수,
        //solution을 완성해주세요.
        //s는 영문 대소문자로만 구성되어 있으며,
        //대문자는 소문자보다 작은 것으로 간주합니다.

        //제한 사항
        //str은 길이 1 이상인 문자열입니다.

        //입출력 예
        //s	                return
        //"Zbcdefg"	        "gfedcbZ"
        public string solution24(string s)
        {
            string answer = "";
            char[] chars = s.ToCharArray();
            Array.Sort(chars, (x, y) => y.CompareTo(x));
            answer = new string(chars);
            return answer;
        }

        //다른사람 풀이
        // 이건 생각지도 못했네
        //string answer = string.Concat(s.OrderByDescending(m => m));
    }
}
