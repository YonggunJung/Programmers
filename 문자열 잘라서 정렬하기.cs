using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    //문제 설명
    //문자열 myString이 주어집니다.
    //"x"를 기준으로 해당 문자열을 잘라내 배열을 만든 후
    //사전순으로 정렬한 배열을 return 하는 solution 함수를 완성해 주세요.
    //단, 빈 문자열은 반환할 배열에 넣지 않습니다.

    //제한사항
    //1 ≤ myString ≤ 100,000
    //myString은 알파벳 소문자로 이루어진 문자열입니다.

    //입출력 예
    //myString              result
    //"axbxcxdx"	        ["a","b","c","d"]
    //"dxccxbbbxaaaa"	    ["aaaa","bbb","cc","d"]

    //입출력 예 설명
    //입출력 예 #1
    //myString을 "x"를 기준으로 자른 배열은 ["a","b","c","d"] 이며,
    //이 배열은 이미 사전순으로 정렬된 상태입니다. 따라서 해당 배열을 return 합니다.

    //입출력 예 #2
    //myString을 "x"를 기준으로 자른 배열은 ["d","cc","bbb","aaaa"] 이며,
    //이 배열을 사전순으로 정렬하면 ["aaaa","bbb","cc","d"] 입니다.
    //따라서 해당 배열을 return 합니다.
    internal class 문자열_잘라서_정렬하기
    {
        public string[] solution87(string myString)
        {
            string[] answer = new string[] { };
            string[] a = new string[] { };
            List<string> li = new List<string>();
            a = myString.Split('x');

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != 0) li.Add(a[i]);
            }
            answer = li.OrderBy(x => x).ToArray();
            return answer;
        }
        //다른 사람 풀이
        //return myString.Split('x', StringSplitOptions.RemoveEmptyEntries).OrderBy(o => o).ToArray();

        static void Main87(string[] args)
        {
            string myString = "dxccxbbbxxaaaa";
            string[] answer = new string[] { };
            string[] a = new string[] { };
            //while (myString[0] == 'x')
            //{
            //    myString = myString.Substring(1);
            //}
            //while (myString[myString.Length - 1] == 'x')
            //{
            //    myString = myString.Substring(0, myString.Length - 1);
            //}
            //Console.WriteLine(myString);
            //List<string> li = new List<string>(myString.Split('x'));
            List<string> li = new List<string>();
            a = myString.Split('x');

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != 0) li.Add(a[i]);
            }
            answer = li.OrderBy(x => x).ToArray();
            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);
            Console.WriteLine(answer[2]);
            Console.WriteLine(answer[3]);
            //Console.WriteLine(answer[4]);

        }
    }
}
