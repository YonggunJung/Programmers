using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Programmers
{
    public partial class 겹치는_선분의_길이 : Form
    {
        public 겹치는_선분의_길이()
        {
            InitializeComponent();
            //문제 설명
            //선분 3개가 평행하게 놓여 있습니다.
            //세 선분의 시작과 끝 좌표가[[start, end], [start, end], [start, end]] 형태로
            //들어있는 2차원 배열 lines가 매개변수로 주어질 때,
            //두 개 이상의 선분이 겹치는 부분의 길이를 return 하도록 solution 함수를 완성해보세요.

            //lines가[[0, 2], [-3, -1], [-2, 1]]일 때 그림으로 나타내면 다음과 같습니다.
            //line_2.png
            //선분이 두 개 이상 겹친 곳은[-2, -1], [0, 1]로 길이 2만큼 겹쳐있습니다.

            //제한사항
            //lines의 길이 = 3
            //lines의 원소의 길이 = 2
            //모든 선분은 길이가 1 이상입니다.
            //lines의 원소는[a, b] 형태이며, a, b는 각각 선분의 양 끝점 입니다.
            //-100 ≤ a < b ≤ 100

            //입출력 예
            //lines                             result
            //[[0, 1], [2, 5], [3, 9]]              2
            //[[-1, 1], [1, 3], [3, 9]]             0
            //[[0, 5], [3, 9], [1, 10]]             8

            //입출력 예 설명
            //입출력 예 #1
            //두 번째, 세 번째 선분[2, 5], [3, 9]가[3, 5] 구간에 겹쳐있으므로 2를 return 합니다.

            //입출력 예 #2
            //겹친 선분이 없으므로 0을 return 합니다.

            //입출력 예 #3
            //첫 번째와 두 번째 선분이[3, 5] 구간에서 겹칩니다.
            //첫 번째와 세 번째 선분[1, 5] 구간에서 겹칩니다.
            //두 번째와 세 번째 선분[3, 9] 구간에서 겹칩니다.
            //따라서[1, 9] 구간에 두 개 이상의 선분이 겹쳐있으므로, 8을 return 합니다.
            int solution162(int[,] lines)
            {
                // 답을 봤지만 혼자는 못풀었을 문제긴 함
                // 너무 어렵군
                int answer = 0;
                int[] count = new int[0];
                int min = int.MaxValue;
                int max = int.MinValue;
                foreach (var item in lines)
                {
                    if (item < min) min = item;
                    if (item > max) max = item;
                }
                count = new int[max - min];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = lines[i, 0]; j < lines[i, 1]; j++)
                    {
                        count[j - min] += 1;
                    }
                }
                foreach (var item in count)
                {
                    if (item > 1) answer++;
                }
                return answer;
            }
        }

        static void Main162(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 겹치는_선분의_길이());
        }

        private void 겹치는_선분의_길이_Load(object sender, EventArgs e)
        {
            // 이미지 파일 경로 설정
            string imagePath = @"C:\Users\qutyz\source\repos\Programmers\Image\겹치는 선분의 길이.png";

            // 이미지 로드
            Image image = Image.FromFile(imagePath);

            // PictureBox에 이미지 설정
            pictureBox1.Image = image;
        }
    }
}
