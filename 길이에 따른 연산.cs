using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 길이에_따른_연산
    {
        //문제 설명
        //정수가 담긴 리스트 num_list가 주어질 때,
        //리스트의 길이가 11 이상이면 리스트에 있는 모든 원소의 합을
        //10 이하이면 모든 원소의 곱을 return하도록 solution 함수를 완성해주세요.

        //제한사항
        //2 ≤ num_list의 길이 ≤ 20
        //1 ≤ num_list의 원소 ≤ 9
        //num_list의 원소를 모두 곱했을 때 2,147,483,647를 넘는 입력은 주어지지 않습니다.

        //입출력 예
        //num_list                                        result
        //[3, 4, 5, 2, 5, 4, 6, 7, 3, 7, 2, 2, 1]            51
        //[2, 3, 4, 5]                                      120

        //입출력 예 설명
        //입출력 예 #1
        //리스트의 길이가 13이므로 모든 원소의 합인 51을 return합니다.

        //입출력 예 #2
        //리스트의 길이가 4이므로 모든 원소의 곱인 120을 return합니다.
        public int solution74(int[] num_list)
        {
            int answer = 1;
            if (num_list.Length > 10) answer = num_list.Sum(x => x);
            else
            {
                for (int i = 0; i < num_list.Length; i++)
                {
                    answer *= num_list[i];
                }
            }
            return answer;
        }
        //다른사람 풀이
        // Aggregate()함수는 좀 봐야겠음 잘 모르겠음
        //int answer = num_list.Length <= 10 ? num_list.Aggregate((a, b) => a * b) : num_list.Sum();
    }
}
