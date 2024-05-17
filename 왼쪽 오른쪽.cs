using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 왼쪽_오른쪽
    {
        //문제 설명
        //문자열 리스트 str_list에는
        //"u", "d", "l", "r" 네 개의 문자열이 여러 개 저장되어 있습니다.
        //str_list에서 "l"과 "r" 중 먼저 나오는 문자열이 "l"이라면
        //해당 문자열을 기준으로 왼쪽에 있는 문자열들을 순서대로 담은 리스트를,
        //먼저 나오는 문자열이 "r"이라면
        //해당 문자열을 기준으로 오른쪽에 있는 문자열들을 순서대로 담은 리스트를
        //return하도록 solution 함수를 완성해주세요. "l"이나 "r"이 없다면 빈 리스트를 return합니다.

        //제한사항
        //1 ≤ str_list의 길이 ≤ 20
        //str_list는 "u", "d", "l", "r" 네 개의 문자열로 이루어져 있습니다.

        //입출력 예
        //str_list                  result
        //["u", "u", "l", "r"]      ["u", "u"]
        //["l"]                     []

        //입출력 예 설명
        //입출력 예 #1
        //"r"보다 "l"이 먼저 나왔기 때문에
        //"l"의 왼쪽에 있는 문자열들을 담은 리스트인 ["u", "u"] 를 return합니다.

        //입출력 예 #2
        //"l"의 왼쪽에 문자열이 없기 때문에 빈 리스트를 return합니다.
        public string[] solution63(string[] str_list)
        {
            string[] answer = new string[] { };
            for (int i = 0; i<str_list.Length; i++)
            {
                if (str_list[i] == "r")
                { 
                    answer = str_list.Skip(i+1).ToArray();
                    break; 
                }
                else if (str_list[i] == "l")
                {
                    answer = str_list.Take(i).ToArray();
                    break;
                }
            }
            return answer;
        }
        // 다른사람 풀이
        // 내꺼랑 비슷하면서도 다른
        //int l = Array.IndexOf(str_list, "l");
        //int r = Array.IndexOf(str_list, "r");
        //return (l == -1 && r == -1) ? new string[] { } :
        //       ((l == -1 ? r + 1 : l) < (r == -1 ? l + 1 : r) ?
        //        str_list.Take(l).ToArray() : str_list.Skip(r + 1).ToArray());
    }
}
