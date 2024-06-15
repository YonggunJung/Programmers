using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 배열의_길이를_2의_거듭제곱으로_만들기
    {
        //문제 설명
        //정수 배열 arr이 매개변수로 주어집니다.
        //arr의 길이가 2의 정수 거듭제곱이 되도록
        //arr 뒤에 정수 0을 추가하려고 합니다.
        //arr에 최소한의 개수로 0을 추가한 배열을
        //return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //1 ≤ arr의 길이 ≤ 1,000
        //1 ≤ arr의 원소 ≤ 1,000

        //입출력 예
        //arr                       result
        //[1, 2, 3, 4, 5, 6]        [1, 2, 3, 4, 5, 6, 0, 0]
        //[58, 172, 746, 89]        [58, 172, 746, 89]

        //입출력 예 설명
        //입출력 예 #1
        //예제 1번의 arr의 길이는 6입니다.
        //arr의 길이를 2의 정수 거듭제곱으로 만드는 방법은
        //0을 2개, 10개, 26개,..., 추가하는 방법이 있고
        //그중 최소한으로 0을 추가하는 방법은 2개를 추가하는 것입니다.
        //따라서[1, 2, 3, 4, 5, 6, 0, 0] 을 return 합니다.

        //입출력 예 #2
        //예제 2번의 arr의 길이는 4이고 이미 2의 정수 거듭제곱입니다.
        //따라서 뒤에 0을 추가하지 않아도 되므로[58, 172, 746, 89]를 return 합니다.
        public int[] solution96(int[] arr)
        {
            int[] answer = new int[] { };
            List<int> li = new List<int>(arr);
            int n = 1;
            while (n < arr.Length) 
            {
                n *= 2;
            }

            while (n > li.Count)
            {
                li.Add(0);
            }
            answer = li.ToArray();
            return answer;
        }
        // 다른 사람 풀이
        // 리사이즈 좋네 
        //int a = 1;
        //while(a<arr.Length)
        //{
        //    a *= 2;
        //}
        //Array.Resize(ref arr, a);
        //return arr;
    }
}
