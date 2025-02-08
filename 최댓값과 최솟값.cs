using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv2
{
    internal class 최댓값과_최솟값
    {
        //문제 설명
        //문자열 s에는 공백으로 구분된 숫자들이 저장되어 있습니다.
        //str에 나타나는 숫자 중 최소값과 최대값을 찾아
        //이를 "(최소값) (최대값)"형태의 문자열을 반환하는 함수,
        //solution을 완성하세요.
        //예를들어 s가 "1 2 3 4"라면 "1 4"를 리턴하고,
        //"-1 -2 -3 -4"라면 "-4 -1"을 리턴하면 됩니다.

        //제한 조건
        //s에는 둘 이상의 정수가 공백으로 구분되어 있습니다.

        //입출력 예
        //s	                        return
        //"1 2 3 4"	                "1 4"
        //"-1 -2 -3 -4"	            "-4 -1"
        //"-1 -1"	                "-1 -1"

        public string solution1(string s)
        {
            string answer = "";
            string[] arr = s.Split(' ');
            List<int> li = new List<int>();
            foreach (var num in arr)
            {
                li.Add(int.Parse(num));
            }
            answer = li.Min() + " " + li.Max();
            return answer;
        }

        // 다른 사람 풀이
        // 이렇게 되는군 확인
        //int[] temp = s.Split(' ').Select(int.Parse).ToArray();
        //answer = temp.Min().ToString() + " " +temp.Max().ToString();
    }
}
