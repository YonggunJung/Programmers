
// ���� ����
//ǻ�����պ��������� ������ ȯ�ڰ� ������� ������ ���� �ڵ����� ȯ�� �ڵ带 �ο��� �ִ� ���α׷��� �ֽ��ϴ�.
//ȯ�� �ڵ��� ������ �� ���ڸ� ���� ȯ�ڰ� ��� �������� ���Ḧ �޾ƾ� ���� �� �� �ֽ��ϴ�.
//���� ��� ȯ���� �ڵ尡 "_eye"�� �����ٸ� �Ȱ���, 
//"head"�� �����ٸ� �Ű�ܰ� ���Ḧ ���� �˴ϴ�.
//ȯ�� �ڵ��� ������ ���ڿ� ���� ���� �з� ������ ������ �����ϴ�.
//
//������ ����	����
//"_eye"	"Ophthalmologyc"
//"head"	"Neurosurgery"
//"infl"	"Orthopedics"
//"skin"	"Dermatology"
//ȯ���� �ڵ带 ��Ÿ���� ���ڿ� code�� �Է¹޾� �� ǥ�� �´� ������ ����ϵ��� 
//��ĭ�� ä�� �ڵ带 �ϼ��� �ּ���.
//�� ǥ�� �ܾ�� ������ �ʴ´ٸ� "direct recommendation"�� ����մϴ�.
//
//���ѻ���
//4 �� code�� ���� �� 20
//code�� ���� �ҹ��ڿ� ����, �����("_")�� �̷���� �ֽ��ϴ�.
//
//����� ��
//�Է� #1
//dry_eye
//��� #1
//Ophthalmologyc
//
//�Է� #2
//pat23_08_20_head
//��� #2
//Neurosurgery
//
//����� �� ����
//����� �� #1
//code�� "_eye"�� ������ ������ "Ophthalmologyc"�� ����մϴ�.
//����� �� #2
//code�� "head"�� ������ ������ "Neurosurgery"�� ����մϴ�.

//��ĭ ä��� ���� �ȳ�
//��ĭ ä���� �̹� �ϼ��� �ڵ� �� ��ĭ�� �˸��� �ڵ带 �Է��ϴ� ���� Ÿ���Դϴ�.
//��ĭ�� ������ �⺻ �ڵ�� ������ �� �����ϴ�.
//��ĭ�� ä���� ���� ���, ���� ����� ���� �޽����� ǥ�õ˴ϴ�.

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