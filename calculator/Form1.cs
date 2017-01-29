using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        double calcNum;
        double Num;
        double result;
        bool opeFlg = false;



        private void CalcForm_Load(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "0";
                }
                else
                {
                    textBox.Text += "0";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "0";
                }
                else
                {
                    textBox.Text += "0";
                }
            }

            opeFlg = true;

        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "1";
                }
                else
                {
                    textBox.Text += "1";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "1";
                }
                else
                {
                    textBox.Text += "1";
                }
            }

            opeFlg = true;

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "2";
                }
                else
                {
                    textBox.Text += "2";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "2";
                }
                else
                {
                    textBox.Text += "2";
                }
            }

            opeFlg = true;

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "3";
                }
                else
                {
                    textBox.Text += "3";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "3";
                }
                else
                {
                    textBox.Text += "3";
                }
            }

            opeFlg = true;

        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "4";
                }
                else
                {
                    textBox.Text += "4";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "4";
                }
                else
                {
                    textBox.Text += "4";
                }
            }

            opeFlg = true;

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "5";
                }
                else
                {
                    textBox.Text += "5";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "5";
                }
                else
                {
                    textBox.Text += "5";
                }
            }

            opeFlg = true;

        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "6";
                }
                else
                {
                    textBox.Text += "6";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "6";
                }
                else
                {
                    textBox.Text += "6";
                }
            }

            opeFlg = true;

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "7";
                }
                else
                {
                    textBox.Text += "7";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "7";
                }
                else
                {
                    textBox.Text += "7";
                }
            }

            opeFlg = true;

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "8";
                }
                else
                {
                    textBox.Text += "8";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "8";
                }
                else
                {
                    textBox.Text += "8";
                }
            }

            opeFlg = true;

        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "9";
                }
                else
                {
                    textBox.Text += "9";
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = "9";
                }
                else
                {
                    textBox.Text += "9";
                }
            }

            opeFlg = true;

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            switch (kigouBox.Text)
            {
                case "÷":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum / Num;
                    textBox.Text = result.ToString();
                    break;
                case "×":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum * Num;
                    textBox.Text = result.ToString();
                    break;
                case "-":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum - Num;
                    textBox.Text = result.ToString();
                    break;
                case "+":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum + Num;
                    textBox.Text = result.ToString();
                    break;
                default:
                    break;
            }
            opeFlg = false;
            kigouBox.Text = "÷";

        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            switch (kigouBox.Text)
            {
                case "÷":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum / Num;
                    textBox.Text = result.ToString();
                    break;
                case "×":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum * Num;
                    textBox.Text = result.ToString();
                    break;
                case "-":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum - Num;
                    textBox.Text = result.ToString();
                    break;
                case "+":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum + Num;
                    textBox.Text = result.ToString();
                    break;
                default:
                    break;
            }
            opeFlg = false;
            kigouBox.Text = "×";

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            switch (kigouBox.Text)
            {
                case "÷":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum / Num;
                    textBox.Text = result.ToString();
                    break;
                case "×":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum * Num;
                    textBox.Text = result.ToString();
                    break;
                case "-":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum - Num;
                    textBox.Text = result.ToString();
                    break;
                case "+":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum + Num;
                    textBox.Text = result.ToString();
                    break;
                default:
                    break;
            }
            opeFlg = false;
            kigouBox.Text = "-";

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            switch (kigouBox.Text)
            {
                case "÷":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum / Num;
                    textBox.Text = result.ToString();
                    break;
                case "×":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum * Num;
                    textBox.Text = result.ToString();
                    break;
                case "-":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum - Num;
                    textBox.Text = result.ToString();
                    break;
                case "+":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum + Num;
                    textBox.Text = result.ToString();
                    break;
                default:
                    break;
            }
            opeFlg = false;
            kigouBox.Text = "+";

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            switch (kigouBox.Text)
            {
                case "÷":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum / Num;
                    textBox.Text = result.ToString();
                    break;
                case "×":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum * Num;
                    textBox.Text = result.ToString();
                    break;
                case "-":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum - Num;
                    textBox.Text = result.ToString();
                    break;
                case "+":
                    Num = Double.Parse(textBox.Text);
                    result = calcNum + Num;
                    textBox.Text = result.ToString();
                    break;
                default:
                    break;
            }

            opeFlg = false;
            kigouBox.Text = string.Empty;

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            opeFlg = false;
            textBox.Text = "0";
            kigouBox.Text = string.Empty;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kigouBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
