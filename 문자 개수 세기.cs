using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 문자_개수_세기
    {
        //문제 설명
        //알파벳 대소문자로만 이루어진 문자열 my_string이 주어질 때,
        //my_string에서 'A'의 개수,
        //my_string에서 'B'의 개수,...,
        //my_string에서 'Z'의 개수,
        //my_string에서 'a'의 개수,
        //my_string에서 'b'의 개수,...,
        //my_string에서 'z'의 개수를 순서대로 담은 길이 52의 정수 배열을 return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //1 ≤ my_string의 길이 ≤ 1,000

        //입출력 예
        //my_string         result
        //"Programmers"	    [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 3, 1, 0, 0, 0, 0, 0, 0, 0]

        //입출력 예 설명
        //입출력 예 #1

        //예제 1번의 my_string에서 'P'가 1개,
        //'a'가 1개,
        //'e'가 1개,
        //'g'가 1개,
        //'m'이 2개,
        //'o'가 1개,
        //'r'가 3개,
        //'s'가 1개 있으므로
        //[0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 3, 1, 0, 0, 0, 0, 0, 0, 0]를 return 합니다.
        public int[] solution51(string my_string)
        {
            int[] answer = new int[52];
            List<int> li = new List<int>(answer);
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i<my_string.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (my_string[i] == abc[j])
                        li[j]++;
                }
            }
            answer = li.ToArray();
            return answer;
        }
        // 다른 사람 풀이
        // Char.IsUpper() 이게 기억이 안났음
        //    int[] answer = new int[52];
        //    foreach(char c in my_string)
        //    {
        //        if(Char.IsUpper(c))
        //            answer[c - 'A']++;
        //        else
        //            answer[26 + c - 'a']++;
        //    }
        //    return answer;
        // A = 65, a = 97    
    }
}
