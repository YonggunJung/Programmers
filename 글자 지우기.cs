using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 글자_지우기
    {
        //문제 설명
        //문자열 my_string과 정수 배열 indices가 주어질 때,
        //my_string에서 indices의 원소에 해당하는 인덱스의 글자를 지우고 이어 붙인 문자열을
        //return 하는 solution 함수를 작성해 주세요.

        //제한사항
        //1 ≤ indices의 길이<my_string의 길이 ≤ 100
        //my_string은 영소문자로만 이루어져 있습니다
        //0 ≤ indices의 원소 < my_string의 길이
        //indices의 원소는 모두 서로 다릅니다.

        //입출력 예
        //my_string                     indices                             result
        //"apporoograpemmemprs"	        [1, 16, 6, 15, 0, 10, 11, 3]        "programmers"

        //입출력 예 설명
        //입출력 예 #1
        //예제 1번의 my_string의 인덱스가 잘 보이도록 표를 만들면 다음과 같습니다.
        //index         0	1	2	3	4	5	6	7	8	9	10	11	12	13	14	15	16	17	18
        //my_string     a   p   p   o   r   o   o   g   r   a   p    e   m   m   e   m   p   r   s
        //indices에 있는 인덱스의 글자들을 지우고 이어붙이면 "programmers"가 되므로 이를 return 합니다.
        public string solution53(string my_string, int[] indices)
        {
            string answer = "";
            List<int> li = new List<int>(indices);
            li.Sort(new Comparison<int>((n1, n2) => n2.CompareTo(n1)));
            foreach(int i in li)
            {
                my_string = my_string.Remove(i, 1);
            }
            answer = my_string;
            return answer;
        }
        // 다른 사람 풀이
        // 이런거 정말 편해 보이는 구만
        //return new string (my_string.Where((w, index) => !indices.Contains(index)).ToArray());

        // 다른사람풀이 2
        //char[] arr = my_string.ToCharArray();
        //string answer = "";
        //for (int i = 0; i<indices.Length; i++)
        //    arr[indices[i]] = ' ';
        //answer = new string (arr).Replace(" ","");
        //return answer;

        static void Main53(string[] args)
        {
            int[] indices = { 1, 16, 6, 15, 0, 10, 11, 3 };
            List<int> li = new List<int>(indices);
            li.Sort(new Comparison<int>((n1, n2) => n2.CompareTo(n1)));

            Console.WriteLine(li[0]);

            string str = "apporoograpemmemprs";

            foreach (int i in li)
            {
                str = str.Remove(i, 1);
            }
            Console.WriteLine(str);
        }
    }
}
