using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 짝수는_싫어요
    {
        //문제 설명
        //정수 n이 매개변수로 주어질 때,
        //n 이하의 홀수가 오름차순으로 담긴 배열을
        //return하도록 solution 함수를 완성해주세요.

        //제한사항
        //1 ≤ n ≤ 100

        //입출력 예
        //n         result
        //10	    [1, 3, 5, 7, 9]
        //15	    [1, 3, 5, 7, 9, 11, 13, 15]

        //입출력 예 설명
        //입출력 #1
        //10 이하의 홀수가 담긴 배열 [1, 3, 5, 7, 9] 를 return합니다.

        //입출력 #1
        //15 이하의 홀수가 담긴 배열 [1, 3, 5, 7, 9, 11, 13, 15] 를 return합니다.
        public int[] solution211(int n)
        {
            int[] answer = new int[(n+1)/2];
            for (int j = 0; j < answer.Length; j++)
            {
                answer[j] = j * 2 + 1;
            } 
            
            return answer;
        }
        //다른 사람 풀이
        // 이건 항상 신기해
        //int[] answer = Enumerable.Range(1, n).Where(x => x % 2 == 1).ToArray();
    }
}
