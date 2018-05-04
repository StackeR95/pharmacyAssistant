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
            addMedicineCategoryTextField.Visible = false;
            stocklevel();
            activeIngredientTradeNameLabel.Hide();
            textBox12.Hide();
            comboBox8.Hide();
            categoryLabel.Hide();
            label141.Hide();
            label142.Hide();
            dateTimePicker6.Hide();
            dateTimePicker4.Hide();
            toolStripStatusLabel1.Text = "Logged in as: " + username1;
            toolStripStatusLabel2.Text = "            Stock Level: ";
            refreshComboBoxes();
        }
        private void refreshComboBoxes()
        {
            //Refreshing Transaction Number Combo Box
            this.getordersTableAdapter.Fill(this.pharmacyDataSet.getorders);
            deleteOrderTransNumberComboBox.DataSource = this.getordersBindingSource;
            deleteOrderTransNumberComboBox.Refresh();
            //Refreshing deleteCustomerNameComboBox
            this.getcustomersTableAdapter.Fill(this.pharmacyDataSet.getcustomers);
            deleteCustomerNameComboBox.DataSource = this.getcustomersBindingSource;
            deleteCustomerNameComboBox.Refresh();

            //Refrshing editMedicineCategoryComboBox
            this.getMedicinesByCategoryTableAdapter.Fill(this.pharmacyDataSet.getMedicinesByCategory);
            editMedicineCategoryComboBox.DataSource = this.getMedicinesByCategoryBindingSource;
            editMedicineCategoryComboBox.Refresh();

            //Refreshing EditCustomerNameComboBox
            editCustomerNameComboBox.SelectedIndexChanged += new System.EventHandler(editCustomerNameComboBox_SelectedIndexChanged); //edit customer

            //Refreshing Medicine BarCode
            editMedicineBarcodeComboBox.SelectedIndexChanged += new System.EventHandler(editMedicineBarcodeComboBox_SelectedIndexChanged); //edit medicine

            //Refreshing SearchMethods
            searchMethodsComboBox.SelectedIndexChanged += new System.EventHandler(searchMethodsComboBox_SelectedIndexChanged);
        }
        private void editMedicineBarcodeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataTable dt0 = controller.get_all_medicine();
            if (dt0 != null && editMedicineBarcodeComboBox.Text!="")
            {
                DataRow dr = dt0.AsEnumerable().SingleOrDefault(r => r.Field<int>("Code") == Int32.Parse(editMedicineBarcodeComboBox.Text));
                editMedicineTradeNameTextField.Text = dr[3].ToString();
                editMedicineActiveIngredientTextField.Text = dr[1].ToString();
                editMedicineConcentrationTextField.Text = dr[2].ToString();
                editMedicinePriceOfSaleTextField.Text = dr[5].ToString();
                editMedicineCategoryComboBox.Text = dr[4].ToString();
               
            }

        }
        private void editCustomerNameComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataTable dt0 = controller.getCustomerByCode(editCustomerNameComboBox.SelectedIndex+1);
            if(dt0!=null)
            {
                DataRow dr = dt0.AsEnumerable().SingleOrDefault(r => r.Field<int>("cust_code") == editCustomerNameComboBox.SelectedIndex + 1);
                editCustomerAddressTextField.Text = dr[2].ToString();
                editCustomerTelephoneTextField.Text = dr[4].ToString();
                editCustomerCommentsTextField.Text = dr[3].ToString();
            }


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

        private void addNewMedicine_Click(object sender, EventArgs e)
        {
            int i;
            String medicineCategory = "";
            if(addMedicineNewCategoryCheckBox.Checked)
            {
                medicineCategory = addMedicineCategoryTextField.Text;
            }
            else
            {
                medicineCategory = addMedicineCategoryComboBox.SelectedValue.ToString();
            }
            if (int.TryParse(addMedicineBarcodeTextField.Text, out i) && medicineCategory != string.Empty && addMedicineConcectrationTextField.Text.Trim() != string.Empty && addMedicineConcectrationTextField.Text.Trim() != string.Empty && addMedicineActiveIngrdTextField.Text.Trim() != string.Empty && addMedicineTradeNameTextField.Text.Trim() != string.Empty && addMedicineBarcodeTextField.Text.Trim() != string.Empty && addMedicinePriceOfSaleTextField.Text.Trim() != string.Empty)
            {
                int result = controller.InsertMedicine(Int32.Parse(addMedicineBarcodeTextField.Text), addMedicineTradeNameTextField.Text, addMedicineActiveIngrdTextField.Text, addMedicineConcectrationTextField.Text, medicineCategory, float.Parse(addMedicinePriceOfSaleTextField.Text));
                if (result == 0)
                {
                    MessageBox.Show("No Product Added, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Product Added Successfully");
                    addMedicineActiveIngrdTextField.Clear();
                    addMedicineBarcodeTextField.Clear();
                    addMedicineCategoryTextField.Clear();
                    addMedicinePriceOfSaleTextField.Clear();
                    addMedicineTradeNameTextField.Clear();
                    addMedicineConcectrationTextField.Clear();
                }
                refreshComboBoxes();
            }
            else
            {
                MessageBox.Show("One of the fields is wrong or empty. Please re-enter inputs.");
            }

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if (addCustomerNameTextField.Text.Trim() != string.Empty && addCustomerAddressTextField.Text.Trim() != string.Empty && addCustomerTelephoneTextField.Text.Trim() != string.Empty) {
                int result = controller.InsertCustomer(addCustomerNameTextField.Text, addCustomerAddressTextField.Text, addCustomerCommentsTextField.Text, addCustomerTelephoneTextField.Text);
                if (result == 0)
                {
                    MessageBox.Show("No Customer Added, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Customer Added Successfully");
                    addCustomerNameTextField.Clear();
                    addCustomerAddressTextField.Clear();
                    addCustomerCommentsTextField.Clear();
                    addCustomerTelephoneTextField.Clear();
                }
                refreshComboBoxes();
            }
            else
            {
                MessageBox.Show("One of the fields is empty. Please enter inputs.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (editMedicinePriceOfSaleTextField.Text.Trim() != string.Empty && editMedicineConcentrationTextField.Text.Trim() != string.Empty && editMedicineTradeNameTextField.Text.Trim() != string.Empty && editMedicineActiveIngredientTextField.Text.Trim() != string.Empty)
            {
                int result = controller.EditMedicine(Int32.Parse(editMedicineBarcodeComboBox.SelectedValue.GetHashCode().ToString()), editMedicineTradeNameTextField.Text, editMedicineActiveIngredientTextField.Text, editMedicineConcentrationTextField.Text, editMedicineCategoryComboBox.Text, float.Parse(editMedicinePriceOfSaleTextField.Text));
                if (result == 0)
                {
                    MessageBox.Show("No Product Updated, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Product Updated Successfully");
                }
                refreshComboBoxes();
            }
            else
            {
                MessageBox.Show("One of the fields is empty. Please enter inputs.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (editCustomerTelephoneTextField.Text.Trim() != string.Empty && editCustomerAddressTextField.Text.Trim() != string.Empty) {
                int result = controller.EditCustomer(Int32.Parse(editCustomerNameComboBox.SelectedValue.GetHashCode().ToString()), editCustomerNameComboBox.Text, editCustomerAddressTextField.Text, editCustomerCommentsTextField.Text, editCustomerTelephoneTextField.Text);
                if (result == 0)
                {
                    MessageBox.Show("No Customer Updated, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Customer Updated Successfully");
                }
                refreshComboBoxes();
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
            
                int c = Int32.Parse(deleteCustomerNameComboBox.SelectedValue.GetHashCode().ToString());
                int result = controller.DeleteCustomer(c);
                if (result == 0)
                {
                    MessageBox.Show("Nothing have been deleted, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Customer deleted Successfully");
                }
                refreshComboBoxes();
            
          

        }

        private void addNewOrderButton_Click_1(object sender, EventArgs e)
        {
            totalPriceValueTextLabel.Visible = true;
            if (orderQuantityTextField.Text.Trim() == string.Empty)
            {
                MessageBox.Show("One of the fields is empty. Please enter inputs.");
            }
            else
            {
                DataTable dt = controller.stockavailable();
                Double medicinePrice = controller.getMedicinePrice(Int32.Parse(orderChooseMedicineComboBox.SelectedValue.GetHashCode().ToString()));
                Double totalPrice = medicinePrice * Int32.Parse(orderQuantityTextField.Text.ToString());
                int stockcount = (from DataRow dr in dt.Rows
                                  where (int)dr["Code"] == Int32.Parse(orderChooseMedicineComboBox.SelectedValue.GetHashCode().ToString())
                                  select (int)dr["Stock"]).FirstOrDefault();
           
                string[] row = { orderChooseMedicineComboBox.Text, orderChooseMedicineComboBox.SelectedValue.GetHashCode().ToString(), orderQuantityTextField.Text.ToString() ,medicinePrice.ToString(),totalPrice.ToString() };

                if (Int32.Parse(orderQuantityTextField.Text.ToString()) < 1)
                {
                    MessageBox.Show("Invalid Quantity, re-enter quantity.");
                }
                else
                {
                    if (stockcount == 0)
                    {
                        MessageBox.Show("Product is out of stock");
                    }
                    else if (Int32.Parse(orderQuantityTextField.Text) > (stockcount))
                    {
                        MessageBox.Show("Insufficient stock available");
                        orderQuantityTextField.Clear();
                    }
                    else
                    {
                        orderDescriptionGridView.Rows.Add(row);
                        Double currentTotalPrice = Double.Parse(totalPriceValueTextLabel.Text.ToString());
                        currentTotalPrice += totalPrice;
                        totalPriceValueTextLabel.Text = currentTotalPrice.ToString();
                    }
                }
            }

        }

        private void orderNewOrderButton_Click(object sender, EventArgs e)
        {

            if (orderDescriptionGridView.Rows.Count > 0)
            {

                int newOrderNumber = controller.insertorders();
                int transno = controller.lastorderno();
                for (int i = 0; i < orderDescriptionGridView.Rows.Count; i++)
                {
                    controller.insertordercon(Int32.Parse(orderDescriptionGridView.Rows[i].Cells[2].Value.ToString()), Int32.Parse(orderDescriptionGridView.Rows[i].Cells[1].Value.ToString()), transno);

                }
                orderDescriptionGridView.Rows.Clear();
                stocklevel();
                refreshComboBoxes();
                orderQuantityTextField.Clear();
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
            
                int result = controller.InsertPurchases(addPurchaseDateTimePicker.Text);
                if (result == 0)
                {
                    MessageBox.Show("Nothing have been added, recheck inputs");
                }
                else
                {
                    Purchasesconcs p = new Purchasesconcs();
                    p.Show();

                }
                refreshComboBoxes();
                stocklevel();
          
        }

        private void Manager_MouseMove(object sender, MouseEventArgs e)
        {
            stocklevel();
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            int transaction_no = Int32.Parse(deleteOrderTransNumberComboBox.SelectedValue.GetHashCode().ToString());
                int result = controller.DeleteOrder(transaction_no);
                if (result == 0)
                {
                    MessageBox.Show("Nothing have been updated, recheck inputs");
                }
                else
                {
                    MessageBox.Show("Order deleted Successfully");
                }
                refreshComboBoxes();

        }
        private void searchMethodsComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            activeIngredientTradeNameLabel.Hide();
            textBox12.Hide();
            comboBox8.Hide();
            categoryLabel.Hide();
            label141.Hide();
            label142.Hide();
            dateTimePicker6.Hide();
            dateTimePicker4.Hide();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (searchMethodsComboBox.Text == "All Medicine ")
            {
            }
            if (searchMethodsComboBox.Text == "Selected Medicine by ingredient")
            {
                activeIngredientTradeNameLabel.Show();
                activeIngredientTradeNameLabel.Text = "Active ing.:";
                textBox12.Show();
                comboBox8.Show();
                categoryLabel.Show();
                categoryLabel.Text = "Category:";
            }
            if (searchMethodsComboBox.Text == "Selected Medicine by name")
            {
                activeIngredientTradeNameLabel.Show();
                activeIngredientTradeNameLabel.Text = "Tradename:";
                textBox12.Show();
                comboBox8.Show();
                categoryLabel.Show();
                categoryLabel.Text = "Category:";
            }
            if (searchMethodsComboBox.Text == "Purcshases in period")
            {
                label141.Show();
                label142.Show();
                dateTimePicker6.Show();
                dateTimePicker4.Show();
            }
            if (searchMethodsComboBox.Text == "Sales in period")
            {
                label141.Show();
                label142.Show();
                dateTimePicker6.Show();
                dateTimePicker4.Show();
            }
            if (searchMethodsComboBox.Text == "All Customers")
            {
                
            }
            if (searchMethodsComboBox.Text == "Selected customer by tel.")
            {
                activeIngredientTradeNameLabel.Show();
                activeIngredientTradeNameLabel.Text = "Telephone: ";
                textBox12.Show();
            }

        }

        private void viewButton_Click(object sender, EventArgs e)
        {

            if (searchMethodsComboBox.Text == "All Medicine ")
            {
                DataTable dt = controller.AllStock() ;
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (searchMethodsComboBox.Text == "Selected Medicine by ingredient")
            {
                DataTable dt0 = controller.SearchIng(textBox12.Text.ToString(), comboBox8.Text.ToString());
                dataGridView1.DataSource = dt0;
                dataGridView1.Refresh();
            }
            if (searchMethodsComboBox.Text == "Selected Medicine by name")
            {
                DataTable dt0 = controller.SearchName(textBox12.Text.ToString(), comboBox8.Text.ToString());
                dataGridView1.DataSource = dt0;
                dataGridView1.Refresh();
            }
            if (searchMethodsComboBox.Text == "Medicine out of stock")
            {
                DataTable dt0 = controller.OutofStock(); ;
                dataGridView1.DataSource = dt0;
                dataGridView1.Refresh();
            }
            if (searchMethodsComboBox.Text == "Purcshases in period")
            {
                string date1 = dateTimePicker4.Text;
                string date2 = dateTimePicker6.Text;
                DataTable dt100 = controller.purchasesinperiod(date1, date2);
                dataGridView1.DataSource = dt100;
                dataGridView1.Refresh();
            }
            if (searchMethodsComboBox.Text == "Sales in period")
            {
                string date1 = dateTimePicker4.Text;
                string date2 = dateTimePicker6.Text;
                DataTable dt100 = controller.salesinperiod(date1, date2);
                dataGridView1.DataSource = dt100;
                dataGridView1.Refresh();
            }
            if (searchMethodsComboBox.Text == "All Customers")
            {
                DataTable dt = controller.get_all_customers();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (searchMethodsComboBox.Text == "Selected customer by tel.")
            {
                DataTable dt0 = controller.SearchCustomers(textBox12.Text.ToString());
                dataGridView1.DataSource = dt0;
                dataGridView1.Refresh();
            }
            refreshComboBoxes();
        
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.getorders' table. You can move, or remove it, as needed.
            this.getordersTableAdapter.Fill(this.pharmacyDataSet.getorders);
            // TODO: This line of code loads data into the 'pharmacyDataSet.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.pharmacyDataSet.stock);
            // TODO: This line of code loads data into the 'pharmacyDataSet.getcustomers' table. You can move, or remove it, as needed.
            this.getcustomersTableAdapter.Fill(this.pharmacyDataSet.getcustomers);
            // TODO: This line of code loads data into the 'pharmacyDataSet.getMedicinesByCategory' table. You can move, or remove it, as needed.
            this.getMedicinesByCategoryTableAdapter.Fill(this.pharmacyDataSet.getMedicinesByCategory);
            // TODO: This line of code loads data into the 'pharmacyDataSet.getMedicinesBarCode' table. You can move, or remove it, as needed.
            this.getMedicinesBarCodeTableAdapter.Fill(this.pharmacyDataSet.getMedicinesBarCode);

        }

        private void addMedicineNewCategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(addMedicineNewCategoryCheckBox.Checked)
            {
                addMedicineCategoryComboBox.Visible = false;
                addMedicineCategoryTextField.Visible = true;
            }
            else
            {
                addMedicineCategoryComboBox.Visible = true;
                addMedicineCategoryTextField.Visible = false;
            }
        }



    }
}
