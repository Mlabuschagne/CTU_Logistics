using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTU_Logistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AppExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkToAddresses_Click(object sender, EventArgs e)
        {
            Form_Address newForm = new Form_Address();
            newForm.Show();
            this.Hide();
        }

        private void LinkToCustomers_Click(object sender, EventArgs e)
        {
            Form_Customer newForm = new Form_Customer();
            newForm.Show();
            this.Hide();
        }

        private void LinkToFreight_Click(object sender, EventArgs e)
        {
            Form_Freight newForm = new Form_Freight();
            newForm.Show();
            this.Hide();
        }

        private void LinkToDrivers_Click(object sender, EventArgs e)
        {
            Form_Driver newForm = new Form_Driver();
            newForm.Show();
            this.Hide();
        }

        private void LinkToStatus_Click(object sender, EventArgs e)
        {
            Form_Status newForm = new Form_Status();
            newForm.Show();
            this.Hide();
        }
    }
}
