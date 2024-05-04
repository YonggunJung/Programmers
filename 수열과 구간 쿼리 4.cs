using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 수열과_구간_쿼리_4
    {
        //문제 설명
        //정수 배열 arr와 2차원 정수 배열 queries이 주어집니다.queries의 원소는 각각 하나의 query를 나타내며, [s, e, k] 꼴입니다.

        //각 query마다 순서대로 s ≤ i ≤ e인 모든 i에 대해 i가 k의 배수이면 arr[i]에 1을 더합니다.

        //위 규칙에 따라 queries를 처리한 이후의 arr를 return 하는 solution 함수를 완성해 주세요.

        //제한사항
        //1 ≤ arr의 길이 ≤ 1,000
        //0 ≤ arr의 원소 ≤ 1,000,000
        //1 ≤ queries의 길이 ≤ 1,000
        //0 ≤ s ≤ e<arr의 길이
        //0 ≤ k ≤ 5
        //입출력 예
        //arr queries result
        //[0, 1, 2, 4, 3][[0, 4, 1], [0, 3, 2], [0, 3, 3]][3, 2, 4, 6, 4]
        //입출력 예 설명
        //입출력 예 #1

        //각 쿼리에 따라 arr가 다음과 같이 변합니다.
        //arr
        //[0, 1, 2, 4, 3]
        //[1, 2, 3, 5, 4]
        //[2, 2, 4, 5, 4]
        //[3, 2, 4, 6, 4]
        //따라서[3, 2, 4, 6, 4]를 return 합니다.
        public int[] solution29(int[] arr, int[,] queries)
        {
            int[] answer = new int[] { };
            List<int> li = new List<int>(arr);
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                for (int j = queries[i, 0]; j <= queries[i, 1];j++)
                {
                    if (j % queries[i, 2] == 0)
                    {
                        li[j]++;
                    }
                }
            }
            answer = li.ToArray();
            return answer;
        }
        // 다른 사람 풀이
        //내랑 비슷한데 간다해 보임
//        int l = queries.GetLength(0);
//        for(int i = 0; i<l; i++){
//            int s = queries[i, 0];
//        int e = queries[i, 1];
//        int k = queries[i, 2];
//            for(int j = s; j<=e; j++){
//                if(j%k==0)
//                    arr[j]++;
//            }
//            }
//        return arr;


static int[,] queries = { { 0, 4, 1 }, { 0, 3, 2 }, { 0, 3, 3 } };
        static int[] arr = { 0, 1, 2, 4, 3 };
        static List<int> li = new List<int>(arr);
        static void Main29(string[] args)
        {
            Console.WriteLine(queries[1, 1]);
            Console.WriteLine(queries.GetLength(0));
            Console.WriteLine(li[2]);
        }
    }
}
