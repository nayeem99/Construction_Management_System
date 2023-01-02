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
    public partial class Transport : Form
    {
        string Connectionstring;
        int selectedRow;
        Form prevForm3;
        DataAccess da;
        public Transport(Form form)
        {
            InitializeComponent();
            dataGridViewTran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTran.MultiSelect = false;
            this.prevForm3 = form;
            da = new DataAccess();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm3.Show();
            this.Hide();
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            DataTable dt1 = da.Select(string.Format("select * from Booking"));
            /*string sql = string.Format("select * " + " from Booking");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();*/
            comboBoxBooked.DataSource = dt1;
            comboBoxBooked.DisplayMember = "Booking_Condition";
            comboBoxBooked.ValueMember = "Id";
            comboBoxBooked.Text = "";
            display_Tran();
        }
        public void display_Tran()
        {
            dataGridViewTran.DataSource = da.Select(string.Format("select * from Transportation_Manager"));
            /*string sql = string.Format("select * " + " from Transportation_Manager");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            data1.Fill(dt1);
            dataGridViewTran.DataSource = dt1;
            sqlcmd.Connection.Close();*/
        }

        private void buttonTransAdd_Click(object sender, EventArgs e)
        {
            try
            {
                da.IUD(string.Format("insert into Transportation_Manager (Transportation_ID, Car_Number, Driver_Name, Driving_Licence, Contact, Address, Booking_Condition) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", textBoxTranId.Text, textBoxTranCarNumber.Text, textBoxTranDriverName.Text, textBoxTranLicence.Text, textBoxTranContact.Text, textBoxTranAddress.Text, comboBoxBooked.Text));
                /*string sql = string.Format("insert into Transportation_Manager (Transportation_ID, Car_Number, Driver_Name, Driving_Licence, Contact, Address, Booking_Condition) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", textBoxTranId.Text, textBoxTranCarNumber.Text, textBoxTranDriverName.Text, textBoxTranLicence.Text, textBoxTranContact.Text, textBoxTranAddress.Text, comboBoxBooked.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();*/
                display_Tran();
                MessageBox.Show("ADDED SUCCESSFULLY");
                buttonTranClear_Click(new object(), new EventArgs());
            }
            catch (Exception a)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            

        }

        private void buttonTranUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.IUD(string.Format("update Transportation_Manager set Transportation_ID='{0}', Car_Number='{1}', Driver_Name='{2}', Driving_Licence ='{3}', Contact='{4}', Address='{5}', Booking_Condition='{6}' where Transportation_ID='{7}' ", textBoxTranId.Text, textBoxTranCarNumber.Text, textBoxTranDriverName.Text, textBoxTranLicence.Text, textBoxTranContact.Text, textBoxTranAddress.Text, comboBoxBooked.Text, textBoxTranId.Text));
                /*string sql = string.Format("update Transportation_Manager set Transportation_ID='{0}', Car_Number='{1}', Driver_Name='{2}', Driving_Licence ='{3}', Contact='{4}', Address='{5}', Booking_Condition='{6}' where Transportation_ID='{7}' ", textBoxTranId.Text, textBoxTranCarNumber.Text, textBoxTranDriverName.Text, textBoxTranLicence.Text, textBoxTranContact.Text, textBoxTranAddress.Text, comboBoxBooked.Text, textBoxTranId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();*/
                MessageBox.Show("UPDATE SUCCESSFULLY");
                //sqlcmd.Connection.Close();
                display_Tran();
            }
            catch (Exception b)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            

        }

        private void buttonTranDelete_Click(object sender, EventArgs e)
        {
            try
            {
                da.IUD(string.Format("delete " + " from Transportation_Manager where Transportation_ID={0}", textBoxTranId.Text));
                /*string sql = string.Format("delete " + " from Transportation_Manager where Transportation_ID={0}", textBoxTranId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();*/
                display_Tran();
                MessageBox.Show("DELETE SUCCESSFULLY");
                buttonTranClear_Click(new object(), new EventArgs());
            }
            catch (Exception c)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            

        }

        private void buttonTranClear_Click(object sender, EventArgs e)
        {
            textBoxTranId.Clear();
            textBoxTranCarNumber.Clear();
            textBoxTranDriverName.Clear();
            textBoxTranLicence.Clear();
            textBoxTranContact.Clear();
            textBoxTranAddress.Clear();
            comboBoxBooked.SelectedIndex = -1;

        }

        private void dataGridViewTran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow row = dataGridViewTran.Rows[selectedRow];
                textBoxTranId.Text = row.Cells[0].Value.ToString();
                textBoxTranCarNumber.Text = row.Cells[1].Value.ToString();
                textBoxTranDriverName.Text = row.Cells[2].Value.ToString();
                textBoxTranLicence.Text = row.Cells[3].Value.ToString();
                textBoxTranContact.Text = row.Cells[4].Value.ToString();
                textBoxTranAddress.Text = row.Cells[5].Value.ToString();

                string aa = row.Cells[6].Value.ToString().ToUpper();
                string a;
                if (row.Cells[6].Value.ToString().ToUpper() != comboBoxBooked.Text.ToUpper())
                {
                    for (int i = 0; i < comboBoxBooked.Items.Count; i++)
                    {
                        a = comboBoxBooked.GetItemText(comboBoxBooked.Items[i]).ToUpper();

                        if (aa == a)
                        {
                            comboBoxBooked.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("PLEASE SELECT VALID ROW!!");
            }
            
        }
    }
}
