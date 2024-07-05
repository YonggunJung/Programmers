using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 가까운_수
    {
        //문제 설명
        //정수 배열 array와 정수 n이 매개변수로 주어질 때,
        //array에 들어있는 정수 중 n과 가장 가까운 수를
        //return 하도록 solution 함수를 완성해주세요.

        //제한사항
        //1 ≤ array의 길이 ≤ 100
        //1 ≤ array의 원소 ≤ 100
        //1 ≤ n ≤ 100
        //가장 가까운 수가 여러 개일 경우 더 작은 수를 return 합니다.

        //입출력 예
        //array              n          result
        //[3, 10, 28]       20	        28
        //[10, 11, 12]      13	        12

        //입출력 예 설명
        //입출력 예 #1
        //3, 10, 28 중 20과 가장 가까운 수는 28입니다.

        //입출력 예 #2
        //10, 11, 12 중 13과 가장 가까운 수는 12입니다.
        public int solution151(int[] array, int n)
        {
            int answer = 0;
            int min = 0;
            int v = int.MaxValue;
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = Math.Abs(n - array[i]);
                if (arr[i] < v)
                {
                    min = i;
                    v = arr[i];
                }
                else if (arr[i]== v)
                {
                    if (array[i] > array[min])
                    {
                        continue;
                    }
                    else
                    {
                        min = i;
                        v = arr[i];
                    }
                }
            }
            answer = array[min];
            return answer;
        }
        // 다른사람 풀이
        // 이렇게 풀려고 했는데 안되는 거였군 ㅋㅋㅋ
        //int answer = array.OrderBy(x => x).FirstOrDefault(x => Math.Abs(x - n) == array.Min(o => Math.Abs(o - n)));

        //이게 더 이해하기 쉬움
        //int answer = array.OrderBy(x => x).OrderBy(x => Math.Abs(x - n)).ToArray().First();

        // 정렬을 하고 했으면 더 쉬웠음
//        int index = -1;
//        int min = int.MaxValue;
//        Array.Sort(array);
//        for(int i=0;i<array.Length;i++)
//        {
//            int temp = (int)MathF.Abs(array[i] - n);
//            if(temp<min)
//            {
//                index = i;
//                min = temp;
//            }
//}
//        return array[index];
    }
}
