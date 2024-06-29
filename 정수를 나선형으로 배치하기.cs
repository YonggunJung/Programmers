using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 정수를_나선형으로_배치하기
    {
        //문제 설명
        //양의 정수 n이 매개변수로 주어집니다.
        //n × n 배열에 1부터 n2 까지 정수를 인덱스[0][0] 부터
        //시계방향 나선형으로 배치한 이차원 배열을
        //return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //1 ≤ n ≤ 30

        //입출력 예
        //n     result
        //4	    [[1, 2, 3, 4], [12, 13, 14, 5], [11, 16, 15, 6], [10, 9, 8, 7]]
        //5	    [[1, 2, 3, 4, 5], [16, 17, 18, 19, 6], [15, 24, 25, 20, 7], [14, 23, 22, 21, 8], [13, 12, 11, 10, 9]]

        //입출력 예 설명
        //입출력 예 #1
        //예제 1번의 n의 값은 4로 4 × 4 배열에 다음과 같이 1부터 16까지 숫자를 채울 수 있습니다.

        //행 \ 열	0	1	2	3
        //0	        1	2	3	4
        //1	        12	13	14	5
        //2	        11	16	15	6
        //3	        10	9	8	7
        //따라서[[1, 2, 3, 4],
        //      [12, 13, 14, 5],
        //      [11, 16, 15, 6],
        //      [10, 9, 8, 7]] 를 return 합니다.

        //입출력 예 #2
        //예제 2번의 n의 값은 5로 5 × 5 배열에 다음과 같이 1부터 25까지 숫자를 채울 수 있습니다.
        //행 \ 열	0	1	2	3	4
        //0	        1	2	3	4	5
        //1	        16	17	18	19	6
        //2	        15	24	25	20	7
        //3	        14	23	22	21	8
        //4	        13	12	11	10	9
        //따라서[[1, 2, 3, 4, 5],
        //      [16, 17, 18, 19, 6],
        //      [15, 24, 25, 20, 7],
        //      [14, 23, 22, 21, 8],
        //      [13, 12, 11, 10, 9]] 를 return 합니다.
        public int[,] solution121(int n)
        {
            //한 번 더 연습 
            int[,] answer = new int[n,n];
            // 시작 좌표 설정
            int x = 0, y = 0;

            // 방향 설정
            int[] mx = { 0, 1, 0, -1 };     // x축으로 움직이는거 
            int[] my = { 1, 0, -1, 0 };     // y축으로 움직이는거

            // 방향키
            int dk = 0;

            // 다음 좌표
            int nx = 0, ny = 0;

            for (int i = 1; i <= n*n; i++)
            {
                // 기본 작동
                answer[x, y] = i;
                nx = x + mx[dk];
                ny = y + my[dk];

                // 방향 전환이 필요 할때
                if (nx >= n || nx < 0 || ny >= n || ny < 0 || answer[nx, ny] != 0)
                {
                    dk = (dk + 1) % mx.Length;

                    nx = x + mx[dk];
                    ny = y + my[dk];

                }
                x = nx;
                y = ny;

            }
            
            return answer;
        }
        //int[,] answer = new int[n,n] ;
        //int direction = 0;
        //int[] mx = { 0, 1, 0, -1 };
        //int[] my = { 1, 0, -1, 0 };

        //int nx = 0;
        //int ny = 0;

        //int x = 0;
        //int y = 0;

        //for (int i = 1; i <= n *n; i++)
        //{
        //    answer[x, y] = i;

        //    nx = x + mx[direction];
        //    ny = y + my[direction];

        //    if(nx >= n || nx<0 || ny >= n || ny < 0 || answer[nx, ny]!=0)
        //    {
        //        direction = (direction+1)%4;

        //        nx = x + mx[direction];
        //        ny = y + my[direction];
        //    }
        //    x = nx;
        //    y = ny;
        //}
        //return answer;
    }
        // 다른 사람 풀이도 신박한건 안보임
        // 이게 젤 좋은듯 이해도 쉽고
    
}
