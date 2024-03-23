using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 문자열_붙여서_출력하기
    {
        static void Main(string[] args)
        {
            //문제 설명
            //두 개의 문자열 str1, str2가 공백으로 구분되어 입력으로 주어집니다.
            //입출력 예와 같이 str1과 str2을 이어서 출력하는 코드를 작성해 보세요.

            //제한사항
            //1 ≤ str1, str2의 길이 ≤ 10

            //입출력 예
            //입력 #1
            //apple pen

            //출력 #1
            //applepen

            //입력 #2
            //Hello World!

            //출력 #2
            //HelloWorld!

            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            String s2 = input[1];

            Console.WriteLine(s1+s2);
        }
        //다른 사람 풀이
        // 전 문제와 비슷한 여러 출력 방법
        //Console.WriteLine($"{s1}{s2}");
        //Console.Write("{0}{1}", s1,s2);
    }   //=======================
        //Replace있는거 확인
        //string str = Console.ReadLine().Replace(" ", string.Empty);
        //Console.WriteLine(str);
}
