//문제 설명
//일반적으로 두 선분이 이루는 각도는 한 바퀴를 360도로 하여 표현합니다.
// 따라서 각도에 360의 배수를 더하거나 빼더라도 같은 각을 의미합니다.
// 예를 들면, 30도와 390도는 같은 각도입니다.
//
//주어진 코드는 각도를 나타내는 두 정수 angle1과 angle2가 주어질 때, 
// 이 두 각의 합을 0도 이상 360도 미만으로 출력하는 코드입니다.
// 코드가 올바르게 작동하도록 한 줄을 수정해 주세요.
//
//제한사항
//0 ≤ angle1 ≤ 5000
//0 ≤ angle2 ≤ 5000
//입출력 예
//입력 #1
//280
//485

//출력 #1
//45

//입출력 예 설명
//입출력 예 #1
//angle1과 angle2의 합은 765도이고, 765를 720을 빼면 45도이므로 45를 출력합니다.

//디버깅(Debugging) 문제 안내
//디버깅(Debugging)은 이미 완성된 코드에서 버그를 찾아 수정하는 문제 타입입니다.
//1줄만 수정하여 버그를 고치세요.
//2줄 이상 수정할 경우, 실행 결과에 에러 메시지가 표시됩니다.
#include <iostream>

using namespace std;

int main002(void) {
    int angle1;
    int angle2;
    cin >> angle1 >> angle2;

    int sum_angle = angle1 + angle2;
    cout << sum_angle%360 << endl;
    return 0;
}