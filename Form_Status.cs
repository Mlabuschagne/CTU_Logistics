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
using System.IO;

namespace CTU_Logistics
{
    public partial class Form_Status : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zking001\source\repos\CTU_Logistics\CTU_Logistics\DBCtuLogistics.mdf;Integrated Security=True");

        public Form_Status()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void Form_Status_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Status_Table VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data have meen Inserted into Database");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Status_Table WHERE id = '" + textBox1.Text + "'", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Data have been deleted on the Database");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = textBox2.Text = textBox2.Text = textBox3.Text = textBox3.Text = textBox4.Text = textBox4.Text = textBox4.Text  ="";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\Users\\Zking001\\Documents\\Status.txt");
            txt.Write(textBox1.Text);
            txt.Write(":");
            txt.Write(textBox2.Text);
            txt.Write(":");
            txt.Write(textBox3.Text);
            txt.Write(":");
            txt.Write(textBox4.Text);
            txt.Write(":");
            txt.Write(textBox5.Text);
            txt.Close();

            MessageBox.Show("text file have been saved ");

            SqlDataAdapter datAdapter = new SqlDataAdapter("Select * From [dbo].[Status_Table]", con);
            DataTable table = new DataTable();
            datAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Driver_Table Set  id= '" + textBox1.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Update data Sucsessfull");

            con.Close();
        }
    }
}
