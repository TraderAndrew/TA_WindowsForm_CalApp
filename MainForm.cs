﻿using System;
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
        public SettingForm SettingMenu {  get; set; }

        private decimal FirstValue = 0;
        private decimal SecondValue = 0;
        private decimal ResultValue = 0;
        private string Symbol;

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
            Symbol = "/";
            LblEquation.Text = $"{FirstValue} {Symbol}";
            TxtBoxNumber.Clear();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            FirstValue = decimal.Parse(TxtBoxNumber.Text);
            Symbol = "*";
            LblEquation.Text = $"{FirstValue} {Symbol}";
            TxtBoxNumber.Clear();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            FirstValue = decimal.Parse(TxtBoxNumber.Text);
            Symbol = "-";
            LblEquation.Text = $"{FirstValue} {Symbol}";
            TxtBoxNumber.Clear();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            FirstValue = decimal.Parse(TxtBoxNumber.Text);
            Symbol = "+";
            LblEquation.Text = $"{FirstValue} {Symbol}";
            TxtBoxNumber.Clear();
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            FirstValue = decimal.Parse(TxtBoxNumber.Text);
            Symbol = "%";
            LblEquation.Text = $"{FirstValue} {Symbol}";
            TxtBoxNumber.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBoxNumber.Clear();
            LblEquation.Text = "";
            FirstValue = 0;
            SecondValue = 0;
            if (String.IsNullOrEmpty(TxtBoxNumber.Text))
            {
                TxtBoxNumber.Text = "0";
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            //this try catch method is only temporary.
            //It was only to stop the app form crashing.
            //Something better will be implemented later
            try 
            {
                switch (Symbol)
                {
                    case "-":
                        SecondValue = decimal.Parse(TxtBoxNumber.Text);
                        LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue} = ";
                        ResultValue = FirstValue - SecondValue;
                        TxtBoxNumber.Text = ResultValue.ToString();
                        break;
                    case "+":
                        SecondValue = decimal.Parse(TxtBoxNumber.Text);
                        LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue} = ";
                        ResultValue = FirstValue + SecondValue;
                        TxtBoxNumber.Text = ResultValue.ToString();
                        break;
                    case "*":
                        SecondValue = decimal.Parse(TxtBoxNumber.Text);
                        LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue} = ";
                        ResultValue = FirstValue * SecondValue;
                        TxtBoxNumber.Text = ResultValue.ToString();
                        break;
                    case "/":
                        SecondValue = decimal.Parse(TxtBoxNumber.Text);
                        LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue} = ";
                        ResultValue = FirstValue / SecondValue;
                        TxtBoxNumber.Text = ResultValue.ToString();
                        break;
                    case "%":
                        SecondValue = decimal.Parse(TxtBoxNumber.Text);
                        LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue} = ";
                        ResultValue = FirstValue % SecondValue;
                        TxtBoxNumber.Text = ResultValue.ToString();
                        break;
                }
            } 
            catch (Exception) 
            {
                MessageBox.Show("You did not enter a second value", "Calculator App");
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingMenu = new SettingForm();
            SettingMenu.SettingChanged += SettingMenu_AddNew;
            SettingMenu.Show();
        }

        private void SettingMenu_AddNew(object sender, UserSettings e)
        {
            this.BackColor = e.FormBackColor;

            BtnSettings.BackColor = e.BtnBackColor;

            LblEquation.ForeColor = e.ForeColor;
            TxtBoxNumber.BackColor = e.FormBackColor;
            TxtBoxNumber.ForeColor = e.ForeColor;

            BtnPercent.BackColor = e.BtnBackColor;
            BtnClear.BackColor = e.BtnBackColor;
            BtnDivide.BackColor = e.BtnBackColor;
            BtnMultiply.BackColor = e.BtnBackColor;
            BtnSub.BackColor = e.BtnBackColor;
            BtnPlus.BackColor = e.BtnBackColor;
            BtnDot.BackColor = e.BtnBackColor;
            BtnPosNeg.BackColor = e.BtnBackColor;
            BtnZero.BackColor = e.BtnBackColor;
            BtnOne.BackColor = e.BtnBackColor;
            BtnTwo.BackColor = e.BtnBackColor;
            BtnThree.BackColor = e.BtnBackColor;
            BtnFour.BackColor = e.BtnBackColor;
            BtnFive.BackColor = e.BtnBackColor;
            BtnSix.BackColor = e.BtnBackColor;
            BtnSeven.BackColor = e.BtnBackColor;
            BtnEight.BackColor = e.BtnBackColor;
            BtnNine.BackColor = e.BtnBackColor;
        }
    }
}
