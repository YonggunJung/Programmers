using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 평균_구하기
    {
        //문제 설명
        //정수를 담고 있는 배열 arr의 평균값을 return하는 함수,
        //solution을 완성해보세요.

        //제한사항
        //arr은 길이 1 이상, 100 이하인 배열입니다.
        //arr의 원소는 -10,000 이상 10,000 이하인 정수입니다.

        //입출력 예
        //arr                   return
        //[1, 2, 3, 4]              2.5
        //[5, 5]                    5
        public double solution5(int[] arr)
        {
            double answer = (double)arr.Sum() / arr.Length;
            
            return answer;
        }
        //다른 사람 풀이
        // 이걸 못봤네 ㅠㅠ
        //arr.Average()
    }
}
