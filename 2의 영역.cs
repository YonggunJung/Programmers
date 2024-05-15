using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class _2의_영역
    {
        //문제 설명
        //정수 배열 arr가 주어집니다.
        //배열 안의 2가 모두 포함된 가장 작은 연속된 부분 배열을
        //return 하는 solution 함수를 완성해 주세요.

        //단, arr에 2가 없는 경우[-1] 을 return 합니다.

        //제한사항
        //1 ≤ arr의 길이 ≤ 100,000
        //1 ≤ arr의 원소 ≤ 10

        //입출력 예
        //arr                           result
        //[1, 2, 1, 4, 5, 2, 9]         [2, 1, 4, 5, 2]
        //[1, 2, 1]                     [2]
        //[1, 1, 1]                     [-1]
        //[1, 2, 1, 2, 1, 10, 2, 1]     [2, 1, 2, 1, 10, 2]

        //입출력 예 설명
        //입출력 예 #1
        //2가 있는 인덱스는 1번, 5번 인덱스뿐이므로
        //1번부터 5번 인덱스까지의 부분 배열인 [2, 1, 4, 5, 2] 를 return 합니다.

        //입출력 예 #2
        //2가 한 개뿐이므로[2] 를 return 합니다.

        //입출력 예 #3
        //2가 배열에 없으므로[-1] 을 return 합니다.

        //입출력 예 #4
        //2가 있는 인덱스는 1번, 3번, 6번 인덱스이므로
        //1번부터 6번 인덱스까지의 부분 배열인 [2, 1, 2, 1, 10, 2] 를 return 합니다.
        public int[] solution59(int[] arr)
        {
            int[] answer = new int[] { };
            List<int> li = new List<int>();
            int f = Array.FindIndex(arr, n => n == 2);
            int l = Array.FindLastIndex(arr, t => t == 2);
            if (f == -1) li.Add(f);
            else if (f == l)
            {
                li.Add(2);
            }
            else
            {
                for (int i = f; i <= l; i++)
                {
                    li.Add(arr[i]);
                }

            }
            answer = li.ToArray();
            return answer;
        }
        //다른사람 풀이
        //내꺼 간소화 된 느낌
        //int start = Array.IndexOf(arr, 2);
        //if(start == -1) return new int[1]{ -1 };
        //int end = Array.LastIndexOf(arr, 2);
        //int[] answer = new int[end - start + 1];
        //Array.Copy(arr, start, answer, 0, answer.Length);
        //return answer;
        static void Main59(string[] args)
        {
            int[] arr = { 1, 2, 1, 2, 1, 10, 2, 1 };
            int[] ar = { 1, 1, 1, 10, 1 };
            int f = Array.FindIndex(arr, n => n == 2);
            int nt = Array.FindIndex(ar, n => n == 2);
            int l = Array.FindLastIndex(arr, n => n == 2);

            Console.WriteLine(f);
            Console.WriteLine(l);
            Console.WriteLine(nt);
        }
    }
}
