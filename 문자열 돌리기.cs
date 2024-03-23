using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 문자열_돌리기
    {
        static void Main8(string[] args)
        {
            //문제 설명
            //문자열 str이 주어집니다.
            //문자열을 시계방향으로 90도 돌려서 아래 입출력 예와 같이
            //출력하는 코드를 작성해 보세요.

            //제한사항
            //1 ≤ str의 길이 ≤ 10

            //입출력 예
            //입력 #1
            //abcde

            //출력 #1
            //a
            //b
            //c
            //d
            //e

            String s;
            Console.Clear();
            s = Console.ReadLine();
            for (int i = 0; i<s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

        }
        // 다른사람 풀이
        // 아직 모르는 방법인데 대충 이해는 감
        //char[] input = Console.ReadLine().ToCharArray();
        //string output = string.Join("\n", input);
        //Console.WriteLine(output)
        // ===========================

        //다른 사람 풀이 2
        //for문이랑 foreach문 차이를 아직 잘 모르겠음
        //String s;
        //Console.Clear();
        //s = Console.ReadLine();
        //foreach(char c in s)
        //    Console.WriteLine(c);

    }
}
