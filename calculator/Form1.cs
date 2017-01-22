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
            //test
            InitializeComponent();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            textBox.Text += ((Button)sender).Text;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            textBox.Text += ((Button)sender).Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            textBox.Text += ((Button)sender).Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            textBox.Text += ((Button)sender).Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {

        }

        private void Btn5_Click(object sender, EventArgs e)
        {

        }

        private void Btn6_Click(object sender, EventArgs e)
        {

        }

        private void Btn7_Click(object sender, EventArgs e)
        {

        }

        private void Btn8_Click(object sender, EventArgs e)
        {

        }

        private void Btn9_Click(object sender, EventArgs e)
        {

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {

        }

        private void BtnMul_Click(object sender, EventArgs e)
        {

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            textBox.Text += ((Button)sender).Text;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int iAns;

            iAns = int.Parse(textBox.Text);
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox.Text = String.Empty;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
