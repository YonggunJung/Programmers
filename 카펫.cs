using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv2
{
    internal class 카펫
    {
        //문제 설명
        //Leo는 카펫을 사러 갔다가 아래 그림과 같이 중앙에는 노란색으로 칠해져 있고
        //테두리 1줄은 갈색으로 칠해져 있는 격자 모양 카펫을 봤습니다.

        //carpet.png

        //Leo는 집으로 돌아와서
        //아까 본 카펫의 노란색과 갈색으로 색칠된 격자의 개수는 기억했지만,
        //전체 카펫의 크기는 기억하지 못했습니다.

        //Leo가 본 카펫에서 갈색 격자의 수 brown,
        //노란색 격자의 수 yellow가 매개변수로 주어질 때 카펫의 가로,
        //세로 크기를 순서대로 배열에 담아 return 하도록 solution 함수를 작성해주세요.

        //제한사항
        //갈색 격자의 수 brown은 8 이상 5,000 이하인 자연수입니다.
        //노란색 격자의 수 yellow는 1 이상 2,000,000 이하인 자연수입니다.
        //카펫의 가로 길이는 세로 길이와 같거나, 세로 길이보다 깁니다.

        //입출력 예
        //brown         yellow	            return
        //10	            2	            [4, 3]
        //8	                1	            [3, 3]
        //24	           24	            [8, 6]

        public int[] solution8(int brown, int yellow)
        {
            // 수식을 이용한 문제 : (가로 - 2) * (세로 - 2) = yellow
            // 이런건 수식을 모르면 못푸는 문제이군 ㅠㅠ
            int[] answer = new int[2];
            int total = brown + yellow;

            for (int width = 3; width <= Math.Sqrt(total); width++) // 가로 길이는 최소 3 이상이어야 하므로
            {
                if (total % width == 0) // 가로와 세로가 나누어떨어져야 한다
                {
                    int height = total / width; // 세로는 전체 크기 / 가로 길이

                    // 갈색 격자 수는 (가로 - 2) * (세로 - 2) = yellow 여야 한다
                    if ((width - 2) * (height - 2) == yellow)
                    {
                        answer[0] = height; // 가로, 세로 순서대로 저장
                        answer[1] = width;
                        break;
                    }
                }
            }

            return answer;

            //이건 실패
            //int total = brown + yellow;
            //List<int> li = new List<int>();
            //for (int i = 1; i <= total; i++)
            //{
            //    if (total % i == 0)
            //        li.Add(i);
            //}
            //if (li.Count % 2 == 0)
            //{
            //    answer[0] = li[li.Count / 2];
            //    answer[1] = li[li.Count / 2 - 1];
            //}
            //else
            //{
            //    answer[0] = li[li.Count / 2];
            //    answer[1] = li[li.Count / 2];
            //}

        }

        // 다른 사람 풀이
        // 이게 젤 보기 좋은듯
        public int[] solution8_1(int brown, int red)
        {
            int nSum = brown + red;
            int[] answer = new int[2];
            for (int i = 3; i < nSum / 3 + 1; i++)
                for (int j = i; j < nSum / 3 + 1; j++)
                    if (i * j == nSum)
                    {
                        if ((i - 2) * 2 + (j - 2) * 2 + 4 == brown)
                        {
                            answer[0] = j;
                            answer[1] = i;
                            return answer;
                        }
                    }
            return answer;
        }
    }
}
