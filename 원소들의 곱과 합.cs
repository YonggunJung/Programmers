using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    //문제 설명
    //정수가 담긴 리스트 num_list가 주어질 때, 
    //모든 원소들의 곱이 모든 원소들의 합의 제곱보다 작으면 1을 
    //크면 0을 return하도록 solution 함수를 완성해주세요.

    //제한사항
    //2 ≤ num_list의 길이 ≤ 10
    //1 ≤ num_list의 원소 ≤ 9

    //입출력 예
    //num_list                result
    //[3, 4, 5, 2, 1]           1
    //[5, 7, 8, 3]	            0

    //입출력 예 설명
    //입출력 예 #1
    //모든 원소의 곱은 120, 합의 제곱은 225이므로 1을 return합니다.

    //입출력 예 #2
    //모든 원소의 곱은 840, 합의 제곱은 529이므로 0을 return합니다.
    internal class 원소들의_곱과_합
    {
        public int solution23(int[] num_list)
        {
            int answer = 0;
            int s = 0;
            int g = 1;
            foreach (int i in num_list)
            {
                s += i;
                g *= i;
            }
            if (s * s > g)
                answer = 1;
            return answer;
        }
        // 다른 사람 풀이
        //넘파이가 없어서 람다식을 빨리 해줘야 편할듯
        //int answer = 0;
        //answer = num_list.Aggregate(1, (x, y) => x* y) < Math.Pow(num_list.Sum(), 2) ? 1 : 0;
        //return answer;
    }
}
