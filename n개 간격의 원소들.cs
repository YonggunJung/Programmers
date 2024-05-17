using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class n개_간격의_원소들
    {
        //문제 설명
        //정수 리스트 num_list와 정수 n이 주어질 때,
        //num_list의 첫 번째 원소부터 마지막 원소까지 n개 간격으로 저장되어있는 원소들을
        //차례로 담은 리스트를 return하도록 solution 함수를 완성해주세요.

        //제한사항
        //5 ≤ num_list의 길이 ≤ 20
        //1 ≤ num_list의 원소 ≤ 9
        //1 ≤ n ≤ 4

        //입출력 예
        //num_list                  n       result
        //[4, 2, 6, 1, 7, 6]	    2	    [4, 6, 7]
        //[4, 2, 6, 1, 7, 6]	    4	    [4, 7]

        //입출력 예 설명
        //입출력 예 #1
        //[4, 2, 6, 1, 7, 6] 에서 2개 간격으로 저장되어 있는 원소들은[4, 6, 7] 입니다.

        //입출력 예 #2
        //[4, 2, 6, 1, 7, 6] 에서 4개 간격으로 저장되어 있는 원소들은[4, 7] 입니다.
        public int[] solution65(int[] num_list, int n)
        {
            int[] answer = new int[] { };
            List<int> li = new List<int>();
            for(int i = 0; i<num_list.Length; i+=n)
            {
                li.Add(num_list[i]);
            }
            answer = li.ToArray();
            return answer;
        }
        //다른사람 풀이
        //이렇게도 가능하군
        //for(int i =0;i<answer.Length;i++) answer[i]=num_list[i * n];

        //2. where()는 조건 기억하겠어
        //return num_list.Where((num, index) => 0 == (index % n)).ToArray();
    }
}
