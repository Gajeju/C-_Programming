using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//2015108223 김동현 컴퓨터프로그래밍 과제

namespace bubble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;               //읽어들인 문자열을 str 변수에 배정
            string[] a = str.Split(',');              //str의 문자열을 , 로 나누어 a 배열에 각각 배정합니다.
            int[] b;                                  //a배열의 문자열을 정수로 바꾸어 넣어줄 배열 선언
            b = new int[a.Length];                    //a배열의 길이만큼 b배열의 객체 생성

            for (int i = 0; i < b.Length; i++)        /*i를 0부터 b배열의 길이보다 작은 범위까지 1씩 증가시키며 
                                                         a배열의 i번째 인덱스의 값을 b배열의 배정합니다.*/
            {
                b[i] = int.Parse(a[i]);
            }
                
            for (int i = 1; i < b.Length; i++)        //i를 1부터 b배열의 길이보다 작은 범위까지 1씩 증가시킵니다.
            {
                for (int j = 0; j < i; j++)           //i가 1씩 증가할때마다 j를 0부터 i보다 작은 범위까지 1씩 증가시킵니다.
                {
                    if (b[j] > b[i])                  /*i번째 인덱스의 값이 j번째 인덱스의 값보다 클 경우
                                                        m에 b[i]를 배정하고 b[i]에는 b[j] 를 배정 b[j]에는
                                                        다시 m을 배정하는 방식으로 서로의 순서를 바꿔줍니다.*/

                    {
                        int m = b[i];
                        b[i] = b[j];
                        b[j] = m;
                    }
                }
            }
            foreach (int i in b)                     //연산이 끝난 b 배열을 출력합니다.
            {
                textBox2.Text += i + " ";
            }
        }
    }
}
