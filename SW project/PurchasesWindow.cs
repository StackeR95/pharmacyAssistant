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
    public partial class PurchasesWindow : Form
    {
        Controller ControllerObj;
        public PurchasesWindow()
        {
            ControllerObj = Controller.getControllerInstance();
            InitializeComponent();
        }

        private void addPurchaseButton_Click(object sender, EventArgs e) // add Purchase event click handler
        {
            int transno = ControllerObj.getlasttransnopur();

            if (quantityNumericInput.Value != 0) //Input validation
            {
                int result = ControllerObj.InsertPurchasesContent(transno, Int32.Parse(comboBox1.SelectedValue.ToString()), Int32.Parse(quantityNumericInput.Value.ToString()));
                if (result == 0)
                {
                    MessageBox.Show("Nothing have been added, recheck inputs", "Invalud Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Purchase product Successfully added","Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                quantityNumericInput.Value = 0;
            }
            else MessageBox.Show("Can't Add Purchase With Quantity Zero ","Invalud Input",MessageBoxButtons.OK,MessageBoxIcon.Error);

     
        }

        private void Purchasesconcs_Load(object sender, EventArgs e) // Function for the purchases data set
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.getallmedicine' table. You can move, or remove it, as needed.
            this.getallmedicineTableAdapter.Fill(this.pharmacyDataSet.getallmedicine);

        }


    }
}
