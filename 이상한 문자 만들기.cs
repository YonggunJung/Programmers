using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 이상한_문자_만들기
    {
        //문제 설명
        //문자열 s는 한 개 이상의 단어로 구성되어 있습니다.
        //각 단어는 하나 이상의 공백문자로 구분되어 있습니다.
        //각 단어의 짝수번째 알파벳은 대문자로,
        //홀수번째 알파벳은 소문자로 바꾼 문자열을 리턴하는 함수,
        //solution을 완성하세요.

        //제한 사항
        //문자열 전체의 짝/홀수 인덱스가 아니라, 단어(공백을 기준) 별로 짝/홀수 인덱스를 판단해야합니다.
        //첫 번째 글자는 0번째 인덱스로 보아 짝수번째 알파벳으로 처리해야 합니다.

        //입출력 예
        //s                             return
        //"try hello world"	            "TrY HeLlO WoRlD"

        //입출력 예 설명
        //"try hello world"는 세 단어 "try", "hello", "world"로 구성되어 있습니다.
        //각 단어의 짝수번째 문자를 대문자로,
        //홀수번째 문자를 소문자로 바꾸면 "TrY", "HeLlO", "WoRlD"입니다.
        //따라서 "TrY HeLlO WoRlD" 를 리턴합니다.
        public string solution33(string s)
        {
            string answer = "";
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                answer += num % 2 == 0 ? char.ToUpper(s[i]) : char.ToLower(s[i]);
                num = s[i] == ' ' ? 0 : num += 1;
            }
            return answer;
        }

        static void Main33(string[] args)
        {
            // 이게 왜 안되는지 모르겠음 ㅠㅠ
            string answer = "";
            string s = "TRy HElLo  WORLD";
            string[] word = s.Split(' ');
            foreach (string str in word)
            {
                for (int i = 0;i < str.Length; i++)
                {
                    if (i % 2 == 0) answer += char.ToUpper(str[i]);
                    else answer += char.ToLower(str[i]);
                }
                answer += ' ';
                Console.WriteLine(answer);
            }
        }
    }
    
}
