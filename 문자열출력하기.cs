using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 문자열출력하기
    {
        //문제 설명
        //문자열 str이 주어질 때, str을 출력하는 코드를 작성해 보세요.

        //제한사항
        //1 ≤ str의 길이 ≤ 1,000,000
        //str에는 공백이 없으며, 첫째 줄에 한 줄로만 주어집니다.

        //입출력 예
        //입력 #1
        //HelloWorld!

        //출력 #1
        //HelloWorld!
        static void 문자열출력하기(string[] args)
        {
            //문자열 출력하기
            string str = Console.ReadLine();
            Console.WriteLine(str);



        }
        // 다른 사람 풀이1
        // 이건 쉐도우가 심한듯
        //String s = "HelloWorld!";
        //Console.Clear();
        //s = Console.ReadLine();
        //s = s.Replace(" ","");
        //if (1 > s.Length || s.Length > 1000000) return;
        //Console.Write(s);

        // 다른 사람 풀이2
        //String s = string.Format("HelloWorld!");;
        //Console.Clear();
        //s = Console.ReadLine();
        //    Console.WriteLine(s);

        // 생각보다 깔끔하게 짜는 사람들이 없어서 놀람
    }
}
