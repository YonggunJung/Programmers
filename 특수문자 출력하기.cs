using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 특수문자_출력하기
    {
        static void Main(string[] args)
        {
            // 이건 알아서 해주는구나 예시를 복붙하니 알아서 해줌
            //그리고 쫄지 말고 하니까 나옴
            //다음과 같이 출력하도록 코드를 작성해 주세요.

            //출력 예시
            //!@#$%^&*(\'"<>?:;
            string s = "!@#$%^&*(\\'\"<>?:;";
            Console.WriteLine(s);
        }

        //다른 사람 풀이1
        // 이건 내가 모르는 거긴한데 대충 이해는 감
        // 하지만 특수만자 코드를 다 알아야해서 ...
        //List<int> asciis = new List<int> { 33, 64, 35, 36, 37, 94, 38, 42, 40, 92, 39, 34, 60, 62, 63, 58, 59 };
        //foreach (int c in asciis)
        //{
        //    Console.Write((char) (c));
        // ===========================================

        //다른사람 풀이 2
        // 신기한거 많네 이거도 위와 같은 방법 같은데 뭐가 다른지는 모름
        //Console.WriteLine("\u0021\u0040\u0023\u0024\u0025\u005E\u0026\u002A\u0028\u005C\u0027\u0022\u003C\u003E\u003F\u003A\u003B");
       
    }

}
