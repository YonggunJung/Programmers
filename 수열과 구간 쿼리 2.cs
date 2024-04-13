using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 수열과_구간_쿼리_2
    {
        //문제 설명
        //정수 배열 arr와 2차원 정수 배열 queries이 주어집니다.
        //queries의 원소는 각각 하나의 query를 나타내며, [s, e, k] 꼴입니다.
        //각 query마다 순서대로 s ≤ i ≤ e인 모든 i에 대해 k보다 크면서 가장 작은 arr[i] 를 찾습니다.
        //각 쿼리의 순서에 맞게 답을 저장한 배열을 반환하는 solution 함수를 완성해 주세요.
        //단, 특정 쿼리의 답이 존재하지 않으면 -1을 저장합니다.

        //제한사항
        //1 ≤ arr의 길이 ≤ 1,000
        //0 ≤ arr의 원소 ≤ 1,000,000
        //1 ≤ queries의 길이 ≤ 1,000
        //0 ≤ s ≤ e<arr의 길이
        //0 ≤ k ≤ 1,000,000

        //입출력 예
        //arr                    queries                                    result
        //[0, 1, 2, 4, 3]       [[0, 4, 2], [0, 3, 2], [0, 2, 2]]           [3, 4, -1]

        //입출력 예 설명
        //입출력 예 #1
        //첫 번째 쿼리의 범위에는 0, 1, 2, 4, 3이 있으며 이 중 2보다 크면서 가장 작은 값은 3입니다.
        //두 번째 쿼리의 범위에는 0, 1, 2, 4가 있으며 이 중 2보다 크면서 가장 작은 값은 4입니다.
        //세 번째 쿼리의 범위에는 0, 1, 2가 있으며 여기에는 2보다 큰 값이 없습니다.
        //따라서[3, 4, -1]을 return 합니다.
        public int[] solution28(int[] arr, int[,] queries)
        {
            //2시간 풀다 결국 답을 봄.혼자 쉐도우를 굉장히 했구나 함
            int[] answer = new int[queries.GetLength(0)];

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int s = queries[i, 0];
                int e = queries[i, 1];
                int k = queries[i, 2];
                int min = -1;
                for (int j = s; j <= e; j++)
                {
                    if (k < arr[j])
                    {
                        if (min == -1)
                        {
                            min = arr[j];
                        }
                        else if (min != -1 && min > arr[j])
                        {
                            min = arr[j];
                        }
                    }
                }
                answer[i] = min;

                return answer;

                //이게 왜 안되는지 모르겠다 ㅠㅠ
                //int[] answer = new int[] { };
                //List<int> a = new List<int>(arr);
                //List<int> an = new List<int>();
                //a.Sort();
                //for (int i = 0; i < queries.GetLength(0); i++)
                //{
                //    int s = queries[i, 0];
                //    int e = queries[i, 1];
                //    int k = queries[i, 2];
                //    int min = -1;
                //    for (int j = s; j <= e; j++)
                //    {

                //        foreach (int n in a)
                //        {
                //            if (n > k)
                //            {
                //                min = n;
                //                break;
                //            }
                //        }
                //        if (min != -1)
                //        {
                //            an.Add(min);
                //            a.Remove(min);
                //            break;
                //        }
                //        else if (min == -1)
                //        {
                //            an.Add(min);
                //            break;
                //        }
                //    }
                //}
                //answer = an.ToArray();
                //return answer;
            }

        static void Main28(string[] args)
        {
            int[] arr = { 0, 1, 2, 4, 3 };
            int[,] queries = { { 0, 4, 2 }, { 0, 3, 2 }, { 0, 2, 2 } };
            //int[] r = solution28(arr, queries);
            List<int> a = new List<int>(arr);
            a.Sort();
            //a.Remove(3);
            foreach (int i in a) Console.WriteLine(i);
        }
    }
}
