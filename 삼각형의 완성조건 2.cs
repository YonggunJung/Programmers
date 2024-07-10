using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 삼각형의_완성조건_2
    {
        //문제 설명
        //선분 세 개로 삼각형을 만들기 위해서는 다음과 같은 조건을 만족해야 합니다.

        //가장 긴 변의 길이는 다른 두 변의 길이의 합보다 작아야 합니다.
        //삼각형의 두 변의 길이가 담긴 배열 sides이 매개변수로 주어집니다.
        //나머지 한 변이 될 수 있는 정수의 개수를 return하도록 solution 함수를 완성해주세요.

        //제한사항
        //sides의 원소는 자연수입니다.
        //sides의 길이는 2입니다.
        //1 ≤ sides의 원소 ≤ 1,000

        //입출력 예
        //sides         result
        //[1, 2]            1
        //[3, 6]            5
        //[11, 7]          13

        //입출력 예 설명
        //입출력 예 #1
        //두 변이 1, 2 인 경우 삼각형을 완성시키려면 나머지 한 변이 2여야 합니다.
        //따라서 1을 return합니다.

        //입출력 예 #2
        //가장 긴 변이 6인 경우
        //될 수 있는 나머지 한 변은 4, 5, 6 로 3개입니다.
        //나머지 한 변이 가장 긴 변인 경우
        //될 수 있는 한 변은 7, 8 로 2개입니다.
        //따라서 3 + 2 = 5를 return합니다.

        //입출력 예 #3
        //가장 긴 변이 11인 경우
        //될 수 있는 나머지 한 변은 5, 6, 7, 8, 9, 10, 11 로 7개입니다.
        //나머지 한 변이 가장 긴 변인 경우
        //될 수 있는 한 변은 12, 13, 14, 15, 16, 17 로 6개입니다.
        //따라서 7 + 6 = 13을 return합니다.
        public int solution166(int[] sides)
        {
            int answer = 0;
            int s = sides[0];
            int l = sides[1];
            if(sides[0] > l)
            {
                s = sides[1];
                l = sides[0];
            }
            for (int i = 1; i < s + l; i++)
            {
                if (i<=l &&i + s > l) answer++;
                else if (i > l && s + l > i) answer++;
            }
            return answer;
        }
        // 다른 사람 풀이
        // 나보다 간달하게 잘했음
        //int answer = 0;
        //int max = sides.Max();
        //int min = sides.Min();
        //for (int i = 1; i<max + min; i++)
        //{
        //    if (max<i + min) answer++;
        //}
        //return answer;

        //2. 신기한게 많군
        //return sides.Max()-(sides.Max()-sides.Min())+sides.Min()-1;
        
        //3. 신기한거 3
        //public int solution(int[] sides) => sides.Min() * 2 - 1;
    }
}
