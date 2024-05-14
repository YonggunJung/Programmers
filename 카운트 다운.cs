using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 카운트_다운
    {
        //문제 설명
        //정수 start_num와 end_num가 주어질 때,
        //start_num에서 end_num까지 1씩 감소하는 수들을 차례로 담은 리스트를
        //return하도록 solution 함수를 완성해주세요.

        //제한사항
        //0 ≤ end_num ≤ start_num ≤ 50

        //입출력 예
        //start_num         end_num         result
        //10	                3	        [10, 9, 8, 7, 6, 5, 4, 3]

        //입출력 예 설명
        //입출력 예 #1
        //10부터 3까지 1씩 감소하는 수를 담은 리스트는[10, 9, 8, 7, 6, 5, 4, 3] 입니다.
        public int[] solution54(int start, int end_num)
        {
            int[] answer = new int[] { };
            List<int> li = new List<int>();
            for (int i = start; i >= end_num; i--) li.Add(i);
            answer = li.ToArray();
            return answer;
        }
        //다른사람 풀이
        //return Enumerable.Range(end, start - end + 1).Reverse().ToArray();
    }
}
