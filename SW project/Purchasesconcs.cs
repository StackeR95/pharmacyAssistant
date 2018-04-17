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
    public partial class Purchasesconcs : Form
    {
        Controller ControllerObj;
        public Purchasesconcs()
        {
            ControllerObj = new Controller();
            InitializeComponent();
            DataTable dt = ControllerObj.get_all_medicine();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Code";
            comboBox1.ValueMember = "Code";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int transno = ControllerObj.getlasttransnopur();
            int result = ControllerObj.InsertPurchasesContent(transno, Int32.Parse(comboBox1.SelectedValue.ToString()), Int32.Parse(textBox1.Text));
            if (result == 0)
            {
                MessageBox.Show("Nothing have been added, recheck inputs");
            }
            else
            {
                MessageBox.Show("Purchase product Successfully added");
            }
            textBox1.Clear();
        }
    }
}
