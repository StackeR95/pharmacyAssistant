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
    public partial class OrderReceipt : Form // Class to show the order receipt just a view
    {
        Controller ControllerObj;
        public OrderReceipt(int transno) 
        {
            ControllerObj = Controller.getControllerInstance();
            InitializeComponent();
            DataTable dt2 = ControllerObj.Orderreceipt(transno);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }

    }
}
