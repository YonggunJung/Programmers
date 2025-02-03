using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgrammersLv1
{
    internal class 달리기_경주
    {
        //문제 설명
        //얀에서는 매년 달리기 경주가 열립니다.
        //해설진들은 선수들이 자기 바로 앞의 선수를 추월할 때
        //추월한 선수의 이름을 부릅니다.
        //예를 들어 1등부터 3등까지 "mumu", "soe", "poe" 선수들이 순서대로 달리고 있을 때,
        //해설진이 "soe"선수를 불렀다면 2등인 "soe" 선수가
        //1등인 "mumu" 선수를 추월했다는 것입니다.
        //즉 "soe" 선수가 1등, "mumu" 선수가 2등으로 바뀝니다.

        //선수들의 이름이 1등부터 현재 등수 순서대로
        //담긴 문자열 배열 players와
        //해설진이 부른 이름을 담은 문자열 배열 callings가 매개변수로 주어질 때,
        //경주가 끝났을 때 선수들의 이름을 1등부터 등수 순서대로 배열에 담아
        //return 하는 solution 함수를 완성해주세요.

        //제한사항
        //5 ≤ players의 길이 ≤ 50,000
        //players[i] 는 i번째 선수의 이름을 의미합니다.
        //players의 원소들은 알파벳 소문자로만 이루어져 있습니다.
        //players에는 중복된 값이 들어가 있지 않습니다.
        //3 ≤ players[i] 의 길이 ≤ 10
        //2 ≤ callings의 길이 ≤ 1,000,000
        //callings는 players의 원소들로만 이루어져 있습니다.
        //경주 진행중 1등인 선수의 이름은 불리지 않습니다.

        //입출력 예
        //players                                   callings                            result
        //["mumu", "soe", "poe", "kai", "mine"]     ["kai", "kai", "mine", "mine"]      ["mumu", "kai", "mine", "soe", "poe"]

        //입출력 예 설명
        //입출력 예 #1
        //4등인 "kai" 선수가 2번 추월하여 2등이 되고
        //앞서 3등, 2등인 "poe", "soe" 선수는 4등, 3등이 됩니다.
        //5등인 "mine" 선수가 2번 추월하여 4등, 3등인 "poe", "soe" 선수가 5등, 4등이 되고 경주가 끝납니다.
        //1등부터 배열에 담으면["mumu", "kai", "mine", "soe", "poe"] 이 됩니다.

        public string[] solution64(string[] players, string[] callings)
        {
            string[] answer = new string[] { };
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < players.Length; i++)
            {
                dic.Add(players[i], i);
            }
            foreach (var call in callings)
            {
                int rank = dic[call];
                string name = players[rank-1];

                players[rank-1] = call;
                players[rank] = name;

                dic[call]--;
                dic[name]++;
            }
            answer = players;
            return answer;
        }

        // 시간 복잡도에 걸림 ㅠ
        //string temp = "";
        //    foreach (var name in callings)
        //    {
        //        int i = Array.IndexOf(players, name);
        //temp = players[i - 1];
        //        players[i - 1] = players[i];
        //        players[i] = temp; 
        //    }
        //answer = players;

        //다른사람 풀이
        // 정렬이 문제가 아니라
        // indexof가 문제였던 거군
        //public string[] solution(string[] players, string[] callings)
        //{
        //    string[] answer = new string[] { };
        //    Dictionary<string, int> dict = new Dictionary<string, int>();
        //    for (int i = 0; i < players.Length; i++)
        //    {
        //        dict[players[i]] = i;
        //    }
        //    foreach (string c in callings)
        //    {
        //        int index = dict[c];
        //        dict[c]--;
        //        dict[players[index - 1]]++;
        //        string temp = players[index];
        //        players[index] = players[index - 1];
        //        players[index - 1] = temp;
        //    }
        //    return players;
    }
}
