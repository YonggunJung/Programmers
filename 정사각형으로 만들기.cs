using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 정사각형으로_만들기
    {
        //문제 설명
        //이차원 정수 배열 arr이 매개변수로 주어집니다.
        //arr의 행의 수가 더 많다면 열의 수가 행의 수와 같아지도록 각 행의 끝에 0을 추가하고,
        //열의 수가 더 많다면 행의 수가 열의 수와 같아지도록
        //각 열의 끝에 0을 추가한 이차원 배열을 return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //1 ≤ arr의 길이 ≤ 100
        //1 ≤ arr의 원소의 길이 ≤ 100
        //arr의 모든 원소의 길이는 같습니다.
        //1 ≤ arr의 원소의 원소 ≤ 1,000

        //입출력 예
        //arr                                                                   result
        //[[572, 22, 37], [287, 726, 384], [85, 137, 292], [487, 13, 876]]  	[[572, 22, 37, 0], [287, 726, 384, 0], [85, 137, 292, 0], [487, 13, 876, 0]]
        //[[57, 192, 534, 2], [9, 345, 192, 999]]	                            [[57, 192, 534, 2], [9, 345, 192, 999], [0, 0, 0, 0], [0, 0, 0, 0]]
        //[[1, 2], [3, 4]]	                                                    [[1, 2], [3, 4]]

        //입출력 예 설명
        //입출력 예 #1
        //예제 1번의 arr은 행의 수가 4, 열의 수가 3입니다.
        //행의 수가 더 많으므로 열의 수를 4로 만들기 위해 arr의 각 행의 끝에 0을 추가한 이차원 배열
        //[[572, 22, 37, 0], [287, 726, 384, 0], [85, 137, 292, 0], [487, 13, 876, 0]]를 return 합니다.

        //입출력 예 #2
        //예제 2번의 arr은 행의 수가 2, 열의 수가 4입니다.
        //열의 수가 더 많으므로 행의 수를 4로 만들기 위해 arr의 각 열의 끝에 0을 추가한 이차원 배열
        //[[57, 192, 534, 2], [9, 345, 192, 999], [0, 0, 0, 0], [0, 0, 0, 0]]을 return 합니다.

        //입출력 예 #3
        //예제 3번의 arr은 행의 수와 열의 수가 2로 같습니다.
        //따라서 0을 추가하지 않고[[1, 2], [3, 4]] 을 return 합니다.
        public int[,] solution123(int[,] arr)
        {
            int l = arr.GetLength(0);
            if (l < arr.GetLength(1)) l = arr.GetLength(1);
            int[,] answer = new int[l,l] ;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (arr.GetLength(0) <= i || arr.GetLength(1) <= j)
                    {
                        answer[i, j] = 0;
                    }
                    else
                    {
                        answer[i, j] = arr[i, j];
                    }
                }
            }
                return answer;
        }
        // 다른 사람 풀이
        // 이게 되네. 쉐도우 겁나 했네 ㅠㅠ
        //int max = Math.Max(arr.GetLength(0), arr.GetLength(1));
        //int[,] answer = new int[max, max];
        //for(int y = 0; y<arr.GetLength(0); ++y)
        //{
        //    for(int x = 0; x<arr.GetLength(1); ++x)
        //        answer[y, x] = arr[y, x];
        //}
        //return answer;
    }
}
