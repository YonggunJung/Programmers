using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 배열의_원소_삭제하기
    {
        //문제 설명
        //정수 배열 arr과 delete_list가 있습니다.
        //arr의 원소 중 delete_list의 원소를 모두 삭제하고
        //남은 원소들은 기존의 arr에 있던 순서를 유지한 배열을
        //return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //1 ≤ arr의 길이 ≤ 100
        //1 ≤ arr의 원소 ≤ 1,000
        //arr의 원소는 모두 서로 다릅니다.
        //1 ≤ delete_list의 길이 ≤ 100
        //1 ≤ delete_list의 원소 ≤ 1,000
        //delete_list의 원소는 모두 서로 다릅니다.

        //입출력 예
        //arr                           delete_list                         result
        //[293, 1000, 395, 678, 94]     [94, 777, 104, 1000, 1, 12]         [293, 395, 678]
        //[110, 66, 439, 785, 1]        [377, 823, 119, 43]                 [110, 66, 439, 785, 1]

        //입출력 예 설명
        //입출력 예 #1
        //예제 1번의 arr의 원소 중 1000과 94가 delete_list에 있으므로
        //이 두 원소를 삭제한[293, 395, 678] 을 return 합니다.

        //입출력 예 #2
        //예제 2번의 arr의 원소 중 delete_list에 있는 원소는 없습니다.
        //따라서 arr 그대로인 [110, 66, 439, 785, 1] 을 return 합니다.
        public int[] solution109(int[] arr, int[] delete_list)
        {
            int[] answer = new int[] { };
            List<int> li = new List<int>();
            for(int i = 0; i< arr.Length; i++)
            {
                bool f = false;
                for (int j = 0; j < delete_list.Length; j++)
                {
                    if (arr[i] == delete_list[j])
                    {
                        f = true;
                    }
                }
                if (!f) li.Add(arr[i]);

            }
            answer = li.ToArray();
            return answer;
        }
        // 다른사람 풀이
        //public int[] solution(int[] arr, int[] delete_list) => arr.Except(delete_list).ToArray();

        //다른 사람 풀이2
        //return arr.Where(w => !delete_list.Contains(w)).ToArray()

        //다른 사람 풀이3
        //return arr.Where(n => !delete_list.Contains(n)).ToArray();
    }
}
