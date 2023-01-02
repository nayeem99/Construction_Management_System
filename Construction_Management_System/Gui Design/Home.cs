using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Construction_Management_System.Gui_Design;

namespace Construction_Management_System
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        private void buttonHomeItem_Click(object sender, EventArgs e)
        {
            FormItem openform = new FormItem();
            openform.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormUser openwindow = new FormUser();
            openwindow.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEmployee openEmployee = new FormEmployee(this);
            openEmployee.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FormSupplier openSupplier = new FormSupplier(this);
            openSupplier.Show();
            this.Hide();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            FormSalesReport opensalesReport = new FormSalesReport(this);
            opensalesReport.Show();
            this.Hide();
        }
        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClient OpenClient = new FormClient(this);
            OpenClient.Show();
            this.Hide();
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Transport openform = new Transport(this);
            openform.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage(this);
            storage.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
