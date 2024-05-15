using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 배열_조각하기
    {
        //문제 설명
        //정수 배열 arr와 query가 주어집니다.
        //query를 순회하면서 다음 작업을 반복합니다.
        //짝수 인덱스에서는 arr에서 query[i]번 인덱스를 제외하고
        //배열의 query[i] 번 인덱스 뒷부분을 잘라서 버립니다.
        //홀수 인덱스에서는 arr에서 query[i] 번 인덱스는 제외하고
        //배열의 query[i] 번 인덱스 앞부분을 잘라서 버립니다.
        //위 작업을 마친 후 남은 arr의 부분 배열을 return 하는 solution 함수를 완성해 주세요.

        //제한사항
        //5 ≤ arr의 길이 ≤ 100,000
        //0 ≤ arr의 원소 ≤ 100
        //1 ≤ query의 길이 < min(50, arr의 길이 / 2)
        //query의 각 원소는 0보다 크거나 같고 남아있는 arr의 길이 보다 작습니다.

        //입출력 예
        //arr                       query           result
        //[0, 1, 2, 3, 4, 5]        [4, 1, 2]       [1, 2, 3]

        //입출력 예 설명
        //입출력 예 #1
        //이번에 매번 처리할 query의 값과 처리 전후의 arr의 상태를 표로 나타내면 다음과 같습니다.
        //query의 값      query 처리 전          query 처리 후          비고
        //4	              [0, 1, 2, 3, 4, 5]     [0, 1, 2, 3, 4]        0번 인덱스의 쿼리이므로 뒷부분을 자른다.
        //1	              [0, 1, 2, 3, 4]        [1, 2, 3, 4]           1번 인덱스의 쿼리이므로 앞부분을 자른다.
        //2	              [1, 2, 3, 4]           [1, 2, 3]              2번 인덱스의 쿼리이므로 뒷부분을 자른다.
        //따라서[1, 2, 3] 을 return 합니다.
        public int[] solution(int[] arr, int[] query)
        {
            // 문제 이해 잘못해서 오려걸리고,
            //더하기 빼기 헷갈려서 오래걸림ㅠㅠ
            int[] answer = new int[] { };
            List<int> li = new List<int>(arr);
            for (int i = 0; i<query.Length; i++)
            {
                if (i %2 == 0)
                {
                    li.RemoveRange(query[i] + 1, li.Count - query[i]-1);
                }
                else
                {
                    li.RemoveRange(0, query[i]);
                }
            }
            answer = li.ToArray();
            return answer;
        }
        //다른 사람 풀이
        //Take()와 Skip()를 알아두면 편한거 같음.
//        int[] answer = new int[] { };
//        for(int i=0; i<query.Length; i++)
//        {
//            if (i % 2 == 0)
//            {
//                arr = arr.Take(query[i]+1).ToArray();
//            }
//            else
//            {
//                arr = arr.Skip(query[i]).ToArray();
//            }
//        }        
//        answer = arr;
//        return answer;
static void Main60(string[] args)
        {
            int[] query = {4, 1, 2};
            int[] arr = { 0, 1, 2, 3, 4, 5 };
            List<int> li = new List<int>(arr);
            //Console.WriteLine(li[5]);
            li.RemoveRange(query[0] + 1, li.Count - query[0] + 1);
            Console.WriteLine(li.Count);
            li.RemoveRange(0, query[1]);
            Console.WriteLine(li[0]);
            li.RemoveRange(query[2] + 1, li.Count - query[2] + 1);
            Console.WriteLine(li.Count);

            //for (int i = 0;i<li.Count;i++)
            //{
            //    Console.WriteLine(li[i]);
            //}
        }
    }
}
