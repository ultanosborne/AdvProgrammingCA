using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvProgrammingCA.DataHandling;

namespace AdvProgrammingCA
{
    public partial class LoginForm : Form
    {

        Login login;
        public LoginForm()
        {
            InitializeComponent();
            lblFail.Visible = false;
            login = new Login();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (login.check(tbUsername.Text, tbPassword.Text)) 
            {
                StudentDB sdb = new StudentDB(this);
                this.Hide();
                sdb.Show();
                allClear(); //this is to have the username and pw to not be available after logout
            }
            else
            {
                lblFail.Visible = true;
                allClear();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void allClear()
        {
            tbUsername.Clear();
            tbPassword.Clear();
        }
    }
}
