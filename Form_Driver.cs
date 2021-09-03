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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO BMI_Table VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Data Have been Inserted into the Datbase Thank you ");
            con.Close();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form_Driver_Load(object sender, EventArgs e)
        {
            

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE BMI_Table WHERE id = '" + textBox1.Text + "'", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Data have been deleted");
            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = textBox2.Text = textBox2.Text = textBox3.Text = textBox3.Text = textBox4.Text = textBox4.Text = textBox5.Text = textBox5.Text = "";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter datAdapter = new SqlDataAdapter("Select * From [dbo].[BMI_Table]", con);
            DataTable table = new DataTable();
            datAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            BMI newForm = new BMI();
            newForm.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            double Height = Convert.ToDouble(textBox3.Text);
            double Weight = Convert.ToDouble(textBox4.Text);
            double result = 0.0;
            string result2 = "";

            if (radioButton1.Checked)
            {
                result = Weight / (Height * Height);
            }
            else
                if (radioButton2.Checked)
            {
                Weight = Weight / 2.205;
                result = Weight / (Height * Height);
            }

            if (result < 18.5)
            {
                result2 = "Under";
            }

            else
                if (result < 25)
            {
                result2 = "Normal";
            }

            else
                if (result < 30)
            {
                result2 = "over";
            }

            else
                if (result >= 30)
            {
                result2 = "Obese";
            }

            textBox5.Text =  result.ToString("#.#") + "\r\n" + result2;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zking001\source\repos\CTU_Logistics\CTU_Logistics\DBCtuLogistics.mdf;Integrated Security=True");
            try
            {
                string query = "select * from BMI_table where Id='" + textBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = null;

                con.Open();
                reader = com.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader.GetValue(1).ToString();
                    textBox3.Text = reader.GetValue(2).ToString();
                    textBox4.Text = reader.GetValue(3).ToString();
                    textBox5.Text = reader.GetValue(4).ToString();

                }
                else
                {
                    textBox1.Text = "Record was not Found...!";
                }
            }
            catch
            {

            }
        }
    }
}
