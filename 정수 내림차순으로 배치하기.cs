using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 정수_내림차순으로_배치하기
    {
        //문제 설명
        //함수 solution은 정수 n을 매개변수로 입력받습니다.
        //n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴해주세요.
        //예를들어 n이 118372면 873211을 리턴하면 됩니다.

        //제한 조건
        //n은 1이상 8000000000 이하인 자연수입니다.

        //입출력 예
        //n             return
        //118372	    873211
        public long solution9(long n)
        {
            //별거 아닌건데 헷갈리네 ㅠㅠ
            long answer = 0;
            string str = new string(n.ToString().OrderByDescending(c => c).ToArray());
            answer = long.Parse(str);
            return answer;
        }
    }
}
