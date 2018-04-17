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
    public partial class Login : Form
    {
        Controller controller;
        public Login()
        {
            controller = new Controller();
            InitializeComponent();
        }


        private void loginButton_click(object sender, EventArgs e)
        {
            int flag = 0;
            flag = controller.CheckAccountPassword(userIDtextBox.Text, passwordTextbox.Text);
            if (flag == 1)
            {
                Manager M;
                M = new Manager(userIDtextBox.Text, controller);
                userIDtextBox.Clear();
                passwordTextbox.Clear();
                M.Show();

            }
            else
            { MessageBox.Show("Wrong Username or Password, renter correct information"); }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }



    }
}
