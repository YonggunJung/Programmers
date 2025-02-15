using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv2
{
    class 괄호_회전하기
    {
        //문제 설명
        //다음 규칙을 지키는 문자열을 올바른 괄호 문자열이라고 정의합니다.

        //(), [], {} 는 모두 올바른 괄호 문자열입니다.
        //만약 A가 올바른 괄호 문자열이라면,
        //(A), [A], {A} 도 올바른 괄호 문자열입니다.
        //예를 들어, [] 가 올바른 괄호 문자열이므로,
        //([]) 도 올바른 괄호 문자열입니다.
        //만약 A, B가 올바른 괄호 문자열이라면,
        //AB 도 올바른 괄호 문자열입니다.
        //예를 들어, { } 와([]) 가 올바른 괄호 문자열이므로,
        //{}([]) 도 올바른 괄호 문자열입니다.
        //대괄호, 중괄호, 그리고 소괄호로 이루어진 문자열 s가 매개변수로 주어집니다.
        //이 s를 왼쪽으로 x (0 ≤ x < (s의 길이)) 칸만큼 회전시켰을 때
        //s가 올바른 괄호 문자열이 되게 하는 x의 개수를
        //return 하도록 solution 함수를 완성해주세요.

        //제한사항
        //s의 길이는 1 이상 1,000 이하입니다.

        //입출력 예
        //s	                result
        //"[](){}"	            3
        //"}]()[{"	            2
        //"[)(]"	            0   
        //"}}}"	                0

        //입출력 예 설명
        //입출력 예 #1
        //다음 표는 "[](){}" 를 회전시킨 모습을 나타낸 것입니다.
        //x	s를 왼쪽으로 x칸만큼 회전	올바른 괄호 문자열?
        //0	"[](){}"	O
        //1	"](){}["	X
        //2	"(){}[]"	O
        //3	"){}[]("	X
        //4	"{}[]()"	O
        //5	"}[](){"	X
        //올바른 괄호 문자열이 되는 x가 3개이므로,
        //3을 return 해야 합니다.

        //입출력 예 #2
        //다음 표는 "}]()[{" 를 회전시킨 모습을 나타낸 것입니다.
        //x	s를 왼쪽으로 x칸만큼 회전	올바른 괄호 문자열?
        //0	"}]()[{"	X
        //1	"]()[{}"	X
        //2	"()[{}]"	O
        //3	")[{}]("	X
        //4	"[{}]()"	O
        //5	"{}]()["	X
        //올바른 괄호 문자열이 되는 x가 2개이므로,
        //2를 return 해야 합니다.

        //입출력 예 #3
        //s를 어떻게 회전하더라도 올바른 괄호 문자열을 만들 수 없으므로,
        //0을 return 해야 합니다.

        //입출력 예 #4
        //s를 어떻게 회전하더라도 올바른 괄호 문자열을 만들 수 없으므로,
        //0을 return 해야 합니다.

        public int solution16(string s)
        {
            int answer = 0;
            int n = s.Length;

            // 문자열 내 괄호 쌍이 같은 개수인지 확인
            int bo = s.Count(c => c == '[');
            int bc = s.Count(c => c == ']');
            int mo = s.Count(c => c == '{');
            int mc = s.Count(c => c == '}');
            int so = s.Count(c => c == '(');
            int sc = s.Count(c => c == ')');
            if (bo != bc || mo != mc || so != sc)
            {
                return answer;
            }

            // 회전된 문자열에 대해 확인
            for (int i = 0; i < n; i++)
            {
                string rotated = s.Substring(i) + s.Substring(0, i);
                if (IsValidParentheses(rotated))
                {
                    answer++;
                }
            }

            return answer;
        }

        // 괄호 문자열이 올바른지 확인하는 함수
        private bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '[' || c == '{' || c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false;

                    char open = stack.Pop();
                    if ((c == ']' && open != '[') ||
                        (c == '}' && open != '{') ||
                        (c == ')' && open != '('))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;

            // 개 같이 풀었는데 런타임 에러 맞았네 ㅠㅠ
            //결국 스택이구나 ㅠㅠ
            //int answer = 0;
            //int bo = s.Count(c => c == '[');
            //int bc = s.Count(c => c == ']');
            //int mo = s.Count(c => c == '{');
            //int mc = s.Count(c => c == '}');
            //int so = s.Count(c => c == '(');
            //int sc = s.Count(c => c == ')');
            //if (bo == bc && mo == mc && so == sc)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        s = s.Substring(1) + s[0];
            //        if (s[0] == ']' || s[0] == '}' || s[0] == ')' || s[s.Length - 1] == '[' || s[s.Length - 1] == '{' || s[s.Length - 1] == '(')
            //        {
            //            continue;
            //        }
            //        bool b = true;
            //        int boc = 0;
            //        int bcc = 0;
            //        int moc = 0;
            //        int mcc = 0;
            //        int soc = 0;
            //        int scc = 0;
            //        List<char> li = new List<char>();
            //        for (int j = 0; j < s.Length; j++)
            //        {
            //            if (s[j] == '[')
            //            {
            //                li.Add('[');
            //                boc++;
            //            }
            //            else if (s[j] == ']')
            //            {
            //                if (li[li.Count -1] == '[')
            //                {
            //                    li.RemoveAt(li.Count - 1);
            //                }
            //                else
            //                {
            //                    b = false;
            //                    break;
            //                }
            //                bcc++;
            //            }
            //            else if (s[j] == '{')
            //            {
            //                li.Add('{');
            //                moc++;
            //            }
            //            else if (s[j] == '}')
            //            {
            //                if (li[li.Count - 1] == '{')
            //                {
            //                    li.RemoveAt(li.Count - 1);
            //                }
            //                else
            //                {
            //                    b = false;
            //                    break;
            //                }
            //                mcc++;
            //            }
            //            else if (s[j] == '(')
            //            {
            //                li.Add('(');
            //                soc++;
            //            }
            //            else if (s[j] == ')')
            //            {
            //                if (li[li.Count - 1] == '(')
            //                {
            //                    li.RemoveAt(li.Count - 1);
            //                }
            //                else
            //                {
            //                    b = false;
            //                    break;
            //                }
            //                scc++;
            //            }

            //            if (bcc > boc || mcc > moc || scc > soc)
            //            {
            //                b = false;
            //                break;
            //            }
            //        }
            //        if (b) answer++;
            //    }
            //}
        }
    }
}
