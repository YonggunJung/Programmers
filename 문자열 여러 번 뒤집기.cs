using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 문자열_여러_번_뒤집기
    {
        //문제 설명
        //문자열 my_string과 이차원 정수 배열 queries가 매개변수로 주어집니다.
        //queries의 원소는[s, e] 형태로,
        //my_string의 인덱스 s부터 인덱스 e까지를 뒤집으라는 의미입니다.
        //my_string에 queries의 명령을 순서대로 처리한 후의 문자열을 return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //my_string은 영소문자로만 이루어져 있습니다.
        //1 ≤ my_string의 길이 ≤ 1,000
        //queries의 원소는 [s, e] 의 형태로 0 ≤ s ≤ e<my_string의 길이를 만족합니다.
        //1 ≤ queries의 길이 ≤ 1,000

        //입출력 예
        //my_string         queries                                 result
        //"rermgorpsam"	    [[2, 3], [0, 7], [5, 9], [6, 10]]       "programmers"

        //입출력 예 설명
        //예제 1번의 my_string은 "rermgorpsam"이고 주어진 queries를 순서대로 처리하면 다음과 같습니다.
        //queries           my_string
        //                  "rermgorpsam"
        //[2, 3]            "remrgorpsam"
        //[0, 7]            "progrmersam"
        //[5, 9]            "prograsremm"
        //[6, 10]           "programmers"
        //따라서 "programmers"를 return 합니다.
        public static string solution38(string my_string, int[,] queries)
        {
            //어려운거아닌데 진짜 별거 아닌걸로 시간을 너무 쓰네 ㅠㅠ
            // 더 많은 연습 필요 함
            string answer = "";
            answer = my_string;
            for (int i = 0; i<queries.GetLength(0);i++)
            {
                int s = queries[i,0];
                int e = queries[i,1];
                string m = "";
                for (int j = e; j >= s; j--)
                {
                    m += answer[j];
                }
                string f = answer.Substring(0, s);
                string b = answer.Substring((e+1));
                
                answer = f + m + b;
            }
            Console.WriteLine(answer);
            return answer;
        }
        //다른 사람 풀이
        // 이런게 있구나 ToCharArray() 이걸 쓰니까 Array.Reverse(배열, 시작점, 갯수)가 되네
        //var arr = my_string.ToCharArray();
        //for(int y = 0; y<queries.GetLength(0); ++y)
        //{
        //    int s = queries[y, 0];
        //int e = queries[y, 1];
        //Array.Reverse(arr, s, e - s + 1);
        //}
        //return new string (arr);


        static void Main38(string[] args) 
        {
            string my_string = "rermgorpsam";
            //{ { 2, 3 }, { 0, 7 }, { 5, 9 }, { 6, 10 } };
            int[,] queries = { { 2, 3 }, { 0, 7 }, { 5, 9 }, { 6, 10 } };
            solution38(my_string, queries);
        }
    }
}
