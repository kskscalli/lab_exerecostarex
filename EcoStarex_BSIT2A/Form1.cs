using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Starex_BSIT2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // If statement

            if (tbUsername.Text.Trim().Equals(""))
            {
                tbUsername.Focus();
                MessageBox.Show("Please input Username");
            }
            else if (tbPassword.Text.Trim().Equals(""))
            {
                tbPassword.Focus();
                MessageBox.Show("Please input Password");
            }
            else
            {
                frmHome frm = new frmHome();
                frm.Show();
                this.Hide();
            }
        }
    }
}
