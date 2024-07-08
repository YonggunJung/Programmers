using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 평행
    {
        //문제 설명
        //점 네 개의 좌표를 담은 이차원 배열 dots가 다음과 같이 매개변수로 주어집니다.

        //[[x1, y1], [x2, y2], [x3, y3], [x4, y4]]
        //주어진 네 개의 점을 두 개씩 이었을 때,
        //두 직선이 평행이 되는 경우가 있으면 1을 없으면 0을
        //return 하도록 solution 함수를 완성해보세요.

        // 제한사항
        //dots의 길이 = 4
        //dots의 원소는 [x, y] 형태이며 x, y는 정수입니다.
        //0 ≤ x, y ≤ 100
        //서로 다른 두개 이상의 점이 겹치는 경우는 없습니다.
        //두 직선이 겹치는 경우(일치하는 경우) 에도 1을 return 해주세요.
        //임의의 두 점을 이은 직선이 x축 또는 y축과 평행한 경우는 주어지지 않습니다.

        //입출력 예
        //dots                                      result
        //[[1, 4], [9, 2], [3, 8], [11, 6]]	            1
        //[[3, 5], [4, 1], [2, 4], [5, 10]]	            0

        //입출력 예 설명
        //입출력 예 #1
        //점[1, 4], [3, 8]을 잇고[9, 2], [11, 6]를 이으면 두 선분은 평행합니다.

        //입출력 예 #2
        //점을 어떻게 연결해도 평행하지 않습니다.
        public int solution163(int[,] dots)
        {
            //x랑 y를 double로 해줘야함 
            // 그걸 몰라서 시간 엄청 씀 ㅠㅠ
            int answer = 0;
            double x1 = dots[0, 0];
            double x2 = dots[1, 0];
            double x3 = dots[2, 0];
            double x4 = dots[3, 0];

            double y1 = dots[0, 1];
            double y2 = dots[1, 1];
            double y3 = dots[2, 1];
            double y4 = dots[3, 1];

            if (Math.Abs((y2 - y1) / (x2 - x1)) == Math.Abs((y4 - y3) / (x4 - x3))) answer = 1;
            else if (Math.Abs((y3 - y1) / (x3 - x1)) == Math.Abs((y4 - y2) / (x4 - x2))) answer = 1;
            else if (Math.Abs((y4 - y1) / (x4 - x1)) == Math.Abs((y2 - y3) / (x2 - x3))) answer = 1;

            //int g12 = Math.Abs((y2 - y1) / (x2 - x1));
            //int g34 = Math.Abs((y4 - y3) / (x4 - x3));

            //int g13 = Math.Abs((y3 - y1) / (x3 - x1));
            //int g24 = Math.Abs((y4 - y2) / (x4 - x2));

            //int g23 = Math.Abs((y3 - y2) / (x3 - x2));
            //int g14 = Math.Abs((y4 - y1) / (x4 - x1));

            if (g12 == g34 || g13 == g24 || g23 == g14) answer = 1;
            return answer;
        }
    }
}
