using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Programemrs
{
    internal class 코드_처리하기
    {
        //문제 설명
        //문자열 code가 주어집니다.
        //code를 앞에서부터 읽으면서 만약 문자가 "1"이면 mode를 바꿉니다.
        //mode에 따라 code를 읽어가면서 문자열 ret을 만들어냅니다.

        //mode는 0과 1이 있으며,
        //idx를 0 부터 code의 길이 - 1 까지 1씩 키워나가면서
        //code[idx] 의 값에 따라 다음과 같이 행동합니다.

        //mode가 0일 때
        //code[idx] 가 "1"이 아니면 idx가 짝수일 때만 ret의 맨 뒤에 code[idx] 를 추가합니다.
        //code[idx] 가 "1"이면 mode를 0에서 1로 바꿉니다.

        //mode가 1일 때
        //code[idx] 가 "1"이 아니면 idx가 홀수일 때만 ret의 맨 뒤에 code[idx] 를 추가합니다.
        //code[idx] 가 "1"이면 mode를 1에서 0으로 바꿉니다.
        //문자열 code를 통해 만들어진 문자열 ret를 return 하는 solution 함수를 완성해 주세요.
        //단, 시작할 때 mode는 0이며, return 하려는 ret가 만약 빈 문자열이라면 대신 "EMPTY"를 return 합니다.

        //제한사항
        //1 ≤ code의 길이 ≤ 100,000
        //code는 알파벳 소문자 또는 "1"로 이루어진 문자열입니다.

        //입출력 예
        //code result
        //"abc1abc1abc"	"acbac"
        //입출력 예 설명
        //입출력 예 #1

        //code의 각 인덱스 i에 따라 다음과 같이 mode와 ret가 변합니다.
        //i code[i] mode ret
        //0	"a"	0	"a"
        //1	"b"	0	"a"
        //2	"c"	0	"ac"
        //3	"1"	1	"ac"
        //4	"a"	1	"ac"
        //5	"b"	1	"acb"
        //6	"c"	1	"acb"
        //7	"1"	0	"acb"
        //8	"a"	0	"acba"
        //9	"b"	0	"acba"
        //10	"c"	0	"acbac"
        //따라서 "acbac"를 return 합니다.
        public string solution20(string code)
        {
            string answer = "";
            int mode = 0;
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '1')
                {
                    mode = (mode + 1) % 2;
                    continue;
                }
                if (mode == 0)
                {
                    if (i % 2 == 0)
                    {
                        answer += code[i];
                    }
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        answer += code[i];
                    }
                }
            }
            if (answer.Length == 0)
            {
                answer = "EMPTY";
            }
            return answer;
        }
        // 다른 사람 풀이
        // !mode 이것만 알면 될듯
        //string answer = "";
        //bool mode = false; // false = 0 true = 1

        //for(int i=0; i<code.Length; i++)
        //{
        //    if(code[i] == '1')
        //    {
        //        mode = !mode;
        //        continue;                
        //    }

        //    if(mode && i%2 == 1)
        //        answer += code[i];
        //    else if(!mode && i%2 == 0)
        //        answer += code[i];
        //}
        //if (answer.Length == 0)
        //    answer = "EMPTY";
        //return answer;

        //다른 사람풀이2
        //int mode = 0;
        //string answer = "";
        //for(int i = 0; i<code.Length; i++){
        //    string ex = $"{code[i]}";
        //    if(ex == "1")
        //        mode = mode == 0 ? 1 : 0 ;
        //    if(mode == 0&& ex != "1")
        //        answer += i%2 == 0 ? ex : "" ;
        //    if(mode == 1&& ex != "1")
        //        answer += i%2 == 1 ? ex : "";   
        //}
        //return answer == "" ? "EMPTY" : answer;

        //다른사람풀이 3
        //string answer = "";
        //int mood = 0;
        //for(int i=0;i<code.Length;i++)
        //{
        //    switch(code[i])
        //    {
        //        case '1':
        //            mood = mood == 1 ? 0 : 1;
        //            break;
        //        default:
        //            if((mood + i)%2 == 0 )  answer += code[i];
        //            break;
        //    }
        //}
        //if (answer == "") return "EMPTY";
        //return answer;
    }
}
