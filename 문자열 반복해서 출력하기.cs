﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 문자열_반복해서_출력하기
    {

        static void Main3(string[] args)
        {
            //문제 설명
            //문자열 str과 정수 n이 주어집니다.
            //str이 n번 반복된 문자열을 만들어 출력하는 코드를 작성해 보세요.

            //제한사항
            //1 ≤ str의 길이 ≤ 10
            //1 ≤ n ≤ 5

            //입출력 예
            //입력 #1
            //string 5

            //출력 #1
            //stringstringstringstringstring
            
            string[] str;

            Console.Clear();
            str = Console.ReadLine().Split(' ');

            string s1 = str[0];
            int n = int.Parse(str[1]);

            for (int i = 0; i<n; i++)
            {
                Console.Write(s1);
            }
            
        }
        // 다른 사람 풀이 1
        //StringBuilder() 사용해서 ToString으로 보내기 ㅇㅋㄷㅋ
        //String[] input;

        //Console.Clear();
        //input = Console.ReadLine().Split(' ');

        //String s1 = input[0];
        //int a = Int32.Parse(input[1]);

        //StringBuilder sb = new StringBuilder();    
        //for(int i = 0; i<a; i++) sb.Append(s1);

        //var str = sb.ToString();
        //Console.WriteLine(str);
    }
}
