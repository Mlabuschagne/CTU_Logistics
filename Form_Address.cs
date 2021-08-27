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
    public partial class Form_Address : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zking001\source\repos\CTU_Logistics\CTU_Logistics\DBCtuLogistics.mdf;Integrated Security=True");

        public Form_Address()
        {
            InitializeComponent();
        }

        private void Form_Address_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Address_Table VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data have meen Inserted into Database");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Driver_Table WHERE id = '" + textBox1.Text + "'", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Have been Deleted");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter datAdapter = new SqlDataAdapter("Select * From [dbo].[Address_Table]", con);
            DataTable table = new DataTable();
            datAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = textBox2.Text = textBox2.Text = textBox3.Text = textBox3.Text = "";
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
