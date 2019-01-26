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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }
        Form1 f1 = new Form1();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Abonamente;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int  mov,movX, movY;
        private void CloseMenu_Paint(object sender, PaintEventArgs e)
        {
            f1.CloseMenu_Paint( sender, e);
        }


        private void Min_Paint(object sender, PaintEventArgs e)
        {
            f1.Min_Paint(sender, e);
        }

        private void CloseMenu_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

       

        private void Min_MouseClick(object sender, MouseEventArgs e)
        {
            f1.Min_MouseClick(sender, e);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            f1.menuStrip1_MouseUp(sender, e);
            
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            f1.menuStrip1_MouseMove(sender, e);
        }
        public void fill_abonati() {

            conn.Open();
            string query = "SELECT * from dbo.Abonatii ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        public void Salveaza_Click(object sender, EventArgs e)

        {
            dataGridView1.Visible = true;
            fill_abonati();
            viewAb.Visible = true;
            monthBox.Visible = false;
            lookForMonth.Visible = false;
            priceButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            comboBox1.Visible = false;
            

        }

        private void Exclude_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;
            comboBox1.Visible = true;          
            button1.Visible = true;
            textBox2.Visible = true;
            lookForMonth.Visible = false;
            priceButton.Visible = false;
            monthBox.Visible = false;
            viewAb.Visible = false;




            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonamenteDataSet5.Redactii". При необходимости она может быть перемещена или удалена.
            this.redactiiTableAdapter.Fill(this.abonamenteDataSet5.Redactii);
            comboBox1.Visible = false;
            button1.Visible = false;
            textBox2.Visible = false;
            fill_abonati();

        }

        private void abonațiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fill_abonati();
        }

        private void afișeazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            comboBox1.Visible = true;
            button1.Visible = false;
            priceButton.Visible = true;
            lookForMonth.Visible = false;
            dataGridView1.Visible = false;
            monthBox.Visible = false;
            viewAb.Visible = false;

            
            string query1 = "select ROUND( SUM(Ziare.pret),2) from Ziare where Ziare.idRed='" + comboBox1.SelectedValue + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataReader reader1 = null;
            reader1 = cmd1.ExecuteReader();
            reader1.Read();



            textBox2.Text = reader1[0].ToString();
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Redactia data nu are ziare");
            }
            conn.Close();
            reader1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select count( Ziare.idZiar) from Ziare where Ziare.idRed = '" + comboBox1.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            reader.Read();


            textBox2.Text = reader[0].ToString();

            conn.Close(); reader.Close();

        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            textBox2.Visible = true;
            string query1 = "select ROUND( SUM(Ziare.pret),2) from Ziare where Ziare.idRed='" + comboBox1.SelectedValue + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataReader reader1 = null;
            reader1 = cmd1.ExecuteReader();
            reader1.Read();
            textBox2.Text = reader1[0].ToString();
            conn.Close();
        }

        private void abonamenteConformLuniiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthBox.Visible = true;
            lookForMonth.Visible = true;
            dataGridView1.Visible = true;
            textBox2.Visible = false;
            priceButton.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
        }

        private void lookForMonth_Click(object sender, EventArgs e)
        {
            int aux_1 = int.Parse(monthBox.Items[monthBox.SelectedIndex].ToString());
            string query = "select Abonatii.idAbonat, Abonatii.Nume, Abonatii.Prenume,Ziare.DenZiar, Realizari.initial , Realizari.finis ,Realizari.pret_final from Abonatii inner join Realizari on (Abonatii.idAbonat = Realizari.idAbonat) and  '" + aux_1 + "' between MONTH(initial ) and MONTH(finis) inner join Ziare on Realizari.idZiar = Ziare.idZiar";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridView1.RowCount == 0) MessageBox.Show("Pentru luna indicată nu sunt abonamente");
        }

        private void viewAb_Click(object sender, EventArgs e)
        {
            conn.Open();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "select Ziare.DenZiar from ((Abonatii inner join Realizari on Abonatii.idAbonat = Realizari.idAbonat and Abonatii.idAbonat = '" + textBox1.Text + "') inner join Ziare on Realizari.idZiar = Ziare.idZiar )";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, conn);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            if (dataGridView1.RowCount == 0) MessageBox.Show("Acest utilizator inca nu  este abonat la nici un ziar!");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }
    }
}
