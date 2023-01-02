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
    public partial class Sales : Form
    {
        bool selectionCombo = false;
        bool selectionCombo1 = false;
        bool selectionCombo2 = false;
        float discount, discountGiven;
        double totalprice;
        int selectedRow, id;
        string catagory;
        DataAccess da;
        public Sales()
        {
            InitializeComponent();
            dataGridViewTotal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTotal.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            da = new DataAccess();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager f1 = new FormManager();
            f1.Show();
            this.Hide();
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            DataTable dt1 = da.Select(string.Format("select * " + " from Client"));
            /*string sql1 = string.Format("select * " + " from Client");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd1 = new SqlCommand(sql1, con1);
            DataTable dt1 = new DataTable();
            sqlcmd1.Connection.Open();
            dt1.Load(sqlcmd1.ExecuteReader());
            sqlcmd1.Connection.Close();*/
            comboBoxClientId.DataSource = dt1;
            comboBoxClientId.DisplayMember = "Client_ID";
            comboBoxClientId.ValueMember = "Client_ID";

            selectionCombo = true;

            DataTable dt = da.Select(string.Format("select * " + " from Item_Price"));
            /*string sql = string.Format("select * " + " from Item_Price");
            SqlConnection con = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            sqlcmd.Connection.Open();
            dt.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();*/
            comboBoxSalesItem.DataSource = dt;
            comboBoxSalesItem.DisplayMember = "Item_Catagory";
            comboBoxSalesItem.ValueMember = "Item_Catagory";

            selectionCombo1 = true;

            comboBoxTransportation.Text = "";

            DataTable dt2 = da.Select(string.Format("select * " + " from Transportation_Manager"));
            /*string sql2 = string.Format("select * " + " from Transportation_Manager");
            SqlConnection con2 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd2 = new SqlCommand(sql2, con2);
            DataTable dt2 = new DataTable();
            sqlcmd2.Connection.Open();
            dt2.Load(sqlcmd2.ExecuteReader());
            sqlcmd2.Connection.Close();*/
            comboBoxTransportation.DataSource = dt2;
            comboBoxTransportation.DisplayMember = "Car_Number";
            comboBoxTransportation.ValueMember = "Transportation_Id";

            selectionCombo2 = true;
            textBoxAfterDiscount.Text = "";
            comboBoxClientId.Text = "";
            comboBoxSalesItem.Text = "";
            comboBoxTransportation.Text = "";
            buttonSalesAdd_Click(new object(), new EventArgs());

        }
        private void caltotal()
        {
            double cal2=0;
            for(int i=0; i < dataGridViewTotal.Rows.Count; i++)
            {
                try
                {
                    cal2 += Convert.ToDouble(dataGridViewTotal.Rows[i].Cells[4].Value);
                }
                catch (Exception r)
                {

                }
                textBoxGrantTotal.Text = cal2.ToString();
            }
        }

        private void comboBoxClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectionCombo)
                {
                    DataTable dt1 = da.Select(string.Format("select * from Client where Client_ID='{0}'" ,comboBoxClientId.Text.ToString()));
                    /*SqlConnection con1 = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd1 = new SqlCommand("select * from Client where Client_ID= '" + comboBoxClientId.Text.ToString() + "'", con1);
                    DataTable dt1 = new DataTable();
                    sqlcmd1.Connection.Open();
                    dt1.Load(sqlcmd1.ExecuteReader());
                    sqlcmd1.Connection.Close();*/
                    textBoxClientName.Text = dt1.Rows[0][1].ToString();
                    textBoxClientContact.Text = dt1.Rows[0][3].ToString();
                }
            }
            catch (Exception h)
            {

            }
        }

        private void comboBoxSalesItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectionCombo1)
                {
                    DataTable dt = da.Select(string.Format("select * from Item_Price where Item_Catagory='{0}'" ,comboBoxSalesItem.Text.ToString()));
                    /*SqlConnection con = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd = new SqlCommand("select * from Item_Price where Item_Catagory= '" + comboBoxSalesItem.Text.ToString() + "'", con);
                    DataTable dt = new DataTable();
                    sqlcmd.Connection.Open();
                    dt.Load(sqlcmd.ExecuteReader());
                    sqlcmd.Connection.Close();*/
                    textBoxSalesPrice.Text = dt.Rows[0][1].ToString();
                }
            }
            catch (Exception h)
            {

            }
        }

        private void textBoxSalesQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxSalesTotal.Text = (float.Parse(textBoxSalesPrice.Text) * float.Parse(textBoxSalesQuantity.Text)).ToString();
            }
            catch (Exception q)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt5 = da.Select(string.Format("select Item_Quantity from Storage where Item_Catagory='{0}'", comboBoxSalesItem.Text));
                /*string sql3 = string.Format("select Item_Quantity from Storage where Item_Catagory='{0}'", comboBoxSalesItem.Text);
                SqlConnection con2 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd3 = new SqlCommand(sql3, con2);
                DataTable dt5 = new DataTable();
                sqlcmd3.Connection.Open();
                dt5.Load(sqlcmd3.ExecuteReader());
                sqlcmd3.Connection.Close();*/
                MessageBox.Show(dt5.Rows[0][0].ToString());
                double totalQuantity = Convert.ToDouble(dt5.Rows[0][0].ToString());
                double currentQuantity = Convert.ToDouble(textBoxSalesQuantity.Text);
                if (totalQuantity>=currentQuantity)
                {
                    DataTable dt4 = da.Select(string.Format("select * from Sales_Price_Cart where Item='{0}' and Sales_ID={1}", comboBoxSalesItem.Text, textBoxSalesId.Text));
                    /*string sql2 = string.Format("select * from Sales_Price_Cart where Item='{0}' and Sales_ID={1}", comboBoxSalesItem.Text, textBoxSalesId.Text);
                    DataTable dt4 = new DataTable();
                    SqlConnection con = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd2 = new SqlCommand(sql2, con);
                    sqlcmd2.Connection.Open();
                    dt4.Load(sqlcmd2.ExecuteReader());
                    sqlcmd2.Connection.Close();*/
                    if (dt4.Rows.Count == 0)
                    {
                        if (textBoxAfterDiscount.Text == "")
                        {
                            totalprice = Convert.ToDouble(textBoxSalesTotal.Text);
                        }
                        da.Select(string.Format("insert into Sales_Price_Cart (Item, Price, Quantity, Discount_Price, Total, Sales_ID) Values('{0}','{1}','{2}','{3}','{4}','{5}')", comboBoxSalesItem.Text, textBoxSalesPrice.Text, textBoxSalesQuantity.Text, textBoxDiscountPrice.Text, totalprice.ToString(), textBoxSalesId.Text));
                        /*string sql = string.Format("insert into Sales_Price_Cart (Item, Price, Quantity, Discount_Price, Total, Sales_ID) Values('{0}','{1}','{2}','{3}','{4}','{5}')", comboBoxSalesItem.Text, textBoxSalesPrice.Text, textBoxSalesQuantity.Text, textBoxDiscountPrice.Text, totalprice.ToString(), textBoxSalesId.Text);
                        SqlCommand sqlcmd = new SqlCommand(sql, con);
                        DataTable dt = new DataTable();
                        sqlcmd.Connection.Open();
                        sqlcmd.ExecuteNonQuery();
                        sqlcmd.Connection.Close();*/
                        display_dataSales();
                        MessageBox.Show("ADDED SUCCESSFULLY");
                        textBoxDiscount.Text = "";
                        textBoxDiscountPrice.Text = "";
                        textBoxSalesQuantity.Text = "";
                        textBoxSalesPrice.Text = "";
                        textBoxSalesTotal.Text = "";
                        comboBoxSalesItem.Text = "";

                        caltotal();
                        textBoxAfterDiscount.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("DUPLICATE ITEM CANNOT BE INSERTED");
                    }
                }
                else
                {
                    MessageBox.Show("Do not have enough quantity!!");
                }

            }
            catch (Exception o)
            {
                MessageBox.Show("SELECTED DUPLICATE ITEM");
            }

        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if(textBoxDiscount.Text=="")
                {
                    textBoxDiscountPrice.Text = "";
                    textBoxAfterDiscount.Text = "";
                    totalprice = Convert.ToDouble(textBoxSalesTotal.Text);
                }
                else if (textBoxDiscount.Text != "0")
                {
                    discount = float.Parse(textBoxDiscount.Text.ToString());
                    if(discount<=100 && discount>=0)
                    {
                        discountGiven = float.Parse(textBoxSalesTotal.Text) * (discount / 100);
                        textBoxDiscountPrice.Text = discountGiven.ToString();

                        textBoxAfterDiscount.Text = (float.Parse(textBoxSalesTotal.Text) - discountGiven).ToString();
                        totalprice = Convert.ToDouble(textBoxAfterDiscount.Text);
                    }
                    else
                    {
                        MessageBox.Show("DISCOUNT CAN NOT BE NEGATIVE OR EXCEED 100%");
                        textBoxDiscount.Text = "";
                    }
                }
                else
                {
                    totalprice = Convert.ToDouble(textBoxSalesTotal.Text);
                }
            }
            catch (Exception p)
            {
                MessageBox.Show("ENTER A NUMBER OR FILL QUANTITY");
                textBoxDiscount.Text = "";
                textBoxDiscountPrice.Text = "";
                textBoxAfterDiscount.Text = "";
            }
            
        }
        public void display_dataSales()
        {
            dataGridViewTotal.DataSource = da.Select(string.Format("select * from Sales_Price_Cart where Sales_ID={0}", textBoxSalesId.Text));
            /*string sql = string.Format("select * " + " from Sales_Price_Cart where Sales_ID={0}",textBoxSalesId.Text);
            SqlConnection con = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            data1.Fill(dt);
            dataGridViewTotal.DataSource = dt;
            sqlcmd.Connection.Close();*/
        }
        private void comboBoxTransportation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectionCombo2)
                {
                    DataTable dt = da.Select(string.Format("select * from Transportation_Manager where Booking_Condition='Available' and Car_Number='{0}'" ,comboBoxTransportation.Text.ToString()));
                    /*SqlConnection con = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd = new SqlCommand("select * from Transportation_Manager where Booking_Condition='Available' and Car_Number='" + comboBoxTransportation.Text.ToString()+"'", con);
                    DataTable dt = new DataTable();
                    sqlcmd.Connection.Open();
                    dt.Load(sqlcmd.ExecuteReader());
                    sqlcmd.Connection.Close();*/
                    if (dt.Rows.Count==0)
                    {
                        textBoxSalesAvailable.Text = "NOT AVAILABLE";
                    }
                    else
                    {
                        textBoxSalesAvailable.Text = "AVAILABLE";
                    }
                }
            }
            catch (Exception h)
            {

            }
        }
        private void buttonBooked_Click(object sender, EventArgs e)
        {
            if (textBoxSalesAvailable.Text == "AVAILABLE")
            {
                da.IUD(string.Format("update Transportation_Manager set Booking_Condition='Booked'  where  Car_Number='{0}' ", comboBoxTransportation.Text));
                /*string sql = string.Format("update Transportation_Manager set Booking_Condition='Booked'  where  Car_Number='{0}' ",comboBoxTransportation.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();*/
                MessageBox.Show("UPDATE SUCCESSFULLY");
                //sqlcmd.Connection.Close();
                textBoxSalesAvailable.Text = "BOOKED";
            }
        }

        private void buttonSalesAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string a = textBoxSalesAvailable.Text;
                if (a != "NOT AVAILABLE")
                {
                    try
                    {
                        da.IUD(string.Format("insert into Sales(Sales_ID,Client_ID,Client_Name,Contact,Transportation,Date) Values('{0}','{1}','{2}','{3}','{4}','{5}')", textBoxSalesId.Text, comboBoxClientId.Text, textBoxClientName.Text, textBoxClientContact.Text, comboBoxTransportation.Text, DateTime.Now.ToString()));
                        /*string sql = string.Format("insert into Sales(Sales_ID,Client_ID,Client_Name,Contact,Transportation,Date) Values('{0}','{1}','{2}','{3}','{4}','{5}')", textBoxSalesId.Text, comboBoxClientId.Text, textBoxClientName.Text, textBoxClientContact.Text, comboBoxTransportation.Text, DateTime.Now.ToString());
                        SqlConnection con1 = new SqlConnection(Connectionstring);
                        SqlCommand sqlcmd = new SqlCommand(sql, con1);
                        sqlcmd.Connection.Open();
                        sqlcmd.ExecuteNonQuery();
                        sqlcmd.Connection.Close();*/
                    }
                    catch (Exception ex)
                    {


                    }
                    for (int i = 0; i < dataGridViewTotal.Rows.Count-1; i++)
                    {
                        DataTable dt1 = da.Select(string.Format("select Item_Quantity from Storage where Item_Catagory='{0}'", dataGridViewTotal.Rows[i].Cells[0].Value));
                        /*string sql = string.Format("select Item_Quantity from Storage where Item_Catagory='{0}'", dataGridViewTotal.Rows[i].Cells[0].Value);
                        SqlConnection con1 = new SqlConnection(Connectionstring);
                        SqlCommand sqlcmd = new SqlCommand(sql, con1);
                        DataTable dt1 = new DataTable();
                        sqlcmd.Connection.Open();
                        dt1.Load(sqlcmd.ExecuteReader());
                        sqlcmd.Connection.Close();*/

                        double currnetQuantity = Convert.ToDouble(dt1.Rows[0][0].ToString());
                        double newTotal = currnetQuantity - Convert.ToDouble(dataGridViewTotal.Rows[i].Cells[2].Value);

                        da.IUD(string.Format("update Storage set Item_Quantity={0} where  Item_Catagory='{1}' ", newTotal, dataGridViewTotal.Rows[i].Cells[0].Value));
                        /*string sq2 = string.Format("update Storage set Item_Quantity={0} where  Item_Catagory='{1}' ", newTotal, dataGridViewTotal.Rows[i].Cells[0].Value);
                        SqlConnection con3 = new SqlConnection(Connectionstring);
                        SqlCommand sqlcmd3 = new SqlCommand(sq2, con3);
                        sqlcmd3.Connection.Open();
                        sqlcmd3.ExecuteNonQuery();
                        sqlcmd3.Connection.Close();*/
                    }
                    refreshTable2();
                    dataGridViewTotal.DataSource = null;
                }
                else
                {
                    MessageBox.Show("SELECTED TRANSPORT NOT AVAILABLE");
                }
            }
            catch (Exception v)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
        }

        private void buttonSalesClear_Click(object sender, EventArgs e)
        {
            dataGridViewTotal.DataSource = null;
            textBoxSalesId.Text = "";
            comboBoxClientId.Text = "";
            textBoxClientName.Text = "";
            textBoxClientContact.Text = "";
            textBoxSalesPrice.Text = "";
            textBoxSalesQuantity.Text = "";
            textBoxGrantTotal.Text = "";
            textBoxAfterDiscount.Text = "";
            textBoxDiscount.Text = "";
            comboBoxSalesItem.Text = "";
            textBoxDiscountPrice.Text = "";
            comboBoxTransportation.Text = "";
            textBoxSalesTotal.Text = "";
            textBoxSalesAvailable.Text = "";
        }
        /*private void buttonSalesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete from Sales where Sales_ID={0}", textBoxSalesId.Text);
                SqlConnection con = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con);
                DataTable dt = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();
                //MessageBox.Show("DELETE SUCCESSFULLY");

                string sql1 = string.Format("delete from Sales_Price_Cart where Sales_ID={0}", textBoxSalesId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd1 = new SqlCommand(sql1, con1);
                DataTable dt1 = new DataTable();
                sqlcmd1.Connection.Open();
                sqlcmd1.ExecuteNonQuery();
                sqlcmd1.Connection.Close();
                MessageBox.Show("DELETE SUCCESSFULLY");
                refreshTable2();
            }
            catch (Exception b)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }*/

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBoxSalesId.Text = row.Cells[0].Value.ToString();
                comboBoxClientId.Text = row.Cells[1].Value.ToString();
                textBoxClientName.Text = row.Cells[2].Value.ToString();
                textBoxClientContact.Text = row.Cells[3].Value.ToString();
                comboBoxTransportation.Text = row.Cells[4].Value.ToString();
                comboBoxSalesItem.Text = row.Cells[6].Value.ToString();
                textBoxSalesPrice.Text = row.Cells[7].Value.ToString();
                textBoxSalesQuantity.Text = row.Cells[8].Value.ToString();
                textBoxDiscountPrice.Text = row.Cells[9].Value.ToString();
                textBoxSalesTotal.Text = row.Cells[10].Value.ToString();
                string bb = row.Cells[4].Value.ToString().ToUpper();
                string cc = row.Cells[6].Value.ToString().ToUpper();
                string aa = row.Cells[1].Value.ToString().ToUpper();
                string a;
                if (aa != comboBoxClientId.Text.ToUpper())
                {
                    for (int i = 0; i < comboBoxClientId.Items.Count; i++)
                    {
                        a = comboBoxClientId.GetItemText(comboBoxClientId.Items[i]).ToUpper();

                        if (aa == a)
                        {
                            comboBoxClientId.SelectedIndex = i;
                            break;
                        }
                    }
                }

                string b;
                if (bb != comboBoxTransportation.Text.ToUpper())
                {
                    for (int i = 0; i < comboBoxTransportation.Items.Count; i++)
                    {
                        b = comboBoxTransportation.GetItemText(comboBoxTransportation.Items[i]).ToUpper();

                        if (bb == b)
                        {
                            comboBoxTransportation.SelectedIndex = i;
                            break;
                        }
                    }
                }
                string c;
                if (cc != comboBoxSalesItem.Text.ToUpper())
                {
                    for (int i = 0; i < comboBoxSalesItem.Items.Count; i++)
                    {
                        c = comboBoxSalesItem.GetItemText(comboBoxSalesItem.Items[i]).ToUpper();

                        if (cc == c)
                        {
                            comboBoxSalesItem.SelectedIndex = i;
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

        private void buttonSalesUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.IUD(string.Format("update Sales set Client_ID={0}, Client_Name='{1}', Contact='{2}', Transportation='{3}'  where  Sales_ID={4} ", comboBoxClientId.Text, textBoxClientName.Text, textBoxClientContact.Text, comboBoxTransportation.Text, textBoxSalesId.Text));
                /*string sql = string.Format("update Sales set Client_ID={0}, Client_Name='{1}', Contact='{2}', Transportation='{3}'  where  Sales_ID={4} ", comboBoxClientId.Text, textBoxClientName.Text, textBoxClientContact.Text, comboBoxTransportation.Text, textBoxSalesId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();*/
                MessageBox.Show("UPDATE SUCCESSFULLY");
                //sqlcmd.Connection.Close();
                refreshTable2();
            }
            catch (Exception c)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage(this);
            storage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                da.IUD(string.Format("delete " + " from Sales_Price_Cart where Sales_ID={0} and Item='{1}'", id.ToString(), catagory));
                /*string sql = string.Format("delete " + " from Sales_Price_Cart where Sales_ID={0} and Item='{1}'", id.ToString(),catagory);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();*/
                display_dataSales();
                MessageBox.Show("DELETE SUCCESSFULLY");
            }
            catch (Exception b)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
        }

        private void dataGridViewTotal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow row = dataGridViewTotal.Rows[selectedRow];
                id = Convert.ToInt32(row.Cells[5].Value.ToString());
                catagory = row.Cells[0].Value.ToString();
            }
            catch (Exception exe)
            {
                MessageBox.Show("PLEASE SELECT VALID ROW!!");
            }
        }

        public void refreshTable2()
        {
            DataTable dt = da.Select(string.Format("select * from Sales inner join Sales_Price_Cart  ON Sales.Sales_ID=Sales_Price_Cart.Sales_ID order by Sales.Date desc", textBoxSalesId.Text));
            /*SqlConnection con = new SqlConnection(Connectionstring);
            string sql2 = string.Format("select * from Sales inner join Sales_Price_Cart  ON Sales.Sales_ID=Sales_Price_Cart.Sales_ID order by Sales.Date desc", textBoxSalesId.Text);
            DataTable dt = new DataTable();
            SqlCommand sqlcmd2 = new SqlCommand(sql2, con);
            sqlcmd2.Connection.Open();
            dt.Load(sqlcmd2.ExecuteReader());
            sqlcmd2.Connection.Close();*/
            dt.Columns.Remove("Sales_ID1");
            dataGridView1.DataSource = dt;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
    }
}
