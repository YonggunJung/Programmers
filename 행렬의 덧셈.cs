using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 행렬의_덧셈
    {
        //문제 설명
        //행렬의 덧셈은 행과 열의 크기가 같은 두 행렬의 같은 행,
        //같은 열의 값을 서로 더한 결과가 됩니다.
        //2개의 행렬 arr1과 arr2를 입력받아,
        //행렬 덧셈의 결과를 반환하는 함수, solution을 완성해주세요.

        //제한 조건
        //행렬 arr1, arr2의 행과 열의 길이는 500을 넘지 않습니다.

        //입출력 예
        //arr1                      arr2	                return
        //[[1, 2],[2, 3]]	        [[3, 4],[5, 6]]	        [[4, 6],[7, 9]]
        //[[1],[2]]	                [[3],[4]]	            [[4],[6]]
        public int[,] solution27(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];   
                }
            }
            return answer;
        }
    }
}
