using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ITMO.CsharpWindowsForms.ExamApp
{
    public partial class Connect : Form
    {
        private SqlConnection SqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public Connect()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_blockDataSet3.t1". При необходимости она может быть перемещена или удалена.
            this.t1TableAdapter1.Fill(this.test_blockDataSet3.t1);
            SqlConnection = new SqlConnection(@"Data Source=LAPTOP-G320BGVH\SQLEXPRESS;Initial Catalog=test_block;Integrated Security=True");

            SqlConnection.Open();

            adapter = new SqlDataAdapter("SELECT * FROM dbo.t1",SqlConnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string NewQuary = "INSERT INTO[dbo].[t1] (Name, Number, Price)" + " " + "VALUES ('" + textBox1.Text + "', " + textBox2.Text + ", " + textBox3.Text + ")";
                using (SqlConnection conn = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = test_block; Data Source = .\\SQLEXPRESS"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(NewQuary, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Возникло исключение");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
