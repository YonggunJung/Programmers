
// 문제 설명
//퓨쳐종합병원에서는 접수한 환자가 진료받을 병과에 따라 자동으로 환자 코드를 부여해 주는 프로그램이 있습니다.
//환자 코드의 마지막 네 글자를 보면 환자가 어디 병과에서 진료를 받아야 할지 알 수 있습니다.
//예를 들어 환자의 코드가 "_eye"로 끝난다면 안과를, 
//"head"로 끝난다면 신경외과 진료를 보게 됩니다.
//환자 코드의 마지막 글자에 따른 병과 분류 기준은 다음과 같습니다.
//
//마지막 글자	병과
//"_eye"	"Ophthalmologyc"
//"head"	"Neurosurgery"
//"infl"	"Orthopedics"
//"skin"	"Dermatology"
//환자의 코드를 나타내는 문자열 code를 입력받아 위 표에 맞는 병과를 출력하도록 
//빈칸을 채워 코드를 완성해 주세요.
//위 표의 단어로 끝나지 않는다면 "direct recommendation"를 출력합니다.
//
//제한사항
//4 ≤ code의 길이 ≤ 20
//code는 영어 소문자와 숫자, 언더바("_")로 이루어져 있습니다.
//
//입출력 예
//입력 #1
//dry_eye
//출력 #1
//Ophthalmologyc
//
//입력 #2
//pat23_08_20_head
//출력 #2
//Neurosurgery
//
//입출력 예 설명
//입출력 예 #1
//code가 "_eye"로 끝나기 때문에 "Ophthalmologyc"를 출력합니다.
//입출력 예 #2
//code가 "head"로 끝나기 때문에 "Neurosurgery"를 출력합니다.

//빈칸 채우기 문제 안내
//빈칸 채우기는 이미 완성된 코드 중 빈칸에 알맞은 코드를 입력하는 문제 타입입니다.
//빈칸을 제외한 기본 코드는 수정할 수 없습니다.
//빈칸을 채우지 않을 경우, 실행 결과에 에러 메시지가 표시됩니다.

#include <iostream>
using namespace std;

int main004(void) {
    string code;
    cin >> code;
    string last_four_words = code.substr(code.size() - 4, 4);
    if (last_four_words == "_eye") {
        cout << "Ophthalmologyc";
    }
    else if (last_four_words == "head") {
        cout << "Neurosurgery";
    }
    else if (last_four_words == "infl") {
        cout << "Orthopedics";
    }
    else if (last_four_words == "skin")
    {
        cout << "Dermatology";
    }
    else
    {
        cout << "direct recommendation";
    }
    return 0;
}