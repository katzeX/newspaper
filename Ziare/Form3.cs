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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Abonamente;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int mov, movX, movY;
        Form1 f1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void CloseMenu_MouseClick(object sender, MouseEventArgs e)
        {
           
            Close();
            
        }

       
        private void Min_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        

        private void Min_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color myColor = Color.FromArgb(255, 255, 204);
            SolidBrush myBrush = new SolidBrush(myColor);
            Pen pen = new Pen(Color.FromArgb(255, 255, 204));
            z.DrawRectangle(pen, 7, 16, 12, 4);
            z.FillRectangle(myBrush, 7, 16, 12, 4);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonamenteDataSet3.Ziare". При необходимости она может быть перемещена или удалена.
            this.ziareTableAdapter.Fill(this.abonamenteDataSet3.Ziare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonamenteDataSet2.Abonatii". При необходимости она может быть перемещена или удалена.
            this.abonatiiTableAdapter.Fill(this.abonamenteDataSet2.Abonatii);

        }

        private void Salveaza_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "INSERT INTO dbo.Realizari(idReal, idAbonat, idZiar, initial, finis, pret_final) values('" + textBox1.Text + "','" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + dateTimePicker1.Value.Date.ToString() + "','" + dateTimePicker2.Value.Date.ToString() + "', '" + textBox2.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void afișeazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string query = "SELECT * from dbo.Realizari";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Exclude_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "DELETE FROM dbo.Realizari where idReal = '" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
