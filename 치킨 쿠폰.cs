using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 치킨_쿠폰
    {
        //문제 설명
        //프로그래머스 치킨은 치킨을 시켜먹으면 한 마리당 쿠폰을 한 장 발급합니다.
        //쿠폰을 열 장 모으면 치킨을 한 마리 서비스로 받을 수 있고,
        //서비스 치킨에도 쿠폰이 발급됩니다.
        //시켜먹은 치킨의 수 chicken이 매개변수로 주어질 때 받을 수 있는 최대 서비스 치킨의 수를
        //return하도록 solution 함수를 완성해주세요.

        //제한사항
        //chicken은 정수입니다.
        //0 ≤ chicken ≤ 1,000,000

        //입출력 예
        //chicken           result
        //100	            11
        //1,081	            120

        //입출력 예 설명
        //입출력 예 #1
        //100마리를 주문하면 쿠폰이 100장 발급되므로 서비스 치킨 10마리를 주문할 수 있습니다.
        //10마리를 주문하면 쿠폰이 10장 발급되므로 서비스 치킨 1마리를 주문할 수 있습니다.
        //따라서 10 + 1 = 11 을 return합니다.

        //입출력 예 #2
        //1081마리를 주문하면 쿠폰이 1081장 발급되므로 서비스 치킨 108마리를 주문할 수 있습니다.
        //그리고 쿠폰이 1장 남습니다.
        //108마리를 주문하면 쿠폰이 108장 발급되므로 서비스 치킨 10마리를 주문할 수 있습니다.
        //그리고 쿠폰이 8장 남습니다.
        //10마리를 주문하면 쿠폰이 10장 발급되므로 서비스 치킨 1마리를 주문할 수 있습니다.
        //1마리를 주문하면 쿠폰이 1장 발급됩니다.
        //가지고 있는 쿠폰이 총 10장이므로 서비스 치킨 1마리를 추가로 주문할 수 있습니다.
        //따라서 108 + 10 + 1 + 1 = 120 을 return합니다.
        public int solution157(int chicken)
        {
            int answer = 0;
            int c = 0;
            while (chicken > 0)
            {
                answer += (chicken / 10);
                c += chicken % 10;
                if (c >= 10)
                {
                    c = c/10 + c%10;
                    answer++;
                }
                chicken /= 10;
            }
            return answer;
            // 반례
            //1999   =>    222
            //199    9
            //19     9
            //1      9
        }
        // 다른 사람 풀이
        // 이렇게 보니 정말 간단하네 효율은 모르겠지만
        //int coupon = chicken;
        //int serviceChicken = 0;
        //while(coupon >= 10)
        //{
        //    coupon -= 10;
        //    serviceChicken++;
        //    coupon++;
        //}
        //return serviceChicken;

        // 이걸보면 내가 쉐도우를 했네
        //while (chicken >= 10)
        //{
        //    answer += chicken / 10;
        //    chicken = chicken / 10 + chicken % 10;
        //}
    }
}
