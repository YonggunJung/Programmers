using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 저주의_숫자_3
    {
        //문제 설명
        //3x 마을 사람들은 3을 저주의 숫자라고 생각하기 때문에
        //3의 배수와 숫자 3을 사용하지 않습니다.
        //3x 마을 사람들의 숫자는 다음과 같습니다.

        //10진법    3x 마을에서 쓰는 숫자	10진법    3x 마을에서 쓰는 숫자
        //1	            1	                    6	            8
        //2         	2	                    7	            10
        //3	            4	                    8	            11
        //4	            5	                    9	            14
        //5	            7	                    10	            16
        //정수 n이 매개변수로 주어질 때,
        //n을 3x 마을에서 사용하는 숫자로 바꿔 return하도록 solution 함수를 완성해주세요.

        //제한사항
        //1 ≤ n ≤ 100

        //입출력 예
        //n         result
        //15	        25
        //40	        76

        //입출력 예 설명

        //15를 3x 마을의 숫자로 변환하면 25입니다.

        //입출력 예 #2
        //40을 3x 마을의 숫자로 변환하면 76입니다.
        public int solution164(int n)
        {
            // 별 어려운게 아닌데 머리가 안돌아가네 ㅠㅠ
            // 시간은 좀 걸렸지만 풀었음
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                answer++;
                string s = answer.ToString();
                if (s.Contains("3") || answer % 3 == 0)
                {
                    for (int j = answer + 1; j < int.MaxValue; j++)
                    {
                        string ss = j.ToString();
                        if (!(ss.Contains("3")) && j % 3 != 0)
                        {
                            answer = j;
                            break;
                        }
                    }
                }
            }
            return answer;
        }
        // 다른 사람 풀이
        // 이거 괜찮네, 나보다 간단하고 쉽네
        //int count = 1;
        //for(int i=0;i<n;i++)
        //{
        //    answer++;
        //    while(answer%3==0||answer.ToString().Contains("3"))
        //    {
        //        answer++;
        //    }
        //}
        //return answer;

        static void Main164(string[] args)
        {
            int n = 40;
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                answer++;
                string s = answer.ToString();
                if (s.Contains("3") || answer % 3 == 0)
                {
                    for (int j = answer + 1; j < int.MaxValue; j++)
                    {
                        string ss = j.ToString();
                        if (!(ss.Contains("3")) && j % 3 != 0)
                        {
                            answer = j;
                            break;
                        }
                    }
                }
                Console.WriteLine(answer);
            }
        }
    }
}
