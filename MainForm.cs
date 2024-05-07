using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_WindowsForm_CalApp
{
    public partial class MainForm : Form
    {
        private decimal FirstValue = 0.0m;
        private decimal SecondValue = 0.0m;
        private decimal ResultValue = 0.0m;
        private string Operators;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "0";
            }
            else
            {
                TxtBoxNumber.Text += "0";
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "1";
            }
            else
            {
                TxtBoxNumber.Text += "1";
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "2";
            }
            else
            {
                TxtBoxNumber.Text += "2";
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "3";
            }
            else
            {
                TxtBoxNumber.Text += "3";
            }
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "4";
            }
            else
            {
                TxtBoxNumber.Text += "4";
            }
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "5";
            }
            else
            {
                TxtBoxNumber.Text += "5";
            }
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "6";
            }
            else
            {
                TxtBoxNumber.Text += "6";
            }
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "7";
            }
            else
            {
                TxtBoxNumber.Text += "7";
            }
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "8";
            }
            else
            {
                TxtBoxNumber.Text += "8";
            }
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0")
            {
                TxtBoxNumber.Text = "9";
            }
            else
            {
                TxtBoxNumber.Text += "9";
            }
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (!TxtBoxNumber.Text.Contains("."))
            {
                TxtBoxNumber.Text += ".";
            }
        }

        private void BtnPosNeg_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text.Contains("-"))
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text.Trim('-');
            }
            else
            {
                TxtBoxNumber.Text = "-" + TxtBoxNumber.Text;
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            FirstValue = decimal.Parse(TxtBoxNumber.Text);
            TxtBoxNumber.Clear();
            Operators = "/";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            FirstValue = decimal.Parse(TxtBoxNumber.Text);
            TxtBoxNumber.Clear();
            Operators = "*";
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            FirstValue = decimal.Parse(TxtBoxNumber.Text);
            TxtBoxNumber.Clear();
            Operators = "-";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            FirstValue = decimal.Parse(TxtBoxNumber.Text);
            TxtBoxNumber.Clear();
            Operators = "+";
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            FirstValue = decimal.Parse(TxtBoxNumber.Text);
            TxtBoxNumber.Clear();
            Operators = "%";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBoxNumber.Clear();
            if (String.IsNullOrEmpty(TxtBoxNumber.Text))
            {
                TxtBoxNumber.Text = "0";
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch (Operators)
            {
                case "-":
                    SecondValue = decimal.Parse(TxtBoxNumber.Text);
                    ResultValue = FirstValue - SecondValue;
                    TxtBoxNumber.Text = ResultValue.ToString();
                    break;
                case "+":
                    SecondValue = decimal.Parse(TxtBoxNumber.Text);
                    ResultValue = FirstValue + SecondValue;
                    TxtBoxNumber.Text = ResultValue.ToString();
                    break;
                case "*":
                    SecondValue = decimal.Parse(TxtBoxNumber.Text);
                    ResultValue = FirstValue * SecondValue;
                    TxtBoxNumber.Text = ResultValue.ToString();
                    break;
                case "/":
                    SecondValue = decimal.Parse(TxtBoxNumber.Text);
                    ResultValue = FirstValue / SecondValue;
                    TxtBoxNumber.Text = ResultValue.ToString();
                    break;
                case "%":
                    SecondValue = decimal.Parse(TxtBoxNumber.Text);
                    ResultValue = FirstValue % SecondValue;
                    TxtBoxNumber.Text = ResultValue.ToString();
                    break;
            }
        }
    }
}
