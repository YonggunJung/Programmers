using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 모의고사
    {
        //문제 설명
        //수포자는 수학을 포기한 사람의 준말입니다.
        //수포자 삼인방은 모의고사에 수학 문제를 전부 찍으려 합니다.
        //수포자는 1번 문제부터 마지막 문제까지 다음과 같이 찍습니다.

        //1번 수포자가 찍는 방식: 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, ...
        //2번 수포자가 찍는 방식: 2, 1, 2, 3, 2, 4, 2, 5, 2, 1, 2, 3, 2, 4, 2, 5, ...
        //3번 수포자가 찍는 방식: 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, ...

        //1번 문제부터 마지막 문제까지의 정답이 순서대로 들은 배열 answers가 주어졌을 때,
        //가장 많은 문제를 맞힌 사람이 누구인지 배열에 담아 return 하도록 solution 함수를 작성해주세요.

        //제한 조건
        //시험은 최대 10,000 문제로 구성되어있습니다.
        //문제의 정답은 1, 2, 3, 4, 5중 하나입니다.
        //가장 높은 점수를 받은 사람이 여럿일 경우, return하는 값을 오름차순 정렬해주세요.

        //입출력 예
        //answers               return
        //[1, 2, 3, 4, 5]       [1]
        //[1, 3, 2, 4, 2]       [1, 2, 3]

        //입출력 예 설명
        //입출력 예 #1
        //수포자 1은 모든 문제를 맞혔습니다.
        //수포자 2는 모든 문제를 틀렸습니다.
        //수포자 3은 모든 문제를 틀렸습니다.
        //따라서 가장 문제를 많이 맞힌 사람은 수포자 1입니다.

        //입출력 예 #2
        //모든 사람이 2문제씩을 맞췄습니다.


        public int[] solution48(int[] answers)
        {
            int[] answer = new int[] { };
            List<int> li = new List<int>();
            int max = 0;
            int[] sp1 = { 1, 2, 3, 4, 5 };          // 5개
            int[] sp2 = { 2, 1, 2, 3, 2, 4, 2, 5 }; // 8개
            int[] sp3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };   // 10개
            Dictionary<int, int> n = new Dictionary<int, int>();
            n.Add(1, 0);
            n.Add(2, 0);
            n.Add(3, 0);
            for (int i  = 0; i < answers.Length; i++)
            {
                if (answers[i] == sp1[i % 5]) n[1]++; 
                if (answers[i] == sp2[i % 8]) n[2]++; 
                if (answers[i] == sp3[i % 10]) n[3]++; 
            }
            for (int i = 1; i<=3; i++)
            {
                if (n[i] > max) max = n[i];
            }
            for (int i = 1; i <= 3; i++)
            {
                if (n[i] == max) li.Add(i);
            }
            li.Sort();
            answer = li.ToArray();
            return answer;
        }
        // 다른 사람 풀이
        // 이거 깔끔하고 좋네 이런 생각을 못했네
        public int[] solution48_1(int[] answers)
        {
            int[] nRules1 = new int[] { 1, 2, 3, 4, 5 };
            int[] nRules2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] nRules3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] nScores = new int[3];
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == nRules1[i % nRules1.Length]) ++nScores[0];
                if (answers[i] == nRules2[i % nRules2.Length]) ++nScores[1];
                if (answers[i] == nRules3[i % nRules3.Length]) ++nScores[2];
            }
            List<int> lstAnswer = new List<int>();
            if (nScores[0] == nScores.Max()) lstAnswer.Add(1);
            if (nScores[1] == nScores.Max()) lstAnswer.Add(2);
            if (nScores[2] == nScores.Max()) lstAnswer.Add(3);
            return lstAnswer.ToArray();
        }
    }
}
