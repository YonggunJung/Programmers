using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 문자열_섞기
    {
        //문제 설명
        //길이가 같은 두 문자열 str1과 str2가 주어집니다.

        //두 문자열의 각 문자가 앞에서부터 서로 번갈아가면서
        //한 번씩 등장하는 문자열을 만들어 return 하는 solution 함수를 완성해 주세요.

        //제한사항
        //1 ≤ str1의 길이 = str2의 길이 ≤ 10
        //str1과 str2는 알파벳 소문자로 이루어진 문자열입니다.

        //입출력 예
        //str1          str2        result
        //"aaaaa"	    "bbbbb"	    "ababababab"
        public string solution2(ref string str1, ref string str2)
        {
            string answer = "";
            for (int i = 0; i<str2.Length; i++)
            {
                answer += str1[i];
                answer += str2[i];
            }
            return answer;
        }
        // 다른사람 풀이 1
        // 저렇게도 되는구나 이제 알았으
        //for(int i=0;i<str1.Length;i++)
        //{answer += string.Format("{0}{1}", str1[i], str2[i]);}

        // Sb 사용도 가능

        // 이렇게 하면 되는구나 근데 왜 이렇게 해야 하는지는 모름
        //answer +=str1[i].ToString()+str2[i].ToString();
    }
}   
