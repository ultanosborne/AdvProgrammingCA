using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvProgrammingCA
{
    public partial class StudentDB : Form
    {
        LoginForm lform;

        public StudentDB()
        {
            InitializeComponent();
        }

        public StudentDB(LoginForm lf)
        {
            InitializeComponent();
            lform = lf;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            lform.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblView_Click(object sender, EventArgs e)
        {
            deselect();
            lblView.ForeColor = Color.DarkBlue;
            tabControl1.SelectedIndex = 0;
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            deselect();
            lblNew.ForeColor = Color.DarkBlue;
            tabControl1.SelectedIndex = 1;
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            deselect();
            lblEdit.ForeColor = Color.DarkBlue;
            tabControl1.SelectedIndex = 2;
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            deselect();
            lblDelete.ForeColor = Color.DarkBlue;
            tabControl1.SelectedIndex = 3;
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            deselect();
            lblHistory.ForeColor = Color.DarkBlue;
            tabControl1.SelectedIndex = 4;
        }





        private void deselect()
        {
            lblView.ForeColor = Color.LightSteelBlue;
            lblNew.ForeColor = Color.LightSteelBlue;
            lblEdit.ForeColor = Color.LightSteelBlue;
            lblDelete.ForeColor = Color.LightSteelBlue;
            lblHistory.ForeColor = Color.LightSteelBlue;
        }
    }
}
