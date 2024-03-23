using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 홀짝_구분하기
    {
        static void Main9(string[] args)
        {
            //문제 설명
            //자연수 n이 입력으로 주어졌을 때 만약 n이 짝수이면 "n is even"을, 홀수이면 "n is odd"를 출력하는 코드를 작성해 보세요.

            //제한사항
            //1 ≤ n ≤ 1,000

            //입출력 예
            //입력 #1
            //100
            //출력 #1
            //100 is even

            //입력 #2
            //1
            //출력 #2
            //1 is odd

            string s;
            s = Console.ReadLine();

            int a = Int32.Parse(s);
            if (a % 2 == 0)
            {
                Console.Write("{0} is even", a);
            }
            else
            {
                Console.Write("{0} is odd", a);
            }

            // 다른 사람 풀이1
            //이런 방법 신박하게 좋은거 같음  뭐가 편해 보임
            //String[] s;
            //Console.Clear();
            //s = Console.ReadLine().Split(' ');
            //int a = Int32.Parse(s[0]);
            //string q = a.ToString() + (a % 2 == 0 ? " is even" : " is odd");
            //Console.WriteLine(q);
        }
    }
}
