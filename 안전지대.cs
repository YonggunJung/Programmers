using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Programmers
{
    public partial class 안전지대 : Form
    {
        public 안전지대()
        {
            InitializeComponent();
            //다음 그림과 같이 지뢰가 있는 지역과 지뢰에 인접한
            //위, 아래, 좌, 우 대각선 칸을 모두 위험지역으로 분류합니다.
            //image.png
            //지뢰는 2차원 배열 board에 1로 표시되어 있고
            //board에는 지뢰가 매설 된 지역 1과,
            //지뢰가 없는 지역 0만 존재합니다.
            //지뢰가 매설된 지역의 지도 board가 매개변수로 주어질 때,
            //안전한 지역의 칸 수를 return하도록 solution 함수를 완성해주세요.

            //제한사항
            //board는 n* n 배열입니다.
            //1 ≤ n ≤ 100
            //지뢰는 1로 표시되어 있습니다.
            //board에는 지뢰가 있는 지역 1과 지뢰가 없는 지역 0만 존재합니다.

            //입출력 예
            //board                                                                                                                         result
            //[[0, 0, 0, 0, 0], [0, 0, 0, 0, 0], [0, 0, 0, 0, 0], [0, 0, 1, 0, 0], [0, 0, 0, 0, 0]]                                         16
            //[[0, 0, 0, 0, 0], [0, 0, 0, 0, 0], [0, 0, 0, 0, 0], [0, 0, 1, 1, 0], [0, 0, 0, 0, 0]]                                         13
            //[[1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1]]      0

            //입출력 예 설명
            //입출력 예 #1
            //(3, 2)에 지뢰가 있으므로 지뢰가 있는 지역과
            //지뢰와 인접한 위, 아래, 좌, 우, 대각선 총 8칸은 위험지역입니다.
            //따라서 16을 return합니다.

            //입출력 예 #2
            //(3, 2), (3, 3)에 지뢰가 있으므로 지뢰가 있는 지역과
            //지뢰와 인접한 위, 아래, 좌, 우, 대각선은 위험지역입니다.
            //따라서 위험지역을 제외한 칸 수 13을 return합니다.

            //입출력 예 #3
            //모든 지역에 지뢰가 있으므로 안전지역은 없습니다. 따라서 0을 return합니다.
            int solution167(int[,] board)
            {
                // 이건 너무 어렵다 이렇게 공부하고 넘어가자
                int answer = 0;
                // 방향 벡터 정의 (위, 아래, 좌, 우, 대각선)
                int[] dx = { -1, 1, 0, 0, -1, -1, 1, 1 };
                int[] dy = { 0, 0, -1, 1, -1, 1, -1, 1 };

                // 모든 칸을 순회하면서 안전 지역인지 확인
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == 0)
                        { // 현재 위치가 지뢰가 없는 지역일 때
                            bool isSafe = true;
                            // 주변 8방향을 검사
                            for (int k = 0; k < 8; k++)
                            {
                                int ni = i + dx[k];
                                int nj = j + dy[k];
                                if (ni >= 0 && ni < board.GetLength(0) && nj >= 0 && nj < board.GetLength(1))
                                {
                                    if (board[ni, nj] == 1)
                                    { // 주변에 지뢰가 있는 경우
                                        isSafe = false;
                                        break;
                                    }
                                }
                            }
                            if (isSafe)  answer++;
                        }
                    }
                }
                return answer;
            }
        }

        static void Main167(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new 안전지대());
        }
        private void 안전지대_Load(object sender, EventArgs e)
        {
            // 이미지 파일 경로 설정
            string imagePath = @"C:\Users\qutyz\source\repos\Programmers\Image\안전지대.png";

            // 이미지 로드
            System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);

            // PictureBox에 이미지 설정
            pictureBox1.Image = image;
        }
    }
}
