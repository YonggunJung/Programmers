using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 자연수_뒤집어_배열로_만들기
    {
        //문제 설명
        //자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴해주세요.
        //예를들어 n이 12345이면[5, 4, 3, 2, 1] 을 리턴합니다.

        //제한 조건
        //n은 10,000,000,000이하인 자연수입니다.

        //입출력 예
        //n	                return
        //12345	            [5, 4, 3, 2, 1]
        public long[] solution8(long n)
        {
            long[] answer = new long[] { };
            List<long> li = new List<long>();
            while (n > 0)
            {
                long i = n % 10;
                n /= 10;
                li.Add(i);
            }
            answer = li.ToArray();
            return answer;
        }
        //데이터 타입을 맞춰줘야 한다.
    }
}
