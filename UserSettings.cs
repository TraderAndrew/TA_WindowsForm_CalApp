using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_WindowsForm_CalApp
{
    public delegate void UserSettingsEventHandler(object sender, UserSettings e);

    public class UserSettings:EventArgs
    {
        public Color FormBackColor { get; set; }
        public Color ForeColor { get; set; }
        public Color BtnBackColor { get; set; }
    }
}
