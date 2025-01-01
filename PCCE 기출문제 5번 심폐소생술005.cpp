
// ���� ����
//����һ����� ������ ���� ������ ���� �ǽ��մϴ�.
//
//������ �� ��ȣ�� Ȯ��[check]
//���� �� 119 �Ű� ��û[call]
//�����й� 30ȸ ����[pressure]
//�ΰ�ȣ�� 2ȸ ����[respiration]
//�����й�, �ΰ�ȣ�� �ݺ�[repeat]
//�־��� solution �Լ��� ����һ����� �ϴ� ����� ������ ��� ���ڿ����� 
//������ ������ ��� ����Ʈ cpr�� �־��� �� 
//������ ����� �� ��° �ܰ����� ������� ��� return�ϴ� �Լ��Դϴ�.
//solution �Լ��� �ùٸ��� �۵��ϵ��� ��ĭ�� ä�� solution �Լ��� �ϼ��� �ּ���.
//
//���ѻ���
//cpr�� ���� ���ڿ����� �� ���� ���ԵǾ� �ֽ��ϴ�.
//"check", "call", "pressure", "respiration", "repeat"
//
//����� ��
//cpr															result
//["call", "respiration", "repeat", "check", "pressure"]		[2, 4, 5, 1, 3]
//["respiration", "repeat", "check", "pressure", "call"]		[4, 5, 1, 3, 2]
//
//����� �� ����
//����� �� #1
//"call", "respiration", "repeat", "check", "pressure"�� 
//���� 2, 4, 5, 1, 3 ��° �����̹Ƿ�[2, 4, 5, 1, 3]�� �����մϴ�.
//
//����� �� #2
//"respiration", "repeat", "check", "pressure", "call"�� 
//���� 4, 5, 1, 3, 2 ��° �����̹Ƿ�[4, 5, 1, 3, 2]�� �����մϴ�.
//cpp�� �����ϴ� ��� ����Ʈ�� �迭�� ������ �ǹ��̴� Ǯ�̿� �������ּ���.
//	ex) ��ȣ�� ��� ���� ����Ʈ numbers�� �־����ϴ�. = > ��ȣ�� ��� ���� �迭 numbers�� �־����ϴ�.
//java�� �����ϴ� ��� ����Ʈ�� �迭, �Լ��� �޼ҵ�� ������ �ǹ��̴� Ǯ�̿� �������ּ���.
//	ex) solution �Լ��� �ùٸ��� �۵��ϵ��� �� ���� ������ �ּ���. = > solution �޼ҵ尡 �ùٸ��� �۵��ϵ��� �� ���� ������ �ּ���.
//
//	��ĭ ä��� ���� �ȳ�
//	��ĭ ä���� �̹� �ϼ��� �ڵ� �� ��ĭ�� �˸��� �ڵ带 �Է��ϴ� ���� Ÿ���Դϴ�.
//	��ĭ�� ������ �⺻ �ڵ�� ������ �� �����ϴ�.
//	��ĭ�� ä���� ���� ���, ���� ����� ���� �޽����� ǥ�õ˴ϴ�.

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