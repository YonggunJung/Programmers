using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 문자열이_몇_번_등장하는지_세기
    {
        //문제 설명
        //문자열 myString과 pat이 주어집니다.
        //myString에서 pat이 등장하는 횟수를
        //return 하는 solution 함수를 완성해 주세요.

        //제한사항
        //1 ≤ myString ≤ 1000
        //1 ≤ pat ≤ 10

        //입출력 예
        //myString      pat         result
        //"banana"	    "ana"	        2
        //"aaaa"	    "aa"	        3

        //입출력 예 설명
        //입출력 예 #1
        //"banana"에서 1 ~ 3번 인덱스에서 한 번,
        //3 ~ 5번 인덱스에서 또 한 번 "ana"가 등장해서 총 두 번 등장합니다.
        //따라서 2를 return 합니다.

        //입출력 예 #2
        //"aaaa"에서 0 ~ 2번 인덱스에서 한 번,
        //1 ~ 3번 인덱스에서 한 번,
        //2 ~ 4번 인덱스에서 한 번 "aa"가 등장해서 총 세 번 등장합니다.
        //따라서 3을 return 합니다.
        public int solution82(string myString, string pat)
        {
            int answer = 0;
            for (int i = 0; i < myString.Length; i++)
            {
                if (myString.Substring(i, pat.Length) == pat)
                    answer++;
            }
            return answer;
        }
        static void Main82(string[] args)
        {
            string myString = "banana";
            string pat = "ana";
            int answer = 0;
            for (int i = 0; i <= myString.Length- pat.Length; i++)
            {
                if (myString.Substring(i, pat.Length) == pat)
                    answer++;
            }

            //for (int i = myString.Length-1;  i >= 0; i--)
            //{
            //    if (myString[i] == pat[0] && myString.Substring(i, pat.Length) == pat)
            //        answer = myString.Substring(0, i+pat.Length);
            //}

            //Console.WriteLine(myString.Equals(pat));
            Console.WriteLine(answer);
        }
    }
}
