
// 문제 설명
//심폐소생술은 다음과 같은 순서를 통해 실시합니다.
//
//심정지 및 무호흡 확인[check]
//도움 및 119 신고 요청[call]
//가슴압박 30회 시행[pressure]
//인공호흡 2회 시행[respiration]
//가슴압박, 인공호흡 반복[repeat]
//주어진 solution 함수는 심폐소생술을 하는 방법의 순서가 담긴 문자열들이 
//무작위 순서로 담긴 리스트 cpr이 주어질 때 
//각각의 방법이 몇 번째 단계인지 순서대로 담아 return하는 함수입니다.
//solution 함수가 올바르게 작동하도록 빈칸을 채워 solution 함수를 완성해 주세요.
//
//제한사항
//cpr은 다음 문자열들이 한 번씩 포함되어 있습니다.
//"check", "call", "pressure", "respiration", "repeat"
//
//입출력 예
//cpr															result
//["call", "respiration", "repeat", "check", "pressure"]		[2, 4, 5, 1, 3]
//["respiration", "repeat", "check", "pressure", "call"]		[4, 5, 1, 3, 2]
//
//입출력 예 설명
//입출력 예 #1
//"call", "respiration", "repeat", "check", "pressure"은 
//각각 2, 4, 5, 1, 3 번째 순서이므로[2, 4, 5, 1, 3]을 리턴합니다.
//
//입출력 예 #2
//"respiration", "repeat", "check", "pressure", "call"은 
//각각 4, 5, 1, 3, 2 번째 순서이므로[4, 5, 1, 3, 2]를 리턴합니다.
//cpp를 응시하는 경우 리스트는 배열과 동일한 의미이니 풀이에 참고해주세요.
//	ex) 번호가 담긴 정수 리스트 numbers가 주어집니다. = > 번호가 담긴 정수 배열 numbers가 주어집니다.
//java를 응시하는 경우 리스트는 배열, 함수는 메소드와 동일한 의미이니 풀이에 참고해주세요.
//	ex) solution 함수가 올바르게 작동하도록 한 줄을 수정해 주세요. = > solution 메소드가 올바르게 작동하도록 한 줄을 수정해 주세요.
//
//	빈칸 채우기 문제 안내
//	빈칸 채우기는 이미 완성된 코드 중 빈칸에 알맞은 코드를 입력하는 문제 타입입니다.
//	빈칸을 제외한 기본 코드는 수정할 수 없습니다.
//	빈칸을 채우지 않을 경우, 실행 결과에 에러 메시지가 표시됩니다.

#include <iostream>
#include <vector>

using namespace std;

vector<int> solution005(vector<string> cpr) {
    vector<int> answer = { 0, 0, 0, 0, 0 };
    vector<string> basic_order = { "check", "call", "pressure", "respiration", "repeat" };

    for (int i = 0; i < cpr.size(); i++) {
        for (int j = 0; j < basic_order.size(); j++) {
            if (cpr[i] == basic_order[j]) {
                answer[i] = j + 1;
                break;
            }
        }
    }

    return answer;
}