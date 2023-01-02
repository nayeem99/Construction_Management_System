using Construction_Management_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_Management_System.Gui_Design
{
    public partial class Storage : Form
    {
        string Connectionstring;
        Form prevForm1;
        DataAccess da;
        public Storage(Form form)
        {
            InitializeComponent();
            this.prevForm1 = form;
            dataGridViewStorage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStorage.MultiSelect = false;
            da = new DataAccess();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm1.Show();
            this.Hide();

        }

        private void Storage_Load(object sender, EventArgs e)
        {
            dataGridViewStorage.DataSource = da.Select(string.Format("select * from Storage"));
            /*string sql = string.Format("select * from Storage");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            dataGridViewStorage.DataSource = dt1;*/
        }
    }
}
