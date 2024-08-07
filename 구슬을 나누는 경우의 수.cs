﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmers
{
    public partial class 구슬을_나누는_경우의_수 : Form
    {
        public 구슬을_나누는_경우의_수()
        {
            InitializeComponent();
            //문제 설명
            //머쓱이는 구슬을 친구들에게 나누어주려고 합니다.
            //구슬은 모두 다르게 생겼습니다.
            //머쓱이가 갖고 있는 구슬의 개수 balls와 친구들에게
            //나누어 줄 구슬 개수 share이 매개변수로 주어질 때,
            //balls개의 구슬 중 share개의 구슬을 고르는 가능한 모든 경우의 수를
            //return 하는 solution 함수를 완성해주세요.

            //제한사항
            //1 ≤ balls ≤ 30
            //1 ≤ share ≤ 30
            //구슬을 고르는 순서는 고려하지 않습니다.
            //share ≤ balls

            //입출력 예
            //balls     share       result
            //3             2            3
            //5             3           10

            //입출력 예 설명
            //입출력 예 #1
            //서로 다른 구슬 3개 중 2개를 고르는 경우의 수는 3입니다.

            //입출력 예 #2
            //서로 다른 구슬 5개 중 3개를 고르는 경우의 수는 10입니다.

            //Hint
            //서로 다른 n개 중 m개를 뽑는 경우의 수 공식은 다음과 같습니다.
            //답 봄
            long solution187(int balls, int share)            {
                if (share == 0)
                {
                    return 1;
                }
                long answer = solution187(balls - 1, share - 1);
                answer *= balls;
                answer /= share;
                return answer;
            }

            // 이게 왜 안되는지 모르겠는데 안됨 ㅠㅠ
            //double solution187(int balls, int share)
            //{
            //    double answer = 0;
            //    if (balls == share)
            //        answer = 1;
            //    else 
            //        answer = factorial(balls) / (factorial(balls - share) * factorial(share));
            //    return answer;
            //}
        }
        // 팩토리얼 함수가 틀린 걸까??
        //안됨 ㅠㅠ
        public double factorial(int n)
        {
            double num = 1;
            for (int i = 2; i <= n; i++)
            {
                num *= i;
            }
            return num;
        }

        static void Main187(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 구슬을_나누는_경우의_수());
        }

        private void 구슬을_나누는_경우의_수_Load(object sender, EventArgs e)
        {
            // 이미지 파일 경로 설정
            string imagePath = @"C:\Users\User-PC\source\repos\Programmers\Image\구슬을 나누는 경우의 수.png";
            string imagePath2 = @"C:\Users\User-PC\source\repos\Programmers\Image\구슬을 나누는 경우의 수 힌트.png";

            // 이미지 로드
            Image image = Image.FromFile(imagePath);
            Image image2 = Image.FromFile(imagePath2);

            // PictureBox에 이미지 설정
            pictureBox1.Image = image;
            pictureBox2.Image = image2;
        }
    }
}
