using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 이진수_더하기
    {
        //문제 설명
        //이진수를 의미하는 두 개의 문자열 bin1과 bin2가 매개변수로 주어질 때,
        //두 이진수의 합을 return하도록 solution 함수를 완성해주세요.

        //제한사항
        //return 값은 이진수를 의미하는 문자열입니다.
        //1 ≤ bin1, bin2의 길이 ≤ 10
        //bin1과 bin2는 0과 1로만 이루어져 있습니다.
        //bin1과 bin2는 "0"을 제외하고 0으로 시작하지 않습니다.

        //입출력 예
        //bin1          bin2        result
        //"10"	        "11"	    "101"
        //"1001"	    "1111"	    "11000"

        //입출력 예 설명
        //입출력 예 #1
        //10 + 11 = 101 이므로 "101" 을 return합니다.

        //입출력 예 #2
        //1001 + 1111 = 11000 이므로 "11000"을 return합니다.
        public string solution156(string bin1, string bin2)
        {
            string answer = "";
            string longer = bin1;
            string shorter = bin2;
            int carry = 0;
            if (bin1.Length < bin2.Length)
            {
                longer = bin2;
                shorter = bin1;
            }
            while(shorter.Length < longer.Length)
            {
                shorter = "0" + shorter;
            }
            for (int i = shorter.Length-1; i >=0; i--)
            {

                if (((int)longer[i]-'0') + ((int)shorter[i]-'0') + carry == 3)
                {
                    answer = 1 + answer;
                    carry = 1;
                }
                else if(((int)longer[i] - '0') + ((int)shorter[i] - '0') + carry == 2)
                {
                    answer = 0 + answer;
                    carry = 1;
                }
                else
                {
                    answer = (((int)longer[i] - '0') + ((int)shorter[i] - '0') + carry) + answer;
                    carry = 0;
                }
                
            }
            if (carry == 1) answer = 1 + answer;
            return answer;
        }
        //다른 사람 풀이
        // 파이썬이랑 똑같이 되는 거였군 ㅠㅠ
        // 그걸 몰라서 엄청 돌아 왔네
        // string answer = Convert.ToString(Convert.ToInt32(bin1, 2) + Convert.ToInt32(bin2, 2), 2);
    }
}
