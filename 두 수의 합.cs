using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Programmers
{
    internal class 두_수의_합
    {
        //문제 설명
        //0 이상의 두 정수가 문자열 a, b로 주어질 때,
        //a + b의 값을 문자열로 return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //1 ≤ a의 길이 ≤ 100,000
        //1 ≤ b의 길이 ≤ 100,000
        //a와 b는 숫자로만 이루어져 있습니다.
        //a와 b는 정수 0이 아니라면 0으로 시작하지 않습니다.

        //입출력 예
        //a                             b                       result
        //"582"	                    "734"	                    "1316"
        //"18446744073709551615"	"287346502836570928366"	    "305793246910280479981"
        //"0"	                    "0"	                        "0"

        //입출력 예 설명
        //입출력 예 #1
        //예제 1번의 a, b는 각각 582, 734이고 582 + 734 = 1316입니다.따라서 "1316"을 return 합니다.

        //입출력 예 #2
        //예제 2번의 a, b는 각각 18446744073709551615, 287346502836570928366이고
        //18446744073709551615 + 287346502836570928366 = 305793246910280479981입니다.
        //따라서 "305793246910280479981"을 return 합니다.

        //입출력 예 #3
        //예제 3번의 a, b는 각각 0, 0이고 0 + 0 = 0입니다.따라서 "0"을 return 합니다.
        public string solution107(string a, string b)
        {
            // 방법은 똑같은데 문자열을 어떻게 만드나 차이
            //StringBuilder 가 그냥 문자열보다 빠른듯
            StringBuilder answer = new StringBuilder();
            string longer = a;
            string shorter = b;

            if (a.Length < b.Length)
            {
                longer = b;
                shorter = a;
            }

            while (shorter.Length < longer.Length)
            {
                shorter = "0" + shorter;
            }

            int num = 0;
            for (int i = shorter.Length - 1; i >= 0; i--)
            {
                int n = ((int)shorter[i] - '0') + ((int)longer[i] - '0') + num;
                int n1 = n % 10;
                answer.Insert(0, n1);  // 앞에 삽입하는 방식으로 변경
                num = n / 10;
            }
            if (num != 0)
            {
                answer.Insert(0, num);  // 남은 캐리를 앞에 삽입
            }

            return answer.ToString();

            //이거를 StringBuilder()로 하면 됨
            //string answer = "";
            //string longer = a;
            //string shorter = b;

            //if (a.Length < b.Length)
            //{
            //    longer = b;
            //    shorter = a;
            //}

            //while (shorter.Length < longer.Length)
            //{
            //    shorter = "0" + shorter;
            //}

            //int num = 0;
            //for (int i = shorter.Length - 1; i >= 0; i--)
            //{
            //    int n = ((int)shorter[i] - '0') + ((int)longer[i] - '0') + num;
            //    int n1 = n % 10;
            //    answer = n1 + answer;
            //    num = n / 10;
            //}
            //if (num != 0) answer = num + answer;
            //return answer
        }
        //다른 사람 풀이


        static void Main107(string[] args)
        {
            //string a = "582";
            //string b = "734";
            string a = "18446744073709551615";
            string b = "287346502836570928366";
            //string a = "0";
            //string b = "0";

            string answer = "";
            string longer = a;
            string shorter = b;

            if (a.Length < b.Length)
            {
                longer = b;
                shorter = a;
            }

            while (shorter.Length < longer.Length)
            {
                shorter = "0" + shorter;
            }

            int num = 0;
            for (int i = shorter.Length-1; i >= 0; i--)
            {
                int n = ((int)shorter[i] - '0') + ((int)longer[i] - '0') + num;
                int n1 = n % 10;
                answer = n1 + answer;
                num = n / 10;
            }
            if (num != 0) answer = num + answer;
            //if (answer[0] == '0')
            //    answer = answer.Substring(1);
            //for (int i = 0; i < answer.Length - 1; i++)
            //{
            //    if (answer[i] == '0')
            //        answer = answer.Substring(i);
            //    else break;
            //}
            string x = "abcdef";
            string y = x.Substring(2);
            Console.WriteLine(answer);
            Console.WriteLine(y);
            //0305793246910280479981
            //0305793246910280479981
        }
    }
}
