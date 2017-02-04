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
            int x = 0;
            execBtnNum(x);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            int x = 1;
            execBtnNum(x);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            int x = 2;
            execBtnNum(x);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            int x = 3;
            execBtnNum(x);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            int x = 4;
            execBtnNum(x);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            int x = 5;
            execBtnNum(x);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            int x = 6;
            execBtnNum(x);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            int x = 7;
            execBtnNum(x);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            int x = 8;
            execBtnNum(x);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            int x = 9;
            execBtnNum(x);
        }

        //数字ボタン押下後の共通処理
        private void execBtnNum(int x)
        {
            //1回目
            if (kigouBox.Text == "")
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = x.ToString();
                }
                else
                {
                    textBox.Text += x.ToString();
                }
            }
            //2回目以降
            else
            {
                if (opeFlg == false)
                {
                    calcNum = Double.Parse(textBox.Text);
                    textBox.Text = x.ToString();
                }
                else
                {
                    textBox.Text += x.ToString();
                }
            }

            opeFlg = true;
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = "÷";

        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = "×";
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = "-";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = "+";
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = string.Empty;
        }

        //記号ボタン押下後の共通処理
        private void execBtnKigou()
        {
            Num = Double.Parse(textBox.Text);

            switch (kigouBox.Text)
            {
                case "÷":
                    result = calcNum / Num;
                    textBox.Text = result.ToString();
                    break;
                case "×":
                    result = calcNum * Num;
                    textBox.Text = result.ToString();
                    break;
                case "-":
                    result = calcNum - Num;
                    textBox.Text = result.ToString();
                    break;
                case "+":
                    result = calcNum + Num;
                    textBox.Text = result.ToString();
                    break;
                default:
                    break;
            }

            opeFlg = false;

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
