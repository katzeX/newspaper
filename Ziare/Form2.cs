using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ziare
{

    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Abonamente;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
       
        int mov, movX, movY;


        public Form2()
        {
            InitializeComponent();
        }
        
        private void CloseMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 255, 204));
            z.DrawLine(pen, 7, 7, 19, 19);
            z.DrawLine(pen, 7, 19, 19, 7);
            z.DrawLine(pen, 8, 7, 20, 19);
            z.DrawLine(pen, 8, 19, 20, 7);
            
        }

        private void MinMax_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color myColor = Color.FromArgb(255, 255, 204);
            SolidBrush myBrush = new SolidBrush(myColor);
            Pen pen = new Pen(Color.FromArgb(255, 255, 204));
            z.DrawRectangle(pen, 7, 7, 12, 12);
            z.FillRectangle(myBrush, 7, 7, 12, 12);
            z.DrawRectangle(pen, 9, 7, 7, 10);
            z.DrawRectangle(pen, 12, 12, 10, 10);
            
        }

        private void Min_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color myColor = Color.FromArgb(255, 255, 204);
            SolidBrush myBrush = new SolidBrush(myColor);
            Pen pen = new Pen(Color.FromArgb(255, 255, 204));
            z.DrawRectangle(pen, 7, 16, 12, 4);
            z.FillRectangle(myBrush, 7, 16, 12, 4);
        }

        private void CloseMenu_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonamenteDataSet1.Raion". При необходимости она может быть перемещена или удалена.
            this.raionTableAdapter.Fill(this.abonamenteDataSet1.Raion);

        }

        private void fișierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "INSERT INTO dbo.Abonatii(idAbonat, Nume, Prenume, idRaion, Adresa) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedValue + "','" + textBox4.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            Form7 f7 = new Form7();
            f7.Show();
            conn.Close();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "DELETE FROM dbo.Abonatii where idAbonat = '" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void actualizeazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE dbo.Abonatii SET IDAbonat = '" + textBox1.Text + "' Nume = '" + textBox2.Text + "', Prenume = '" + textBox3.Text + "',idRaion = '" + comboBox1.Text + "',Adresa = '" + textBox4.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);

            conn.Close();
           
        }

        private void dateToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {

        }

        private void afișeazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * from dbo.Abonatii order by Nume asc";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Min_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      
    }
}
