using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 배열_만들기_2
    {
        //문제 설명
        //정수 l과 r이 주어졌을 때, l 이상 r이하의 정수 중에서 숫자 "0"과 "5"로만 이루어진 모든 정수를 오름차순으로 저장한 배열을 return 하는 solution 함수를 완성해 주세요.

        //만약 그러한 정수가 없다면, -1이 담긴 배열을 return 합니다.

        //제한사항
        //1 ≤ l ≤ r ≤ 1,000,000
        //입출력 예
        //l r   result
        //5	555	[5, 50, 55, 500, 505, 550, 555]
        //10	20	[-1]
        //    입출력 예 설명
        //    입출력 예 #1

        //5 이상 555 이하의 0과 5로만 이루어진 정수는 작은 수부터 5, 50, 55, 500, 505, 550, 555가 있습니다.따라서 [5, 50, 55, 500, 505, 550, 555] 를 return 합니다.
        //입출력 예 #2

        //10 이상 20 이하이면서 0과 5로만 이루어진 정수는 없습니다. 따라서[-1] 을 return 합니다.
        public static int[] solution30(int l, int r)
        {
            //list의 길이는 Count이다.
            //별거 아닌건데 너무 오래 걸렸음 C#이랑 더 친해져야 겠음
            int[] answer = new int[] { };
            List<int> li = new List<int>();
            for (int i = l; i<=r; i++)
            {
                string s = i.ToString();
                if (s.Contains('1')) continue;
                else if (s.Contains('2')) continue;
                else if (s.Contains('3')) continue;
                else if (s.Contains('4')) continue;
                else if (s.Contains('6')) continue;
                else if (s.Contains('7')) continue;
                else if (s.Contains('8')) continue;
                else if (s.Contains('9')) continue;
                else li.Add(i);
            }
            if(li.Count > 0)
                answer = li.ToArray();
            return answer;
        }
        //다른 사람 풀이
        //람다식을 알면 편하게 부틑 거였군 
        //int[] answer = new int[] { };
        //answer = Enumerable.Range(l, r - l + 1).
        //           Where(x => x.ToString().All(y=> y == '5' || y == '0')).ToArray();
        //if(answer.Length <= 0)
        //    return new int[] {-1};
        //return answer;

        //이거 참 신기하게 풀었네 이해는 못함
        //while(l % 5 != 0)
        //    ++l;
        //var list = new List<int>();
        //for(int i = l; i <= r; i += 5)
        //{
        //    string str = i.ToString().Replace("0", "").Replace("5", "");
        //    if(string.IsNullOrEmpty(str))
        //        list.Add(i);
        //}
        //return list.Count == 0 ? new int[1] { -1 } : list.ToArray();
static void Main30(string[] args)
        {
            solution(5, 555);
        }
    }
}
