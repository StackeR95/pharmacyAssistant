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
    public partial class orderrec : Form
    {
        Controller ControllerObj;
        public orderrec(int transno)
        {
            ControllerObj = new Controller();
            InitializeComponent();
            DataTable dt2 = ControllerObj.Orderreceipt(transno);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }

        private void Orderrec_Load(object sender, EventArgs e)
        {

        }
    }
}
