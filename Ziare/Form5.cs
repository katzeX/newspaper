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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Form1 f = new Form1();
        int mov, movX, movY;
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Abonamente;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonamenteDataSet7.Ziare". При необходимости она может быть перемещена или удалена.
            this.ziareTableAdapter.Fill(this.abonamenteDataSet7.Ziare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonamenteDataSet6.Abonatii". При необходимости она может быть перемещена или удалена.
            this.abonatiiTableAdapter.Fill(this.abonamenteDataSet6.Abonatii);

        }

        private void fișierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "INSERT INTO dbo.Realizari(idReal, idAbonat, idZiar, initial, finis, pret_final) values('" + textBox1.Text + "','" + abBox.SelectedValue + "','" + ziarBox.SelectedValue + "','" + dateTimePicker1.Value.Date.ToString() + "','" + dateTimePicker2.Value.Date.ToString() + "', '" + priceBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            Form7 f7 = new Form7();
            f7.Show();

        }

        private void Afisare_Click(object sender, EventArgs e)
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            abBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ziarBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            priceBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
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

        private void CloseMenu_Paint(object sender, PaintEventArgs e)
        {
            f.CloseMenu_Paint(sender, e);
        }

       

        private void Min_Paint(object sender, PaintEventArgs e)
        {
            f.Min_Paint(sender, e);
        }
    }
}
