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

namespace Construction_Management_System
{
    public partial class FormUser : Form
    {
        string Connectionstring;
        int selectedRow;
        DataAccess da;
        public FormUser()
        {
            InitializeComponent();
            dataGridViewUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUser.MultiSelect = false;
            da = new DataAccess();
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            DataTable dt1 = da.Select(string.Format("select * from User_Type"));
            /*string sql = string.Format("select * " + " from User_Type");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();*/
            comboBoxUserType.DataSource = dt1;
            comboBoxUserType.DisplayMember = "User_Type";
            comboBoxUserType.ValueMember = "Id";
            comboBoxUserType.Text = "";
            display_dataUser();
        }
        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            try
            {
                da.IUD(string.Format("insert into [User] (User_ID, Name, User_Name, User_Password, User_Type, User_Contact, User_Address) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", textBoxUserId.Text, textBoxName.Text, textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserType.Text, textBoxUserContact.Text, textBoxUserAddress.Text));
                /*string sql = string.Format("insert into [User] (User_ID, Name, User_Name, User_Password, User_Type, User_Contact, User_Address) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", textBoxUserId.Text, textBoxName.Text, textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserType.Text, textBoxUserContact.Text, textBoxUserAddress.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();*/
                display_dataUser();
                MessageBox.Show("ADDED SUCCESSFULLY");
                AddUser();
                buttonUserClear_Click(new object(), new EventArgs());
            }
            catch (Exception a)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }
        public void AddUser()
        {
            da.IUD(string.Format("insert into Login_User (UserName, Password, UserType) Values('{0}','{1}','{2}')", textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserType.Text));
            /*string sql = string.Format("insert into Login_User (UserName, Password, UserType) Values('{0}','{1}','{2}')", textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserType.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();*/
            MessageBox.Show("ADD TO LOGINUSER DATABASE SUCCESSFULLY");
            //sqlcmd.Connection.Close();
        }

        public void display_dataUser()
        {
            dataGridViewUser.DataSource = da.Select(string.Format("select * " + " from [User]"));
            /*string sql = string.Format("select * " + " from [User]");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            data1.Fill(dt1);
            dataGridViewUser.DataSource = dt1;
            sqlcmd.Connection.Close();*/
        }

        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                da.IUD(string.Format("delete " + " from [User] where User_ID={0}", textBoxUserId.Text));
                /*string sql = string.Format("delete " + " from [User] where User_ID={0}", textBoxUserId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();*/
                display_dataUser();
                MessageBox.Show("DELETE SUCCESSFULLY");
                buttonUserClear_Click(new object(), new EventArgs());
            }
            catch (Exception b)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }

        private void buttonUserUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.IUD(string.Format("update [User] set User_ID={0}, Name='{1}', User_Name='{2}', User_Password='{3}', User_Type='{4}', User_Contact='{5}', User_Address='{6}'  where  User_ID={7} ", textBoxUserId.Text, textBoxName.Text, textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserType.Text, textBoxUserContact.Text, textBoxUserAddress.Text, textBoxUserId.Text));
                /*string sql = string.Format("update [User] set User_ID={0}, Name='{1}', User_Name='{2}', User_Password='{3}', User_Type='{4}', User_Contact='{5}', User_Address='{6}'  where  User_ID={7} ", textBoxUserId.Text, textBoxName.Text, textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserType.Text, textBoxUserContact.Text, textBoxUserAddress.Text, textBoxUserId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();*/
                MessageBox.Show("UPDATE SUCCESSFULLY");
                //sqlcmd.Connection.Close();
                display_dataUser();
            }
            catch (Exception c)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow row = dataGridViewUser.Rows[selectedRow];
                textBoxUserId.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxUserName.Text = row.Cells[2].Value.ToString();
                textBoxUserPassword.Text = row.Cells[3].Value.ToString();
                textBoxUserContact.Text = row.Cells[5].Value.ToString();
                textBoxUserAddress.Text = row.Cells[6].Value.ToString();
                string aa = row.Cells[4].Value.ToString().ToUpper();
                string a;
                if (row.Cells[3].Value.ToString().ToUpper() != comboBoxUserType.Text.ToUpper())
                {
                    for (int i = 0; i < comboBoxUserType.Items.Count; i++)
                    {
                        a = comboBoxUserType.GetItemText(comboBoxUserType.Items[i]).ToUpper();

                        if (aa == a)
                        {
                            comboBoxUserType.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show("PLEASE SELECT VALID ROW!!");
            }
        }

        private void buttonUserClear_Click(object sender, EventArgs e)
        {
            textBoxUserId.Clear();
            textBoxName.Clear();
            textBoxUserName.Clear();
            textBoxUserPassword.Clear();
            comboBoxUserType.SelectedIndex = -1;
            textBoxUserContact.Clear();
            textBoxUserAddress.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHome f1 = new FormHome();
            f1.Show();
            this.Hide();
        }
    }

}