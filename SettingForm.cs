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
    public partial class SettingForm : Form
    {
        public event UserSettingsEventHandler SettingChanged;


        public SettingForm()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            /// <summary>
            /// This is an empty method used so that the form does not automatically
            /// change its value without clicking applly.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = SystemColors.Control;
                radioButton1.ForeColor = SystemColors.ControlText;
                radioButton2.ForeColor = SystemColors.ControlText;
                label1.ForeColor = SystemColors.ControlText;
                BtnApply.BackColor = SystemColors.Control;

                UserSettings MainFormColor = new UserSettings() 
                { 
                    FormBackColor = SystemColors.Control,
                    ForeColor = SystemColors.ControlText,
                    BtnBackColor = SystemColors.Control,
                };
                SettingChanged(this, MainFormColor);
            }

            if (radioButton2.Checked)
            {
                this.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                BtnApply.BackColor = Color.Gray;

                UserSettings MainFormColor = new UserSettings()
                {
                    FormBackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
                    ForeColor = Color.White,
                    BtnBackColor = Color.Gray,
                };
                SettingChanged(this, MainFormColor);
            }
        }
    }
}
