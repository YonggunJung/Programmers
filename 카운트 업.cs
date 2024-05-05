using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 카운트_업
    {
        //문제 설명
        //정수 start_num와 end_num가 주어질 때,
        //start_num부터 end_num까지의 숫자를 차례로 담은 리스트를
        //return하도록 solution 함수를 완성해주세요.

        //제한사항
        //0 ≤ start_num ≤ end_num ≤ 50
        //입출력 예
        //start_num end_num result
        //3	10	[3, 4, 5, 6, 7, 8, 9, 10]
        //입출력 예 설명
        //입출력 예 #1

        //3부터 10까지의 숫자들을 담은 리스트 [3, 4, 5, 6, 7, 8, 9, 10] 를 return합니다.
        public int[] solution31(int start_num, int end_num)
        {
            int[] answer = new int[] { };
            List<int> li = new List<int>();
            for (int i = start_num; i<=end_num; i++)
            {
                li.Add(i);
            }
            answer = li.ToArray();
            return answer;
        }

        //다른 사람풀이
        //이거 참 간단하고 좋구만
        //return Enumerable.Range(start, end - start + 1).ToArray();
    }
}
