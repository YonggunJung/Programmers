using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 주사위_게임_1
    {
        //문제 설명
        //1부터 6까지 숫자가 적힌 주사위가 두 개 있습니다.
        //두 주사위를 굴렸을 때 나온 숫자를 각각 a, b라고 했을 때 얻는 점수는 다음과 같습니다.

        //a와 b가 모두 홀수라면 a2 + b2 점을 얻습니다.
        //a와 b 중 하나만 홀수라면 2 × (a + b) 점을 얻습니다.
        //a와 b 모두 홀수가 아니라면 |a - b| 점을 얻습니다.
        //두 정수 a와 b가 매개변수로 주어질 때, 얻는 점수를 return 하는 solution 함수를 작성해 주세요.
        //제한사항
        //a와 b는 1 이상 6 이하의 정수입니다.

        //입출력 예
        //a     b       result
        //3	    5	    34
        //6	    1	    14
        //2	    4	    2
        //입출력 예 설명
        //입출력 예 #1
        //예제 1번에서 두 주사위 숫자가 모두 홀수이므로
        //32 + 52 = 9 + 25 = 34점을 얻습니다.
        //따라서 34를 return 합니다.

        //입출력 예 #2
        //예제 2번에서 두 주사위 숫자 중 하나만 홀수이므로
        //2 × (6 + 1) = 2 × 7 = 14점을 얻습니다.
        //따라서 14를 return 합니다.

        //입출력 예 #3
        //예제 3번에서 두 주사위 숫자가 모두 홀수가 아니므로
        //|2 - 4| = |-2| = 2점을 얻습니다.
        //따라서 2를 return 합니다.
        public int solution114(int a, int b)
        {
            int answer = 0;
            if (a % 2 == 1 && b % 2 == 1) answer = a * a + b * b;
            else if (a % 2 == 1 || b % 2 == 1) answer = (a + b) * 2;
            else  answer = Math.Abs(a - b);
            return answer;
        }

    }
}
