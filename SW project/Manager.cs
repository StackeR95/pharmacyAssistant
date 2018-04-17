using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_project
{
    public partial class Manager : Form
    {
        Controller controller;
        string username1;
        public Manager(string username,Controller cont)
        {
            controller = cont;
            username1 = username;
            InitializeComponent();
            stocklevel();
            label140.Hide();
            textBox12.Hide();
            comboBox8.Hide();
            label29.Hide();
            label141.Hide();
            label142.Hide();
            dateTimePicker6.Hide();
            dateTimePicker4.Hide();
            toolStripStatusLabel1.Text = "Logged in as: " + username1;
            toolStripStatusLabel2.Text = "            Stock Level: ";
            fillcombo();
        }
        private void fillcombo()
        {

            DataTable dt0 = controller.get_all_medicine();
            comboBox5.DataSource = dt0;
            comboBox5.DisplayMember = "Code";
            comboBox5.ValueMember = "Code";
            DataTable dt2 = controller.stockavailable();
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "Tradename";
            comboBox1.ValueMember = "Code";
            DataTable dt1 = controller.get_all_customers();
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "cname";
            comboBox2.ValueMember = "cust_code";
            comboBox7.DataSource = dt1;
            comboBox7.DisplayMember = "cname";
            comboBox7.ValueMember = "cust_code";
            DataTable dt3 = controller.get_all_orders();
            comboBox6.DataSource = dt3;
            comboBox6.DisplayMember = "transaction_no";
            comboBox6.ValueMember = "transaction_no";


            comboBox5.SelectedIndexChanged += new System.EventHandler(ComboBox5_SelectedIndexChanged); //edit medicine
            comboBox26.SelectedIndexChanged += new System.EventHandler(ComboBox26_SelectedIndexChanged);
            comboBox2.SelectedIndexChanged += new System.EventHandler(ComboBox2_SelectedIndexChanged); //edit customer
        }
        private void ComboBox5_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataTable dt0 = controller.get_all_medicine();


            DataRow dr = dt0.AsEnumerable().SingleOrDefault(r => r.Field<int>("Code") == Int32.Parse(comboBox5.Text));
            textBox19.Text = dr[3].ToString();
            textBox14.Text = dr[1].ToString();
            textBox10.Text = dr[2].ToString();
            textBox11.Text = dr[5].ToString();
            comboBox4.Text = dr[4].ToString();

        }
        private void ComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataTable dt0 = controller.get_all_customers();


            DataRow dr = dt0.AsEnumerable().SingleOrDefault(r => r.Field<int>("cust_code") == Int32.Parse(comboBox2.SelectedValue.GetHashCode().ToString()));
            textBox9.Text = dr[2].ToString();
            textBox8.Text = dr[4].ToString();
            richTextBox2.Text = dr[3].ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != string.Empty && textBox3.Text.Trim() != string.Empty && textBox4.Text.Trim() != string.Empty) {
                if (textBox2.Text == textBox4.Text)
                {
                    int flag = controller.CheckAccountPassword(username1, textBox3.Text);
                    if (flag == 1)
                    {
                        int result = controller.ChangePassword(username1, textBox2.Text);
                        if (result == 1)
                        {
                            MessageBox.Show("Password changed, please relogin");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old password is wrong");
                    }



                }
                else
                {
                    MessageBox.Show("New passwords doesn't match");
                }
            }
            else
            {
                MessageBox.Show("One of the fields is empty. Please enter inputs.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(textBox17.Text, out i) && textBox13.Text.Trim() != string.Empty && textBox15.Text.Trim() != string.Empty && textBox16.Text.Trim() != string.Empty && textBox17.Text.Trim() != string.Empty && textBox18.Text.Trim() != string.Empty) {
                int result = controller.InsertMedicine(Int32.Parse(textBox17.Text), textBox16.Text, textBox15.Text, textBox13.Text, comboBox3.Text, float.Parse(textBox18.Text));
                if (result == 0)
                {
                    MessageBox.Show("No Product Added, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Product Added Successfully");
                }
                fillcombo();
            }
            else
            {
                MessageBox.Show("One of the fields is wrong or empty. Please re-enter inputs.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim() != string.Empty && textBox6.Text.Trim() != string.Empty && textBox7.Text.Trim() != string.Empty) {
                int result = controller.InsertCustomer(textBox5.Text, textBox6.Text, richTextBox1.Text, textBox7.Text);
                if (result == 0)
                {
                    MessageBox.Show("No Customer Added, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Customer Added Successfully");
                }
                fillcombo();
            }
            else
            {
                MessageBox.Show("One of the fields is empty. Please enter inputs.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox11.Text.Trim() != string.Empty && textBox10.Text.Trim() != string.Empty && textBox19.Text.Trim() != string.Empty && textBox14.Text.Trim() != string.Empty)
            {
                int result = controller.EditMedicine(Int32.Parse(comboBox5.SelectedValue.GetHashCode().ToString()), textBox19.Text, textBox14.Text, textBox10.Text, comboBox4.Text, float.Parse(textBox11.Text));
                if (result == 0)
                {
                    MessageBox.Show("No Product Updated, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Product Updated Successfully");
                }
                fillcombo();
            }
            else
            {
                MessageBox.Show("One of the fields is empty. Please enter inputs.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox8.Text.Trim() != string.Empty && textBox9.Text.Trim() != string.Empty) {
                int result = controller.EditCustomer(Int32.Parse(comboBox2.SelectedValue.GetHashCode().ToString()), comboBox2.Text, textBox9.Text, richTextBox2.Text, textBox8.Text);
                if (result == 0)
                {
                    MessageBox.Show("No Customer Updated, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Customer Updated Successfully");
                }
                fillcombo();
            }
            else
            {
                MessageBox.Show("One of the fields is empty. Please enter inputs.");
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
                int c = Int32.Parse(comboBox7.SelectedValue.GetHashCode().ToString());
                int result = controller.DeleteCustomer(c);
                if (result == 0)
                {
                    MessageBox.Show("Nothing have been deleted, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Customer deleted Successfully");
                }
                fillcombo();
            
          

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("One of the fields is empty. Please enter inputs.");
            }
            else
            {
                DataTable dt = controller.stockavailable();
                int stockcount = (from DataRow dr in dt.Rows
                                  where (int)dr["Code"] == Int32.Parse(comboBox1.SelectedValue.GetHashCode().ToString())
                                  select (int)dr["Stock"]).FirstOrDefault();
                string[] row = { comboBox1.Text, comboBox1.SelectedValue.GetHashCode().ToString(), textBox1.Text.ToString() };

                if (Int32.Parse(textBox1.Text.ToString()) < 1)
                {
                    MessageBox.Show("Invalid Quantity, re-enter quantity.");
                }
                else
                {
                    if (stockcount == 0)
                    {
                        MessageBox.Show("Product is out of stock");
                    }
                    else if (Int32.Parse(textBox1.Text) > (stockcount))
                    {
                        MessageBox.Show("Insufficient stock available");
                        textBox1.Clear();
                    }
                    else
                    {
                        dataGridView4.Rows.Add(row);

                    }
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (dataGridView4.Rows.Count > 0)
            {

                int result1 = controller.insertorders();
                int transno = controller.lastorderno();
                for (int i = 0; i < dataGridView4.Rows.Count; i++)
                {
                    controller.insertordercon(Int32.Parse(dataGridView4.Rows[i].Cells[2].Value.ToString()), Int32.Parse(dataGridView4.Rows[i].Cells[1].Value.ToString()), transno);

                }
                dataGridView4.Rows.Clear();
                stocklevel();
                fillcombo();
                textBox1.Clear();
                orderrec Or = new orderrec(transno);
                Or.Show();
            }
            else
            {
                MessageBox.Show("No order items selected");
            }

        }
        private void stocklevel()
        {
            int countinstock = controller.getoutofstockcount();
            if (countinstock == 0)
            {
                toolStripDropDownButton2.Enabled = false;
                toolStripDropDownButton1.Enabled = true;

            }
            else
            {
                toolStripDropDownButton1.Enabled = false;
                toolStripDropDownButton2.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
                int result = controller.InsertPurchases(dateTimePicker7.Text);
                if (result == 0)
                {
                    MessageBox.Show("Nothing have been added, recheck inputs");
                }
                else
                {
                    Purchasesconcs p = new Purchasesconcs();
                    p.Show();

                }
                fillcombo();
                stocklevel();
          
        }

        private void Manager_MouseMove(object sender, MouseEventArgs e)
        {
            stocklevel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int transaction_no = Int32.Parse(comboBox6.SelectedValue.GetHashCode().ToString());
                int result = controller.DeleteOrder(transaction_no);
                if (result == 0)
                {
                    MessageBox.Show("Nothing have been updated, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Order deleted Successfully");
                }
                fillcombo();

        }
        private void ComboBox26_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            label140.Hide();
            textBox12.Hide();
            comboBox8.Hide();
            label29.Hide();
            label141.Hide();
            label142.Hide();
            dateTimePicker6.Hide();
            dateTimePicker4.Hide();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (comboBox26.Text == "All Products")
            {
            }
            if (comboBox26.Text == "Selected product by ingredient")
            {
                label140.Show();
                label140.Text = "Active ing.:";
                textBox12.Show();
                comboBox8.Show();
                label29.Show();
                label29.Text = "Category:";
            }
            if (comboBox26.Text == "Selected product by name")
            {
                label140.Show();
                label140.Text = "Tradename:";
                textBox12.Show();
                comboBox8.Show();
                label29.Show();
                label29.Text = "Category:";
            }
            if (comboBox26.Text == "Purcshases in period")
            {
                label141.Show();
                label142.Show();
                dateTimePicker6.Show();
                dateTimePicker4.Show();
            }
            if (comboBox26.Text == "Sales in period")
            {
                label141.Show();
                label142.Show();
                dateTimePicker6.Show();
                dateTimePicker4.Show();
            }
            if (comboBox26.Text == "All Customers")
            {
                
            }
            if (comboBox26.Text == "Selected customer by tel.")
            {
                label140.Show();
                label140.Text = "Telephone: ";
                textBox12.Show();
            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (comboBox26.Text == "All Products")
            {
                DataTable dt = controller.AllStock() ;
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (comboBox26.Text == "Selected product by ingredient")
            {
                DataTable dt0 = controller.SearchIng(textBox12.Text.ToString(), comboBox8.Text.ToString());
                dataGridView1.DataSource = dt0;
                dataGridView1.Refresh();
            }
            if (comboBox26.Text == "Selected product by name")
            {
                DataTable dt0 = controller.SearchName(textBox12.Text.ToString(), comboBox8.Text.ToString());
                dataGridView1.DataSource = dt0;
                dataGridView1.Refresh();
            }
            if (comboBox26.Text == "Products out of stock")
            {
                DataTable dt0 = controller.OutofStock(); ;
                dataGridView1.DataSource = dt0;
                dataGridView1.Refresh();
            }
            if (comboBox26.Text == "Purcshases in period")
            {
                string date1 = dateTimePicker4.Text;
                string date2 = dateTimePicker6.Text;
                DataTable dt100 = controller.purchasesinperiod(date1, date2);
                dataGridView1.DataSource = dt100;
                dataGridView1.Refresh();
            }
            if (comboBox26.Text == "Sales in period")
            {
                string date1 = dateTimePicker4.Text;
                string date2 = dateTimePicker6.Text;
                DataTable dt100 = controller.salesinperiod(date1, date2);
                dataGridView1.DataSource = dt100;
                dataGridView1.Refresh();
            }
            if (comboBox26.Text == "All Customers")
            {
                DataTable dt = controller.get_all_customers();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (comboBox26.Text == "Selected customer by tel.")
            {
                DataTable dt0 = controller.SearchCustomers(textBox12.Text.ToString());
                dataGridView1.DataSource = dt0;
                dataGridView1.Refresh();
            }
            fillcombo();
        
        }


    }
}
