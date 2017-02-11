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
        
        /// <summary>
        /// [0]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn0_Click(object sender, EventArgs e)
        {
            int x = 0;
            execBtnNum(x);
        }

        /// <summary>
        /// [1]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn1_Click(object sender, EventArgs e)
        {
            int x = 1;
            execBtnNum(x);
        }

        /// <summary>
        /// [2]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn2_Click(object sender, EventArgs e)
        {
            int x = 2;
            execBtnNum(x);
        }

        /// <summary>
        /// [3]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn3_Click(object sender, EventArgs e)
        {
            int x = 3;
            execBtnNum(x);
        }

        /// <summary>
        /// [4]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn4_Click(object sender, EventArgs e)
        {
            int x = 4;
            execBtnNum(x);
        }

        /// <summary>
        /// [5]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn5_Click(object sender, EventArgs e)
        {
            int x = 5;
            execBtnNum(x);
        }

        /// <summary>
        /// [6]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn6_Click(object sender, EventArgs e)
        {
            int x = 6;
            execBtnNum(x);
        }

        /// <summary>
        /// [7]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn7_Click(object sender, EventArgs e)
        {
            int x = 7;
            execBtnNum(x);
        }

        /// <summary>
        /// [8]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn8_Click(object sender, EventArgs e)
        {
            int x = 8;
            execBtnNum(x);
        }

        /// <summary>
        /// [9]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn9_Click(object sender, EventArgs e)
        {
            int x = 9;
            execBtnNum(x);
        }

        /// <summary>
        /// [.]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPoint_Click(object sender, EventArgs e)
        {
            //1回目or記号入力後
            if (opeFlg == false)
            {
                calcNum = Double.Parse(textBox.Text);
                textBox.Text = "0.";
                opeFlg = true;
            }

            //数字入力後
            else
            {
                if (0 >= textBox.Text.IndexOf("."))
                {
                    if (textBox.Text.Length < 10)
                    {
                        textBox.Text += ".";
                    }
                }
            }

        }

        /// <summary>
        /// 数字ボタン押下後の共通処理
        /// </summary>
        /// <param name="x"></param>
        private void execBtnNum(int x)
        {
            //1回目or記号入力後
            if (opeFlg == false)
            {
                calcNum = Double.Parse(textBox.Text);
                textBox.Text = x.ToString();
                opeFlg = true;
            }

            //数字入力後
            else
            {
                if (textBox.Text == "0")
                {
                    textBox.Text = x.ToString();
                }
                else if (textBox.Text.Length < 10) 
                {
                    textBox.Text += x.ToString();
                }   
            }  
                    
        }


        /// <summary>
        /// [÷]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = "÷";
        }

        /// <summary>
        /// [×]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMul_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = "×";
        }

        /// <summary>
        /// [-]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSub_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = "-";
        }

        /// <summary>
        /// [+]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = "+";
        }

        /// <summary>
        /// [=]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            execBtnKigou();
            kigouBox.Text = string.Empty;
        }

        /// <summary>
        /// 記号ボタン押下後の共通処理
        /// </summary>
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

        /// <summary>
        /// [C]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            opeFlg = false;
            textBox.Text = "0";
            kigouBox.Text = string.Empty;
        }
         
               
    }
}
