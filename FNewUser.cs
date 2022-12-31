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
    public partial class FNewUser : Form
    {
        public FNewUser()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            Text = "New User";
            cbbPower.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Please input the UserName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPwd1.Text.Trim()))
            {
                MessageBox.Show("Please input the Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                MessageBox.Show("Please input the UserName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Please input the UserName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPwd1.Text.Trim() != txtPwd2.Text.Trim())
            {
                MessageBox.Show("Two Password not Same", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var user = new UserInfo
            {
                Birthday = dtpBirthday.Value,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = txtPwd1.Text,
                Power = cbbPower.Text,
                UserName = txtUserName.Text
            };
            if (User.list.Where(p => p.UserName == txtUserName.Text.Trim()).Any())
            {
                MessageBox.Show("User Name already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User.list.Add(user);
            User.SaveToFile("login.txt");

            MessageBox.Show("User Register Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
