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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        Form1 f = new Form1();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Abonamente;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int mov, movX, movY;
        public void fill()
        {
            conn.Open();
            string query3 = "SELECT * from dbo.Ziare ";
            SqlDataAdapter SDA3 = new SqlDataAdapter(query3, conn);
            DataTable dt3 = new DataTable();
            SDA3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonamenteDataSet8.Redactii". При необходимости она может быть перемещена или удалена.
            this.redactiiTableAdapter.Fill(this.abonamenteDataSet8.Redactii);

        }

        private void CloseMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Min_Paint(object sender, PaintEventArgs e)
        {
            f.Min_Paint(sender, e);
        }

        private void CloseMenu_Paint(object sender, PaintEventArgs e)
        {
            f.CloseMenu_Paint(sender, e);
        }

        private void Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ziareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            fill();
        }

        private void Mdbutton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query1 = "SELECT * from Ziare where Ziare.lg = 'MD'";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, conn);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void Rubutton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query2 = "SELECT * from Ziare where Ziare.lg = 'RU'";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, conn);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void bothbutton_Click(object sender, EventArgs e)
        {
            fill();
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

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void redacțiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            conn.Open();
            string query3 = "SELECT * from dbo.Redactii ";
            SqlDataAdapter SDA3 = new SqlDataAdapter(query3, conn);
            DataTable dt3 = new DataTable();
            SDA3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Detalii despre ziare";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }

            }

            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "output";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
