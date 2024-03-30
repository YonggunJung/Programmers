using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    //문제 설명
    //연산 ⊕는 두 정수에 대한 연산으로 두 정수를 붙여서 쓴 값을 반환합니다.
    //예를 들면 다음과 같습니다.
    //12 ⊕ 3 = 123
    //3 ⊕ 12 = 312
    //양의 정수 a와 b가 주어졌을 때, a ⊕ b와 b ⊕ a 중
    //더 큰 값을 return 하는 solution 함수를 완성해 주세요.
    //단, a ⊕ b와 b ⊕ a가 같다면 a ⊕ b를 return 합니다.

    //제한사항
    //1 ≤ a, b< 10,000

    //입출력 예
    //a     b      result
    //9	    91	    991
    //89	8	    898

    //입출력 예 설명
    //입출력 예 #1
    //a ⊕ b = 991 이고, b ⊕ a = 919 입니다.
    //둘 중 더 큰 값은 991 이므로 991을 return 합니다.

    //입출력 예 #2
    //a ⊕ b = 898 이고, b ⊕ a = 889 입니다.
    //둘 중 더 큰 값은 898 이므로 898을 return 합니다.
    internal class 더_크게_합치기
    {
        public int solution13(int a, int b)
        {
            //Tostring()사용 칭찬해
            int answer = 0;
            string ab = a.ToString() + b.ToString();
            string ba = b.ToString() + a.ToString();
            int s1 = int.Parse(ab);
            int s2 = int.Parse(ba);
            if (s1 >= s2)
            {
                answer = s1;
            }
            else
            {
                answer = s2;
            }
            return answer;
        }
        //다른 사람 풀이
        //와 이런게 있었네, 두 개나 배웠음
        //int aNum = Int32.Parse($"{a}{b}");
        //int bNum = Int32.Parse($"{b}{a}");
        //return Math.Max(aNum, bNum);


    }
}
