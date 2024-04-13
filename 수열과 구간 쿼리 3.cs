using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 수열과_구간_쿼리_3
    {
        //문제 설명
        //정수 배열 arr와 2차원 정수 배열 queries이 주어집니다.queries의 원소는 각각 하나의 query를 나타내며, [i, j] 꼴입니다.

        //각 query마다 순서대로 arr[i]의 값과 arr[j] 의 값을 서로 바꿉니다.

        //위 규칙에 따라 queries를 처리한 이후의 arr를 return 하는 solution 함수를 완성해 주세요.

        //제한사항
        //1 ≤ arr의 길이 ≤ 1,000
        //0 ≤ arr의 원소 ≤ 1,000,000
        //1 ≤ queries의 길이 ≤ 1,000
        //0 ≤ i<j<arr의 길이
        //입출력 예
        //arr queries result
        //[0, 1, 2, 3, 4][[0, 3], [1, 2], [1, 4]][3, 4, 1, 0, 2]
        //입출력 예 설명
        //입출력 예 #1

        //각 쿼리에 따라 arr가 다음과 같이 변합니다.
        //arr
        //[0, 1, 2, 3, 4]
        //[3, 1, 2, 0, 4]
        //[3, 2, 1, 0, 4]
        //[3, 4, 1, 0, 2]
        //따라서[3, 4, 1, 0, 2]를 return 합니다.
        public static int[] solution27(int[] arr, int[,] queries)
        {
            // 배열의 길이도 문제였고, 복사도 문제 였음 시간 많이 걸림
            int[] answer = new int[] { };
            answer = arr;
            for (int i = 0; i < queries.Length / 2; i++)
            {
                int j = queries[i, 0];
                int k = queries[i, 1];
                int a = arr[k];
                int b = arr[j];
                answer[j] = a;
                answer[k] = b;
            }
            return answer;
        }
        //다른 사람 풀이
        // GetLength를 이렇게 쓰는 거구나 이것만 알았어도 훨씬 쉬었을듯
        //int temp_a = 0;
        //int temp_b = 0;
        //    for(int i = 0; i<queries.GetLength(0); ++i)
        //    {
        //        temp_a = arr[queries[i, 0]];
        //        temp_b = arr[queries[i, 1]];

        //        arr[queries[i, 0]] = temp_b;
        //        arr[queries[i, 1]] = temp_a;
        //    }
        //    return arr;

        // 길이 문제랑 복사 문제만 알면 쉬운 문제이다.
        //for(int i = 0; i<queries.GetLength(0); i++){
        //    int temp = 0;
        //temp = arr[queries[i, 0]];
        //    arr[queries[i, 0]] = arr[queries[i, 1]];
        //    arr[queries[i, 1]] = temp;    
        //}
        //return arr;

        static void Main27(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4 };
            int[,] queries = { { 0, 3 }, { 1, 2 }, { 1, 4 } };
            int[] r = solution27(arr, queries);
            //foreach (int n in r) Console.WriteLine(n);
            //Console.WriteLine(queries);
        }
    }
}
