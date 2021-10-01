using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public class NavItemStyle : Button
    {
        public string itemDisplay;
        public NavItemStyle()
        {
            FlatStyle = FlatStyle.Popup;
            BackColor = Color.FromArgb(15, 4, 76);
            Size = new Size(300, 50);
            TextAlign = ContentAlignment.MiddleLeft;
            ForeColor = Color.FromArgb(255, 226, 226);
            Font = new Font("Arial", 20);
            Dock = DockStyle.Top;
        }
        public NavItemStyle(string display) : this()
        {
            Text = display;
            itemDisplay = display;
        }
    }
}
