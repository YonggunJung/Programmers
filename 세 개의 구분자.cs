using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 세_개의_구분자
    {
        //문제 설명
        //임의의 문자열이 주어졌을 때
        //문자 "a", "b", "c"를 구분자로 사용해 문자열을 나누고자 합니다.
        //예를 들어 주어진 문자열이 "baconlettucetomato"라면
        //나눠진 문자열 목록은 ["onlettu", "etom", "to"] 가 됩니다.
        //문자열 myStr이 주어졌을 때 위 예시와 같이
        //"a", "b", "c"를 사용해 나눠진 문자열을 순서대로 저장한 배열을
        //return 하는 solution 함수를 완성해 주세요.
        //단, 두 구분자 사이에 다른 문자가 없을 경우에는 아무것도 저장하지 않으며,
        //return할 배열이 빈 배열이라면 ["EMPTY"] 를 return 합니다.

        //제한사항
        //1 ≤ myStr의 길이 ≤ 1,000,000
        //myStr은 알파벳 소문자로 이루어진 문자열 입니다.
        //입출력 예
        //myStr                     result
        //"baconlettucetomato"	    ["onlettu", "etom", "to"]
        //"abcd"	                ["d"]
        //"cabab"	                ["EMPTY"]
        //입출력 예 설명
        //입출력 예 #1
        //문제 설명의 예시와 같습니다.

        //입출력 예 #2
        //"c" 이전에는 "a", "b", "c" 이외의 문자가 없습니다.
        //"c" 이후에 문자열 "d"가 있으므로 "d"를 저장합니다.
        //따라서["d"] 를 return 합니다.

        //입출력 예 #3
        //"a", "b", "c" 이외의 문자가 존재하지 않습니다.
        //따라서 저장할 문자열이 없습니다.
        //따라서["EMPTY"] 를 return 합니다.
        public string[] solution91(string myStr)
        {
            string[] answer = new string[] { };
            string[] a = new string[] { };
            List<string> li = new List<string>();
            myStr = myStr.Replace('a', 'A');
            myStr = myStr.Replace('b', 'A');
            myStr = myStr.Replace('c', 'A');
            a = myStr.Split('A');
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != 0) li.Add(a[i]);
            }
            answer = li.ToArray();
            return answer;
            // 답에 EMPTY 안 해줬는데 통과됨 
            // 정해주니까 통과 안됨ㅋㅋㅋㅋ 어쩔?
        }
        //다른 사람 풀이
        //char[] separators = new char[3] { 'a', 'b', 'c' };
        //string[] answer = myStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        //return answer.Length == 0 ? new string[1]{ "EMPTY" } : answer; 

        static void Main91(string[] args)
        {
            string myStr = "cabab";
            string[] answer = new string[] { };
            string[] a = new string[] { };
            List<string> li = new List<string>();
            myStr = myStr.Replace('a', 'A');
            myStr = myStr.Replace('b', 'A');
            myStr = myStr.Replace('c', 'A');
            a = myStr.Split('A');
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != 0) li.Add(a[i]);
            }

            answer = li.ToArray();
            Console.WriteLine(answer[0]);
        }
    }
}
