using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class l로_만들기
    {
        //문제 설명
        //알파벳 소문자로 이루어진 문자열 myString이 주어집니다.
        //알파벳 순서에서 "l"보다 앞서는 모든 문자를 "l"로 바꾼 문자열을
        //return 하는 solution 함수를 완성해 주세요.

        //제한사항
        //1 ≤ myString ≤ 100,000
        //myString은 알파벳 소문자로 이루어진 문자열입니다.

        //입출력 예
        //myString              result
        //"abcdevwxyz"	        "lllllvwxyz"
        //"jjnnllkkmm"	        "llnnllllmm"

        //입출력 예 설명
        //입출력 예 #1
        //0 ~ 4번 인덱스의 문자 "a","b","c","d","e"는 각각 "l"보다 앞서는 문자입니다.
        //따라서 "l"로 고쳐줍니다.
        //그 외의 문자는 모두 "l"보다 앞서지 않는 문자입니다. 따라서 바꾸지 않습니다.
        //따라서 "lllllvwxyz"을 return 합니다.

        //입출력 예 #2
        //0번, 1번, 6번, 7번 인덱스의 문자 "j","j","k","k"는
        //각각 "l"보다 앞서는 문자입니다.따라서 "l"로 고쳐줍니다.
        //그 외의 문자는 모두 "l"보다 앞서지 않는 문자입니다.
        //따라서 바꾸지 않습니다.
        //따라서 "llnnllllmm"을 return 합니다.
        public string solution119(string myString)
        {
            string answer = "";
            foreach (char c in myString)
            {
                if (c < 'l') answer += "l";
                else answer += c;
            }
            
            return answer;
            // 시도 1
            //string str = "abcdefghijk";
            //for (int i = 0; i < myString.Length; i++)
            //{
            //    if (str.Contains(myString[i])) answer += "l";
            //    else answer += myString[i];
            //}
            //시도 2 둘다 왜 안되는지 모르겠음
            //string str = "abcdefghijk";
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < myString.Length; i++)
            //{
            //    if (str.Contains(myString[i])) sb.Append("l");
            //    else sb.Append(myString[i]);
            //}
            //answer = sb.ToString();
        }

        static void Main119(string[] args)
        {
            //string myString = "abcdevwxyz";
            
        }
    }
}
