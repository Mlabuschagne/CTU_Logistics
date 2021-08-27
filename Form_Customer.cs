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

namespace CTU_Logistics
{
    public partial class Form_Customer : Form

    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zking001\source\repos\CTU_Logistics\CTU_Logistics\DBCtuLogistics.mdf;Integrated Security=True");

        public Form_Customer()
        {
            InitializeComponent();
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Customer_Table VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data have meen Inserted into Database");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Customer_Table WHERE id = '" + textBox1.Text + "'", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Data have been deleted");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = textBox2.Text = textBox2.Text = textBox3.Text = textBox3.Text = textBox4.Text = textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter datAdapter = new SqlDataAdapter("Select * From [dbo].[Customer_Table]", con);
            DataTable table = new DataTable();
            datAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Driver_Table Set  id= '" + textBox1.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Update data Sucsessfull");

            con.Close();
        }
    }
}
