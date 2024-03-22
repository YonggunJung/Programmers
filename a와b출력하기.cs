using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class a와b출력하기
    {
        static void a와b출력하기(string[] args)
        {
            //문제 설명
            //정수 a와 b가 주어집니다.
            //각 수를 입력받아 입출력 예와 같은 형식으로 출력하는 코드를 작성해 보세요.

            //제한사항
            //-100,000 ≤ a, b ≤ 100,000

            //입출력 예
            //입력 #1
            //4 5

            //출력 #1
            //a = 4
            //b = 5

            string[] s;

            s = Console.ReadLine().Split(' ');  // 배열 input은 이렇게 하면 됨 하나 배워감
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);


            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            // 혼자 쉐도우를 너무 많이함 그래도 얻어 가는건 있음

        }
        // 다른 사람 풀이 1
        //int[] are = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //int a = are[0];
        //int b = are[1];
        //Console.WriteLine($"a = {a}\nb = {b}");

        //다른 사람 풀이 2
        // 거의 비슷함 
    }
}
