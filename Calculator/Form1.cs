using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double number1 = 0, number2 = 0;
        bool firstNumberEntered = false;
        char operation;
        public Form1()
        {
            InitializeComponent();
        }
        void addNumberToTextBox(string number)
        {
            if (txtResult.Text.Length > 6)
            {
                MessageBox.Show("You cannot add more numbers");
            }
            if (firstNumberEntered == true)
            {
                txtResult.Text = number;
                firstNumberEntered = false;
            }
            else
            {
                txtResult.Text += number;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn2.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            doOperation();
        }
        void doOperation()
        {
            switch (operation)
            {
                case '+':
                    number2 = Convert.ToDouble(txtResult.Text);
                    txtResult.Text = (number1 + number2).ToString();
                    break;
                case '-':
                    number2 = Convert.ToDouble(txtResult.Text);
                    txtResult.Text = (number1 - number2).ToString();
                    break ;
                case '*':
                    number2 = Convert.ToDouble(txtResult.Text);
                    txtResult.Text = (number1 * number2).ToString();
                    break;
                case '/':
                    number2 = Convert.ToDouble(txtResult.Text);
                    txtResult.Text = (number1 / number2).ToString();
                    break;
            }
                 
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn1.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn6.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addNumberToTextBox(btn9.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          int num = Convert.ToInt32(txtResult.Text);
            double fact = 1;
            for (int i = num; i >= 1; i--)
            {
                fact = fact * i;
            }
            txtResult.Text=fact.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = '+';
            number1 = Convert.ToDouble(txtResult.Text);
            firstNumberEntered = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = '-';
            number1 = Convert.ToDouble(txtResult.Text);
            firstNumberEntered = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operation = '*';
            number1 = Convert.ToDouble(txtResult.Text);
            firstNumberEntered = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = '/';
            number1 = Convert.ToDouble(txtResult.Text);
            firstNumberEntered = true;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtResult.Text = "0.";
            }
            else if(txtResult.Text.IndexOf(".") == -1)
            {
                //txtResult.Text += ".";
                addNumberToTextBox(btnDot.Text);
            }
            
        }
    }
}
