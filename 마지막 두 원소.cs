using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class 마지막_두_원소
    {
        //문제 설명
        //정수 리스트 num_list가 주어질 때,
        //마지막 원소가 그전 원소보다 크면 마지막 원소에서 그전 원소를 뺀 값을
        //마지막 원소가 그전 원소보다 크지 않다면 마지막 원소를 두 배한 값을 추가하여
        //return하도록 solution 함수를 완성해주세요.

        //제한사항
        //2 ≤ num_list의 길이 ≤ 10
        //1 ≤ num_list의 원소 ≤ 9

        //입출력 예
        //num_list              result
        //[2, 1, 6]             [2, 1, 6, 5]
        //[5, 2, 1, 7, 5]       [5, 2, 1, 7, 5, 10]

        //입출력 예 설명
        //입출력 예 #1
        //마지막 원소인 6이 그전 원소인 1보다 크기 때문에 6 - 1인 5를 추가해 return합니다.

        //입출력 예 #2
        //마지막 원소인 5가 그전 원소인 7보다 크지 않기 때문에 5의 두 배인 10을 추가해 return합니다.
        public int[] solution24(int[] num_list)
        {
            int[] answer = new int[num_list.Length + 1];
            for (int i = 0; i < num_list.Length; i++)
            {
                answer[i] = num_list[i];
                if (i == num_list.Length - 1)
                {
                    if (num_list[i] > num_list[i - 1])
                    {
                        answer[i + 1] = num_list[i] - num_list[i - 1];
                        break;
                    }
                    else
                    {
                        answer[i + 1] = num_list[i] * 2;
                        break;
                    }
                }

            }
            return answer; ;
        }
        //다른 사람 풀이
        // Resize가 있구만
        //int l = num_list.Length - 1;
        //int a = num_list[l] > num_list[l - 1] ? num_list[l] - num_list[l - 1] : num_list[l] * 2;
        //Array.Resize(ref num_list, l+2);
        //num_list[l + 1] = a;
        //return num_list;

        //복사해서 마지막수만 넣어주기
        //int[] answer = new int[num_list.Length + 1];
        //Array.Copy(num_list, answer, num_list.Length);
        //int a = num_list[num_list.Length - 2];
        //int b = num_list[num_list.Length - 1];
        //answer[answer.Length - 1] = b > a? b - a : b* 2;
        //return answer;

        //리스트화가 있다 아직 안배워서 이건 안씀
        //List<int> a = new List<int>(num_list);
        //int b = 0;
        //if(num_list[num_list.Length - 2] < num_list[num_list.Length - 1])
        //{
        //    b = num_list[num_list.Length - 1] - num_list[num_list.Length - 2] ;
        //    a.Add(b);
        //}
        //else
        //{
        //    b = num_list[num_list.Length - 1]* 2;
        //    a.Add(b);
        //}
        //return a.ToArray();
    }
}
