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
    public partial class ItemPrice : Form
    {
        string Connectionstring;
        int selectedRow;
        DataAccess da;
        public ItemPrice()
        {
            InitializeComponent();
            dataGridViewItemPrice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItemPrice.MultiSelect = false;
            da = new DataAccess();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    da.IUD(string.Format("insert into Item_Price (Item_Catagory, Item_Pricee) Values('{0}','{1}')", comboBoxItemPriceCatagory.Text, textBoxPrice.Text));
                   /* string sql = string.Format("insert into Item_Price (Item_Catagory, Item_Pricee) Values('{0}','{1}')", comboBoxItemPriceCatagory.Text, textBoxPrice.Text);
                    SqlConnection con1 = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd = new SqlCommand(sql, con1);
                    DataTable dt1 = new DataTable();
                    sqlcmd.Connection.Open();
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Connection.Close();*/
                    display_dataPrice();
                    textBoxPrice.Clear();
                    MessageBox.Show("ADDED SUCCESSFULLY");
                }
                catch (Exception d)
                {
                    MessageBox.Show("DUPLICATE PRICE IS NOT ALLOWED");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.IUD(string.Format("update Item_Price set Item_Catagory='{0}', Item_Pricee='{1}'  where  Item_Catagory='{2}' ", comboBoxItemPriceCatagory.Text, textBoxPrice.Text, comboBoxItemPriceCatagory.Text));
                /*string sql = string.Format("update Item_Price set Item_Catagory='{0}', Item_Pricee='{1}'  where  Item_Catagory='{2}' ", comboBoxItemPriceCatagory.Text, textBoxPrice.Text, comboBoxItemPriceCatagory.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();*/
                MessageBox.Show("UPDATE SUCCESSFULLY");
                //sqlcmd.Connection.Close();
                display_dataPrice();
            }
            catch (Exception b)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormItem f1 = new FormItem();
            f1.Show();
            this.Hide();
        }

        private void ItemPrice_Load(object sender, EventArgs e)
        {
            DataTable dt1 = da.Select(string.Format("select * from Item_Catagory"));
            /*string sql = string.Format("select * " + " from Item_Catagory");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();*/
            comboBoxItemPriceCatagory.DataSource = dt1;
            comboBoxItemPriceCatagory.DisplayMember = "Item_Catagory";
            comboBoxItemPriceCatagory.ValueMember = "Id";
            display_dataPrice();
        }
        public void display_dataPrice()
        {
            dataGridViewItemPrice.DataSource = da.Select(string.Format("select * from Item_Price"));
            /*string sql = string.Format("select * " + " from Item_Price");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            data1.Fill(dt1);
            dataGridViewItemPrice.DataSource = dt1;
            sqlcmd.Connection.Close();*/
        }

        private void dataGridViewItemPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow row = dataGridViewItemPrice.Rows[selectedRow];
                comboBoxItemPriceCatagory.Text = row.Cells[0].Value.ToString();
                textBoxPrice.Text = row.Cells[1].Value.ToString();
                string cc = row.Cells[0].Value.ToString().ToUpper();
                string c;
                if (row.Cells[0].Value.ToString().ToUpper() != comboBoxItemPriceCatagory.Text.ToUpper())
                {
                    for (int i = 0; i < comboBoxItemPriceCatagory.Items.Count; i++)
                    {
                        c = comboBoxItemPriceCatagory.GetItemText(comboBoxItemPriceCatagory.Items[i]).ToUpper();

                        if (cc == c)
                        {
                            comboBoxItemPriceCatagory.SelectedIndex = i;
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
