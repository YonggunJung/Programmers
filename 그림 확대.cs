using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 그림_확대
    {
        //문제 설명
        //직사각형 형태의 그림 파일이 있고,
        //이 그림 파일은 1 × 1 크기의 정사각형 크기의 픽셀로 이루어져 있습니다.
        //이 그림 파일을 나타낸 문자열 배열 picture과 정수 k가 매개변수로 주어질 때,
        //이 그림 파일을 가로 세로로 k배 늘린 그림 파일을 나타내도록 문자열 배열을
        //return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //1 ≤ picture의 길이 ≤ 20
        //1 ≤ picture의 원소의 길이 ≤ 20
        //모든 picture의 원소의 길이는 같습니다.
        //picture의 원소는 '.'과 'x'로 이루어져 있습니다.
        //1 ≤ k ≤ 10

        //입출력 예
        //picture                                                                                       k       result
        //[".xx...xx.", "x..x.x..x", "x...x...x", ".x.....x.", "..x...x..", "...x.x...", "....x...."]   2	    ["..xxxx......xxxx..", "..xxxx......xxxx..", "xx....xx..xx....xx", "xx....xx..xx....xx", "xx......xx......xx", "xx......xx......xx", "..xx..........xx..", "..xx..........xx..", "....xx......xx....", "....xx......xx....", "......xx..xx......", "......xx..xx......", "........xx........", "........xx........"]
        //["x.x", ".x.", "x.x"]                                                                         3	    ["xxx...xxx", "xxx...xxx", "xxx...xxx", "...xxx...", "...xxx...", "...xxx...", "xxx...xxx", "xxx...xxx", "xxx...xxx"]
        //입출력 예 설명
        //입출력 예 #1

        //예제 1번의 picture는 다음과 같습니다.

        //.xx...xx.
        //x..x.x..x
        //x...x...x
        //.x.....x.
        //..x...x..
        //...x.x...
        //....x....
        //이를 가로 세로로 k배, 즉 2배 확대하면 그림 파일은 다음과 같습니다.

        //..xxxx......xxxx..
        //..xxxx......xxxx..
        //xx....xx..xx....xx
        //xx....xx..xx....xx
        //xx......xx......xx
        //xx......xx......xx
        //..xx..........xx..
        //..xx..........xx..
        //....xx......xx....
        //....xx......xx....
        //......xx..xx......
        //......xx..xx......
        //........xx........
        //........xx........
        //따라서["..xxxx......xxxx..",
        //       "..xxxx......xxxx..",
        //       "xx....xx..xx....xx",
        //       "xx....xx..xx....xx",
        //       "xx......xx......xx",
        //       "xx......xx......xx",
        //       "..xx..........xx..",
        //       "..xx..........xx..",
        //       "....xx......xx....",
        //       "....xx......xx....",
        //       "......xx..xx......",
        //       "......xx..xx......",
        //       "........xx........",
        //       "........xx........"] 를 return 합니다.

        //입출력 예 #2
        //예제 2번의 picture는 다음과 같습니다.
        //x.x
        //.x.
        //x.x
        //이를 가로 세로로 k배, 즉 3배 확대하면 그림 파일은 다음과 같습니다.
        //xxx...xxx
        //xxx...xxx
        //xxx...xxx
        //...xxx...
        //...xxx...
        //...xxx...
        //xxx...xxx
        //xxx...xxx
        //xxx...xxx
        //따라서 ["xxx...xxx",
        //        "xxx...xxx",
        //        "xxx...xxx",
        //        "...xxx...",
        //        "...xxx...",
        //        "...xxx...",
        //        "xxx...xxx",
        //        "xxx...xxx",
        //        "xxx...xxx"] 를 return 합니다.
        public string[] solution117(string[] picture, int k)
        {
            string[] answer = new string[] { };
            List<string> li = new List<string>();

            for (int i = 0; i < picture.Length; i++)
            {
                string p = "";
                for (int j = 0; j < picture[0].Length; j++)
                {
                    for (int m = 0; m < k; m++)
                    {
                        p += picture[i][j];
                    }
                    Console.WriteLine(p);
                }
                for (int j = 0; j < k; j++)
                {
                    li.Add(p);
                }
            }
            answer = li.ToArray();
            return answer;
        }
        //다른 사람 풀이
        //List<string> answer = new List<string>();
        //string replace_a = "";
        //string replace_b = "";
        //for (int i = 0; i<k; i++)
        //{
        //    replace_a += ".";
        //    replace_b += "x";
        //}
        //for (int i = 0; i<picture.Length; i++)
        //{
        //    picture[i] = picture[i].Replace(".", replace_a);
        //     picture[i] = picture[i].Replace("x", replace_b);
        //    for (int j =0; j<k; j++)
        //    {
        //        answer.Add(picture[i]);
        //    }
        //}
        //return answer.ToArray();

static void Main117(string[] args)
        {
            string[] picture = { "x.x", ".x.", "x.x" };
            int k = 3;
            List<string> li = new List<string>();

            for (int i = 0; i < picture.Length; i++)
            {
                string p = "";
                for (int j = 0; j < picture[0].Length; j++)
                {
                    for (int m = 0; m < k; m++)
                    {
                        p += picture[i][j];
                    }
                    Console.WriteLine(p);
                }
                for (int j = 0; j < k; j++)
                {
                    li.Add(p);
                }
                
            }
            answer = li.ToArray();
                Console.WriteLine(picture.Length);
        }
    }
}
