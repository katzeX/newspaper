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
    public partial class Form1 : Form
    {
        
        int mov, movX, movY;

        
       

        public void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        public void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        public void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        public void Min_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color myColor = Color.FromArgb(255, 255, 204);
            SolidBrush myBrush = new SolidBrush(myColor);
            Pen pen = new Pen(Color.FromArgb(255, 255, 204));
            z.DrawRectangle(pen, 7, 16, 12, 4);
            z.FillRectangle(myBrush, 7, 16, 12, 4);
        }

      

        public void CloseMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 255, 204));
            z.DrawLine(pen, 7, 7, 19, 19);
            z.DrawLine(pen, 7, 19, 19, 7);
            z.DrawLine(pen, 8, 7, 20, 19);
            z.DrawLine(pen, 8, 19, 20, 7);


        }

        public void CloseMenu_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

       

        public void Min_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Sanatate_Click(object sender, EventArgs e)
        {

        }

        private void Culinarie_MouseHover(object sender, EventArgs e)
        {
            Culinarie.BackColor = Color.FromArgb(26, 0, 0);
        }

        private void Culinarie_MouseLeave(object sender, EventArgs e)
        {
            Culinarie.BackColor = Color.FromArgb(13, 13, 13);
        }

        private void Cultura_MouseHover(object sender, EventArgs e)
        {
            Cultura.BackColor = Color.FromArgb(26, 0, 0);
        }

        private void Cultura_MouseLeave(object sender, EventArgs e)
        {
            Cultura.BackColor = Color.FromArgb(13, 13, 13);
        }

        private void Educatie_MouseHover(object sender, EventArgs e)
        {
            Educatie.BackColor = Color.FromArgb(26, 0, 0);
        }

        private void Educatie_MouseLeave(object sender, EventArgs e)
        {
            Educatie.BackColor = Color.FromArgb(13, 13, 13);
        }

        private void Social_MouseHover(object sender, EventArgs e)
        {
            Social.BackColor = Color.FromArgb(26, 0, 0);
        }

        private void Social_MouseLeave(object sender, EventArgs e)
        {
            Social.BackColor = Color.FromArgb(13, 13, 13);
        }

        private void Sanatate_MouseHover(object sender, EventArgs e)
        {
            Sanatate.BackColor = Color.FromArgb(26, 0, 0);
        }

        private void sleave(object sender, EventArgs e)
        {
            Sanatate.BackColor = Color.FromArgb(13, 13, 13);
        }

        private void General_MouseHover(object sender, EventArgs e)
        {
            General.BackColor = Color.FromArgb(26, 0, 0);
        }

        private void General_MouseLeave(object sender, EventArgs e)
        {
            General.BackColor = Color.FromArgb(13, 13, 13);
        }

        private void abonatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

  

        private void abonamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void determinăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        

        private void abonațiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            
        }

        private void abonamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void ziareȘiRedacțiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.FromArgb(255, 255, 204);
            
        }
    }
}
