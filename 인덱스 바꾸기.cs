﻿using Programmers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 인덱스_바꾸기
    {
        //문제 설명
        //문자열 my_string과 정수 num1, num2가 매개변수로 주어질 때,
        //my_string에서 인덱스 num1과 인덱스 num2에 해당하는 문자를 바꾼 문자열을
        //return 하도록 solution 함수를 완성해보세요.

        //제한사항
        //1 < my_string의 길이 < 100
        //0 ≤ num1, num2<my_string의 길이
        //my_string은 소문자로 이루어져 있습니다.
        //num1 ≠ num2

        //입출력 예
        //my_string         num1        num2        result
        //"hello"	        1	        2	        "hlelo"
        //"I love you"	    3	        6	        "I l veoyou"

        //입출력 예 설명
        //입출력 예 #1
        //"hello"의 1번째 인덱스인 "e"와 2번째 인덱스인 "l"을 바꾸면 "hlelo"입니다.
        //입출력 예 #2
        //"I love you"의 3번째 인덱스 "o"와 " "(공백) 을 바꾸면 "I l veoyou"입니다.
        public string solution146(string my_string, int num1, int num2)
        {
            string answer = "";
            for (int i = 0; i<my_string.Length; i++)
            {
                if (i == num1) answer += my_string[num2];
                else if (i == num2) answer += my_string[num1];
                else answer += my_string[i];
            }
            return answer;
        }
    }
}
