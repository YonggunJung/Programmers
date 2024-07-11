using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 숨어있는_숫자의_덧셈_2
    {
        //문제 설명
        //문자열 my_string이 매개변수로 주어집니다.
        //my_string은 소문자, 대문자, 자연수로만 구성되어있습니다.
        //my_string안의 자연수들의 합을 return하도록 solution 함수를 완성해주세요.

        //제한사항
        //1 ≤ my_string의 길이 ≤ 1,000
        //1 ≤ my_string 안의 자연수 ≤ 1000
        //연속된 수는 하나의 숫자로 간주합니다.
        //000123과 같이 0이 선행하는 경우는 없습니다.
        //문자열에 자연수가 없는 경우 0을 return 해주세요.

        //입출력 예
        //my_string                 result
        //"aAb1B2cC34oOp"	        37
        //"1a2b3c4d123Z"	        133

        //입출력 예 설명
        //입출력 예 #1
        //"aAb1B2cC34oOp"안의 자연수는 1, 2, 34 입니다.
        //따라서 1 + 2 + 34 = 37 을 return합니다.
        //입출력 예 #2
        //"1a2b3c4d123Z"안의 자연수는 1, 2, 3, 4, 123 입니다.
        //따라서 1 + 2 + 3 + 4 + 123 = 133 을 return합니다.
        public int solution168(string my_string)
        {
            int answer = 0;
            string temp = "0";
            foreach (var c in my_string)
            {
                if (char.IsNumber(c))
                    temp += c;
                else
                {
                    answer += Convert.ToInt32(temp);
                    temp = "0";
                }
            }
            answer += Convert.ToInt32(temp);
            return answer;
        }

        static void Main168(string[] args)
        {
            int answer = 0;
            string my_string = "aAb1B2cC34oOp";
            string s = "";
            string[] arr = new string[] { };
            //List<string> li = new List<string>();

            foreach (char c in my_string)
            {
                if ((65 <= (int)c && (int)c <= 90) || (97 <= (int)c && (int)c <= 122))
                    s += "";
                else s += c;
            }
            arr = s.Split(' ');
            Console.WriteLine(arr[1]);
            for (int i = 0; i < arr.Length; i++)
            {
                if (!string.IsNullOrEmpty(arr[i])) answer += int.Parse(arr[i]);
            }
        }
    }
}
