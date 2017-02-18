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
        double memory;
        string kigou;
        bool opeFlg = false;
        bool mFlag = false;



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
                storeCalcNum();
                textBox.Text = "0.";
            }
            //memoryBtnの押下直後
            else if (opeFlg == true & mFlag == true)
            {
                storeCalcNum();
                textBox.Text = "0.";
                mFlag = false;
            }
            //数字入力後
            else
            {
                if ((0 >= textBox.Text.IndexOf(".")) & (textBox.Text.Length < 10))
                {
                        textBox.Text += ".";
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
                storeCalcNum();
                textBox.Text = x.ToString();
            }
            //memoryBtnの押下直後
            else if (opeFlg == true & mFlag == true)
            {
                storeCalcNum();
                textBox.Text = x.ToString();
                mFlag = false;
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
        /// 計算の対象となる前者の数字を保存
        /// </summary>
        private void storeCalcNum()
        {
            calcNum = Double.Parse(textBox.Text);
            opeFlg = true;
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
            //1回目
            if (opeFlg == true)
            {
                Num = Double.Parse(textBox.Text);
                kigou = kigouBox.Text;
                calculation();
                kigouBox.Text = string.Empty;
            }
            //連続で押下した際の処理
            else
            {
                calcNum = Double.Parse(textBox.Text);
                calculation();
            }

        }

        /// <summary>
        /// 記号ボタン(÷,×,-,+)押下後の共通処理
        /// </summary>
        private void execBtnKigou()
        {
            if (opeFlg == true)
            {
                Num = Double.Parse(textBox.Text);
                kigou = kigouBox.Text;
                calculation();  
            }

        }

        /// <summary>
        /// 計算
        /// </summary>
        private void calculation()
        {
            switch (kigou)
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
            mFlag = false;

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

        /// <summary>
        /// [MR]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMR_Click(object sender, EventArgs e)
        {
            if(memoryBox.Text == "M")
            {
                storeCalcNum();
                textBox.Text = memory.ToString();
                mFlag = true;
            }
        }

        /// <summary>
        /// [M+]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMadd_Click(object sender, EventArgs e)
        {
            memoryBox.Text = "M";
            memory += Double.Parse(textBox.Text);
            mFlag = true;
        }

        /// <summary>
        /// [M-]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMsub_Click(object sender, EventArgs e)
        {
            memoryBox.Text = "M";
            memory -= Double.Parse(textBox.Text);
            mFlag = true;
        }

        /// <summary>
        /// [MC]ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMC_Click(object sender, EventArgs e)
        {
            memoryBox.Text = string.Empty;
            memory = 0;
            mFlag = true;
        }
    }
}
