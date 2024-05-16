using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 순서_바꾸기
    {
        //문제 설명
        //정수 리스트 num_list와 정수 n이 주어질 때,
        //num_list를 n 번째 원소 이후의 원소들과 n 번째까지의 원소들로 나눠
        //n 번째 원소 이후의 원소들을 n 번째까지의 원소들 앞에 붙인 리스트를
        //return하도록 solution 함수를 완성해주세요.

        //제한사항
        //2 ≤ num_list의 길이 ≤ 30
        //1 ≤ num_list의 원소 ≤ 9
        //1 ≤ n ≤ num_list의 길이

        //입출력 예
        //num_list              n           result
        //[2, 1, 6]	            1	        [1, 6, 2]
        //[5, 2, 1, 7, 5]	    3	        [7, 5, 5, 2, 1]

        //입출력 예 설명
        //입출력 예 #1
        //[2, 1, 6] 에서 첫 번째 이후의 원소는[1, 6]이고
        //첫 번째까지의 원소는[2]입니다.
        //두 리스트를 이어 붙이면[1, 6, 2]가 됩니다.

        //입출력 예 #2
        //[5, 2, 1, 7, 5] 에서 세 번째 이후의 원소는 [7, 5] 이고
        //세 번째까지의 원소는 [5, 2, 1] 입니다.
        //두 리스트를 이어 붙이면 [7, 5, 5, 2, 1] 가 됩니다.
        public int[] solution62(int[] num_list, int n)
        {
            int[] answer = new int[] { };
            List<int> li = new List<int>();
            for (int i = n; i < num_list.Length; i++)
            {
                li.Add(num_list[i]);
            }
            for (int i = 0; i < n; i++)
            {
                li.Add(num_list[i]);
            }
            answer = li.ToArray();
            return answer;
        }
        // 다른사람 풀이
        // 신기하구만
        //int[] answer = new int[num_list.Length];
        //Array.Copy(num_list, n, answer, 0, num_list.Length - n); // n 번째이후 원소 -> 앞으로 
        //Array.Copy(num_list, 0, answer, num_list.Length - n, n); // n 번째까지의 원소 -> 뒤로
        //return answer;

        //다른사람풀이2
        // 이렇게 하고 싶었는데 잘 안됐음
        //List<int> answer = new List<int>();
        //int[] right = num_list.Skip(n).ToArray();
        //int[] left = num_list.Take(n).ToArray();
        //answer.AddRange(right);
        //answer.AddRange(left);
        //return answer.ToArray();
    }
}
