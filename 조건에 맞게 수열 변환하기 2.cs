using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 조건에_맞게_수열_변환하기_2
    {
        //문제 설명
        //정수 배열 arr가 주어집니다.
        //arr의 각 원소에 대해 값이 50보다 크거나 같은 짝수라면 2로 나누고,
        //50보다 작은 홀수라면 2를 곱하고 다시 1을 더합니다.

        //이러한 작업을 x번 반복한 결과인 배열을 arr(x) 라고 표현했을 때,
        //arr(x) = arr(x + 1)인 x가 항상 존재합니다.
        //이러한 x 중 가장 작은 값을 return 하는 solution 함수를 완성해 주세요.

        //단, 두 배열에 대한 "="는 두 배열의 크기가 서로 같으며,
        //같은 인덱스의 원소가 각각 서로 같음을 의미합니다.

        //제한사항
        //1 ≤ arr의 길이 ≤ 1,000,000
        //1 ≤ arr의 원소의 값 ≤ 100

        //입출력 예
        //arr                           result
        //[1, 2, 3, 100, 99, 98]            5

        //입출력 예 설명
        //입출력 예 #1
        //위 작업을 반복하면 다음과 같이 arr가 변합니다.
        //반복 횟수         arr
        //0	            [1, 2, 3, 100, 99, 98]
        //1	            [3, 2, 7, 50, 99, 49]
        //2	            [7, 2, 15, 25, 99, 99]
        //3	            [15, 2, 31, 51, 99, 99]
        //4	            [31, 2, 63, 51, 99, 99]
        //5	            [63, 2, 63, 51, 99, 99]
        //6	            [63, 2, 63, 51, 99, 99]
        //이후로 arr가 변하지 않으며, arr(5) = arr(6)이므로 5를 return 합니다.
        public int solution72(int[] arr)
        {
            int answer = 0;
            while (true)
            {
                List<int> li = new List<int>(arr);
                int check = arr.Length;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 50 && arr[i] % 2 == 0)
                    {
                        arr[i] /= 2;
                        check--;
                    }
                    else if (arr[i] < 50 && arr[i] % 2 != 0)
                    {
                        arr[i] = arr[i] * 2 + 1;
                        check--;
                    }
                }
                if (check == arr.Length) break;
                answer++;
            }
            return answer;
        }
        //다른사람 풀이 보기
        //이 두가지 배열과 리스트도 비교 가능
        //if(Enumerable.SequenceEqual(arr, arr1)) break;
        //if (copy.SequenceEqual(arr)) break;

        //이거도 이제 알았네
        //arrOld = (int[]) arr.Clone();



        static void Main72(string[] args)
        {
            int[] arr1 = { 1, 2 };
            int[] arr2 = { 1, 2 };
            //arr1[1] = 3;
            List<int> li3 = new List<int>(arr1);
            List<int> li4 = new List<int>(arr1);
            Console.WriteLine(arr1 == arr2);
            Console.WriteLine(li3 == li4);
            Console.WriteLine(arr1[1]);
            int a = 0;
            if (Enumerable.SequenceEqual(arr2, arr1)) a = 3;
            if (Enumerable.SequenceEqual(li3, li4)) a = 5;
            if (arr2.SequenceEqual(arr1)) a++;
            if (li4.SequenceEqual(li3)) a++;
            Console.WriteLine(a);
        }
    }
}
