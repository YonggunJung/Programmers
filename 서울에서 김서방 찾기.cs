using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersLv1
{
    internal class 서울에서_김서방_찾기
    {
        //문제 설명
        //String형 배열 seoul의 element중 "Kim"의 위치 x를 찾아,
        //"김서방은 x에 있다"는 String을 반환하는 함수,
        //solution을 완성하세요.
        //seoul에 "Kim"은 오직 한 번만 나타나며 잘못된 값이 입력되는 경우는 없습니다.

        //제한 사항
        //seoul은 길이 1 이상, 1000 이하인 배열입니다.
        //seoul의 원소는 길이 1 이상, 20 이하인 문자열입니다.
        //"Kim"은 반드시 seoul 안에 포함되어 있습니다.

        //입출력 예
        //seoul                     return
        //["Jane", "Kim"]           "김서방은 1에 있다"
        public string solution13(string[] seoul)
        {
            string answer = "";
            int idx = Array.IndexOf(seoul, "Kim");
            answer = $"김서방은 {idx}에 있다";
            return answer;
        }

        //다른 사람 풀이
        // 아 이 형식이 이렇게 되야하는구나
        //answer = Array.FindIndex(seoul, i => i == "Kim");
        //return string.Format("김서방은 {0}에 있다", answer);

    }
}
