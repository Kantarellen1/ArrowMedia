using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="123" && txtPassword.Text=="123")
            {
                new Interface().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The username or password was incorrect, try again");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }
    }
}
