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
    public partial class BMI : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zking001\source\repos\CTU_Logistics\CTU_Logistics\DBCtuLogistics.mdf;Integrated Security=True");
        public BMI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Height = Convert.ToDouble(textBox1.Text);
            double Weight = Convert.ToDouble(textBox2.Text);
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
                result2 = "Your are Under Weight";
            }

            else
                if (result < 25)
            {
                result2 = "You have Normal Weight";
            }

            else
                if(result < 30)
            {
                result2 = "You are over Weight";
            }

            else
                if(result >=30)
            {
                result2 = "You are Obese";
            }

            textBox3.Text = "Your BMI is " + result.ToString("#.#") + "\r\n" + result2;

          
        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }
    }
}
