using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> op = new List<string>(new String[] {" + "," - ", " × ", " ÷ "});
        private double result1, result2;    // 입력받은 상단의 수와 연산하거나 결과값이 될 하단의 수
        private bool after = false;         // 계산 후 상태를 나타내는 bool
        private int comma = 0;      // 3자리마다 , 표시 위한 값



        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btnNum = sender as Button;     // sender를 btnNum 변수에 입력한다.

            if (after)      // 계산 후 결과가 result2에 있으면 초기화
            {
                tboxResult2.Text = "0";
                result2 = 0;
                readyCal();     // 계산 전 상태로 바꿔줌
            }
            if (tboxResult2.Text != "0")        //  result2의 값이 0이 아니라면
            {
                //if (comma==3)
                //{
                //    tboxResult2.Text += ",";
                //    comma = 0;
                //}
                tboxResult2.Text += btnNum.Text;    // 그 수를 추가해준다.
            }
            else
            {
                tboxResult2.Text = btnNum.Text;     // 아니라면 0을 입력받은 값으로 대체한다.
            }
           // comma++;
            result2 = double.Parse(tboxResult2.Text);   // result2 값을 저장


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (tboxResult2.Text != "0")        // 0이외에 입력된 숫자가 있을 때 backspace가 의미있기 때문에
            {
                if(tboxResult2.Text != string.Empty)    // result2에 0이외의 값이 있다면 
                {
                    tboxResult2.Text = tboxResult2.Text.Substring(0, tboxResult2.Text.Length - 1);  // 제일 뒤의 숫자를 제거해준다.
                    if(tboxResult2.Text == string.Empty)    // 마지막 수를 제거해 비게 될 상황이 된다면
                    {
                        tboxResult2.Text = "0";    // 0을 표시해준다.
                    }
                }
            }
            //string temp = "";
            //result2 = Convert.ToDouble(tboxResult2.Text);   // ,를 제거하고
            //tboxResult2.Text = result2.ToString();
            //for (int i = 0; i < tboxResult2.Text.Length; i++)     // result2에 ,를 다시 찍어준다
            //{
            //    temp += tboxResult2.Text.Substring(i, 1);
            //    if (tboxResult2.Text.Length > 3 && i % 3 ==1)
            //    {
            //        temp += ",";
            //    }
            //    comma = i % 3 + 2;
            //}
            //if ((temp.Substring(temp.Length-1) == ","))
            //{
            //    temp = temp.Substring(0, temp.Length - 1);
            //}
            //tboxResult2.Text = temp;
        }


        private void btnC_Click(object sender, EventArgs e)
        {
            comma = 0;
            tboxResult1.Text = "";      // result1의 값을 초기화한다.
            tboxResult2.Text = "0";     // result2의 값을 0으로 초기화한다.
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Button btnOp = sender as Button;          

            if (tboxResult1.Text == "")     // tboxRsult1이 비어있고, 
            {
                if (tboxResult2.Text == "0")    // tboxResult2도 초기값인 0이라면
                {
                    result1 = 0;
                    result2 = 0;
                    tboxResult1.Text = "";
                    tboxResult2.Text = "0"; // 연산자를 눌러도 초기값을 유지하게 해준다
                }
                else          // tboxResult2에 값이 들어있다면, 
                {
                    result2 = Convert.ToDouble(tboxResult2.Text);   // tboxResult2의 값을 숫자로 변환해주고
                    result1 = result2;  // 그값을 result1에 넣어주고
                    tboxResult1.Text = tboxResult2.Text + btnOp.Text;   // tboxResult2에 연산자를 더한 값을 추가해준다.
                    afterCal();
                }
            }
            else            // tboxResult1에 값이 있고
            {
                if (tboxResult2.Text == "0")    // tboxReuslt2의 값이 0이라면
                {
                    if (op.Contains(tboxResult1.Text.Substring(tboxResult1.Text.Length-3)))   // 연산자가 존재할 경우에
                    {
                        tboxResult1.Text = tboxResult1.Text.Substring(0, tboxResult1.Text.Length - 3);
                        tboxResult1.Text += btnOp.Text;     // 새로 입력받은 연산자로 바꿔준다.
                    }
                    else        // 연산자가 존재하지 않는다면
                    {
                        tboxResult1.Text += btnOp.Text;     // 연산자를 추가해준다.
                    }
                }
                else  // 둘다 값이 존재한다면.
                {
                    if (!after)     // 계산 후 새로운 수를 받기 전까지는 동작시키지 않기 위해
                    {
                        if (op.Contains(tboxResult1.Text.Substring(tboxResult1.Text.Length-3)))     //
                        {
                            result1 = operation(tboxResult1.Text.Substring(tboxResult1.Text.Length - 3)); // 계산한 값을 result1에 저장
                            tboxResult1.Text = result1.ToString() + btnOp.Text;  //그값을 tboxResult1에 저장하고
                        }
                        else
                        {
                            tboxResult1.Text = tboxResult2.Text + btnOp.Text;
                        }
                    }


                }
            }
        }

        private double operation(string op)     // 연산자에 따라 계산해주는 함수
        {
            comma = 0;
            afterCal();
            switch (op)
            {
                case " + ":
                    result1 = result1 + result2;
                    break;
                case " - ":
                    result1 = result1 - result2;
                    break;
                case " × ":
                    result1 = result1 * result2;
                    break;
                case " ÷ ":
                    result1 = result1 / result2;
                    break;
                default:
                    break;
            }
            return result1;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            String btnEq;

            if (tboxResult1.Text != "")     // result1에 값이 있으면 실행
            {
                btnEq = tboxResult1.Text.Substring(tboxResult1.Text.Length - 3);
                result1 = operation(btnEq);
                tboxResult1.Text = result1.ToString();
                tboxResult2.Text = "0";
            }
        }

        private void afterCal()
        {
            after = true;
            comma = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!tboxResult2.Text.Contains("."))    // result2에 .이 없을때만 실행
            {
                tboxResult2.Text += ".";
                comma = -1;
            }
        }

        private void btnMinusPlus_Click(object sender, EventArgs e)
        {
            if (tboxResult2.Text.Contains("-"))     // -가 이미 있으면
            {
                tboxResult2.Text = tboxResult2.Text.Substring(1);   // 없애주고
            }
            else
            {
                tboxResult2.Text = "-" + tboxResult2.Text;      // 없으면 추가해준다.
            }
        }

        private void readyCal()
        {
            after = false;
        }
    } 
}
    
    



    
