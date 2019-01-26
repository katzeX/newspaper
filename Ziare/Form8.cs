using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ziare
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        private void CloseMenu_Paint(object sender, PaintEventArgs e)
        {
            f1.CloseMenu_Paint(sender, e);
        }

        private void CloseMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
