using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class 덧셈식_출력하기
    {
        static void Main6(string[] args)
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine("{0} + {1} = {2}", a, b, a+b);
        }

        //다른 사람 풀이
        //신기한 방법 많음, 결국 다 출력 방법임
        //Console.WriteLine(""+a+" + "+b+" = {0}", a + b);
        //Console.WriteLine($"{a} + {b} = {a+b}");
        //Console.WriteLine(a + " + " + b + " = " + (a + b));
    }
}
