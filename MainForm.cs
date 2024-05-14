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
        public SettingForm SettingMenu {  get; set; }

        public decimal FirstValue;
        public decimal SecondValue;
        public decimal ResultValue;
        public string Symbol = string.Empty;


        public MainForm()
        {
            InitializeComponent();
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

        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "0";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "0";
                }
                else
                {
                    TxtBoxNumber.Text += "0";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "1";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "1";
                }
                else
                {
                    TxtBoxNumber.Text += "1";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            } 
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "2";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "2";
                }
                else
                {
                    TxtBoxNumber.Text += "2";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "3";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "3";
                }
                else
                {
                    TxtBoxNumber.Text += "3";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            }
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "4";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "4";
                }
                else
                {
                    TxtBoxNumber.Text += "4";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            }
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "5";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "5";
                }
                else
                {
                    TxtBoxNumber.Text += "5";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            }
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "6";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "6";
                }
                else
                {
                    TxtBoxNumber.Text += "6";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            }
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "7";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "7";
                }
                else
                {
                    TxtBoxNumber.Text += "7";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            }
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "8";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "8";
                }
                else
                {
                    TxtBoxNumber.Text += "8";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            }
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (ResultValue > 0 || ResultValue < 0)
            {
                TxtBoxNumber.Clear();
                ResultValue = 0;
                TxtBoxNumber.Text = "9";
            }
            else
            {
                if (TxtBoxNumber.Text == "0")
                {
                    TxtBoxNumber.Text = "9";
                }
                else
                {
                    TxtBoxNumber.Text += "9";
                }

                if (TxtBoxNumber.Text.Contains("Undefined"))
                {
                    TxtBoxNumber.Clear();
                }
            }
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (!TxtBoxNumber.Text.Contains("."))
            {
                TxtBoxNumber.Text += ".";
            }

            if (TxtBoxNumber.Text.Contains("Undefined"))
            {
                TxtBoxNumber.Clear();
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBoxNumber.Clear();
            LblEquation.Text = "";
            TxtBoxNumber.Text = "0";
            Symbol = string.Empty;
            FirstValue = 0;
            SecondValue = 0;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                FirstValue = decimal.Parse(TxtBoxNumber.Text);
                Symbol = "/";
                LblEquation.Text = $"{FirstValue} {Symbol}";
                TxtBoxNumber.Clear();
            }
            catch (Exception)
            {
                Symbol = "/";
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                FirstValue = decimal.Parse(TxtBoxNumber.Text);
                Symbol = "*";
                LblEquation.Text = $"{FirstValue} {Symbol}";
                TxtBoxNumber.Clear();
            }
            catch (Exception)
            {
                Symbol = "*";
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            try 
            {
                FirstValue = decimal.Parse(TxtBoxNumber.Text);
                Symbol = "-";
                LblEquation.Text = $"{FirstValue} {Symbol}";
                TxtBoxNumber.Clear();
            }
            catch (Exception)
            {
                Symbol = "-";
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            try 
            {
                FirstValue = decimal.Parse(TxtBoxNumber.Text);
                Symbol = "+";
                LblEquation.Text = $"{FirstValue} {Symbol}";
                TxtBoxNumber.Clear();
            } 
            catch (Exception)
            {
                Symbol = "+";
            }
            
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            try
            {
                FirstValue = decimal.Parse(TxtBoxNumber.Text);
                Symbol = "%";
                LblEquation.Text = $"{FirstValue} {Symbol}";
                TxtBoxNumber.Clear();
            }
            catch (Exception)
            {
                Symbol = "%";
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try 
            {
                switch (Symbol)
                {
                    case "-":

                        SecondValue = decimal.Parse(TxtBoxNumber.Text);
                        ResultValue = FirstValue - SecondValue;
                        LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue}";
                        TxtBoxNumber.Text = ResultValue.ToString();

                        if (SecondValue == 0)
                        {
                            LblEquation.Text = $"{FirstValue} - 0";
                        }

                        break;

                    case "+":

                        SecondValue = decimal.Parse(TxtBoxNumber.Text);
                        ResultValue = FirstValue + SecondValue;
                        LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue}";
                        TxtBoxNumber.Text = ResultValue.ToString();

                        if (SecondValue == 0)
                        {
                            LblEquation.Text = $"{FirstValue} + 0";
                        }

                        break;

                    case "*":

                        SecondValue = decimal.Parse(TxtBoxNumber.Text);
                        ResultValue = FirstValue * SecondValue;
                        LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue}";
                        TxtBoxNumber.Text = ResultValue.ToString();

                        if (SecondValue == 0)
                        {
                            LblEquation.Text = $"{FirstValue} * 0";
                        }

                        break;

                    case "/":

                        if (SecondValue == 0)
                        {
                            ResultValue = 0;
                            LblEquation.Text = $"{FirstValue} / 0";
                            TxtBoxNumber.Text = "Undefined";
                        }
                        else
                        {
                            SecondValue = decimal.Parse(TxtBoxNumber.Text);
                            ResultValue = FirstValue / SecondValue;
                            LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue}";
                            TxtBoxNumber.Text = ResultValue.ToString();
                        }
                        
                        break;

                    case "%":

                        SecondValue = decimal.Parse(TxtBoxNumber.Text);
                        ResultValue = FirstValue % SecondValue;
                        LblEquation.Text = $"{FirstValue} {Symbol} {SecondValue}";
                        TxtBoxNumber.Text = ResultValue.ToString();

                        if (SecondValue == 0)
                        {
                            LblEquation.Text = $"{FirstValue} % 0";
                        }

                        break;

                    case "":

                        FirstValue = decimal.Parse(TxtBoxNumber.Text);
                        LblEquation.Text = $"{FirstValue} = ";
                        TxtBoxNumber.Text = FirstValue.ToString();
                        break;
                }
            } 
            catch (Exception) 
            {
                LblEquation.Text = $"{FirstValue} = ";
                ResultValue = FirstValue;
                TxtBoxNumber.Text = ResultValue.ToString();
                FirstValue = 0;
            }
        }
    }
}
