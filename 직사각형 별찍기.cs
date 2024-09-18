using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 직사각형_별찍기
    {
        //문제 설명
        //이 문제에는 표준 입력으로 두 개의 정수 n과 m이 주어집니다.
        //별(*) 문자를 이용해 가로의 길이가 n,
        //세로의 길이가 m인 직사각형 형태를 출력해보세요.

        //제한 조건
        //n과 m은 각각 1000 이하인 자연수입니다.
        //예시
        //입력

        //5 3
        //출력

        //*****
        //*****
        //*****
        public static void Main28()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
