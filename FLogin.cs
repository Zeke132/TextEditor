using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            Text = "User Login";
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            txtUserName.Text = "user2";
            txtPwd1.Text = "321password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( txtUserName.Text.Trim()))
            {
                MessageBox.Show("Please input the UserName","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPwd1.Text.Trim()))
            {
                MessageBox.Show("Please input the Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (User.ValidUser(txtUserName.Text,txtPwd1.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("unknown username or incorrect password", "login failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            var f = new FNewUser();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
