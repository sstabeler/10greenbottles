using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10greenbottles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteSong_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 10; i >= 1; i--)
            {
                lstBoxoutput.Items.Add(i + "Green Bottles standing on the wall,  " + i + "Green Bottles Standing on the wall  And if one green bottle should accidentally fall,  There'll be " + Convert.ToString((int)i - 1) + "green bottles standing on the wall");
            }
        }
    }
}
