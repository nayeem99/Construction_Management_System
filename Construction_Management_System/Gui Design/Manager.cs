using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_Management_System.Gui_Design
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }
        private void buttonHomeItem_Click(object sender, EventArgs e)
        {
            Item_Manager openform = new Item_Manager();
            openform.Show();
            this.Hide();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClient OpenClient = new FormClient(this);
            OpenClient.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSupplier openform = new FormSupplier(this);
            openform.Show();
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
            Sales open = new Sales();
            open.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transport openform = new Transport(this);
            openform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSalesReport openform = new FormSalesReport(this);
            openform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Storage openform = new Storage(this);
            openform.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEmployee openEmployee = new FormEmployee(this);
            openEmployee.Show();
            this.Hide();
        }
    }
}
