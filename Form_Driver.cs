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
    public partial class Form_Driver : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zking001\source\repos\CTU_Logistics\CTU_Logistics\DBCtuLogistics.mdf;Integrated Security=True");

        public Form_Driver()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Driver_Table VALUES('"+ textBox1.Text + "','"+ textBox2.Text + "','"+ textBox3.Text +"')",con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data1 have been Inserted in the DataBase ");
            con.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form_Driver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCtuLogisticsDataSet2.Driver_Table' table. You can move, or remove it, as needed.
            this.driver_TableTableAdapter2.Fill(this.dBCtuLogisticsDataSet2.Driver_Table);
            // TODO: This line of code loads data into the 'dBCtuLogisticsDataSet1.Driver_Table' table. You can move, or remove it, as needed.
            this.driver_TableTableAdapter1.Fill(this.dBCtuLogisticsDataSet1.Driver_Table);
            // TODO: This line of code loads data into the 'dBCtuLogisticsDataSet.Driver_Table' table. You can move, or remove it, as needed.
            this.driver_TableTableAdapter.Fill(this.dBCtuLogisticsDataSet.Driver_Table);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Driver_Table Set  id= '"+textBox1.Text + "'",con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Update data Sucsessfull");

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Driver_Table WHERE id = '" + textBox1.Text + "'",con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Data have been deleted");
            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = textBox2.Text = textBox2.Text = textBox3.Text = textBox3.Text= "";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter datAdapter = new SqlDataAdapter("Select * From [dbo].[Driver_Table]", con);
            DataTable table = new DataTable();
            datAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
