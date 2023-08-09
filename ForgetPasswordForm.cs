using Quiz_System___Middle_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_System
{
    public partial class ForgetPasswordForm : Form
    {
        string UsernameOrEmail = default, Password = default;

        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_CheckFormDataForSaveNewPassword())
            {
                clsUser TargetUser = clsUser.FindUser(this.UsernameOrEmail);

                // Set New Password
                TargetUser.Password = Password;
                if (TargetUser.Save())
                {
                    MessageBox.Show("Saved Successfully ", "User information updated",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("An Error Occuer When Saving This User !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Enter All Required Data !", "Missing Data",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
            {
                errorProvider1.SetError(((TextBox)sender), "Required !");
                ((TextBox)sender).Focus();
            }
            else
            {
                errorProvider1.SetError(((TextBox)sender), string.Empty);
            }
        }

        private void _IsForgetPasswordFormControlsVisible(bool Visible)
        {
            lblNewPassword.Visible = lblConfirmNewPassword.Visible = textBoxNewPassword.Visible = textBoxConfirmNewPassword.Visible =
                btnOK.Visible = Visible;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _CheckFormDataForSaveNewPassword()
        {
            // This Method Will Fill The Form Data

            if( (textBoxEmailOrUserName.Text != string.Empty) && (textBoxNewPassword.Text != string.Empty) &&
                (textBoxConfirmNewPassword.Text != string.Empty))
            {
                this.UsernameOrEmail = textBoxEmailOrUserName.Text;
                this.Password= textBoxConfirmNewPassword.Text;
                return true;
            }
            return false;
        }

        private void textBoxEmailOrUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (clsUser.IsUserExist(textBoxEmailOrUserName.Text))
                {
                    _IsForgetPasswordFormControlsVisible(true);
                }
                else
                    MessageBox.Show("The Username Or Email You Entered Does Not Exist", "Invalid Username Or Email",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text != null)
            {
                if (((TextBox)sender).Text.Equals(textBoxNewPassword.Text))
                {
                    errorProvider1.SetError(((TextBox)sender), "Enter The Same Password !");
                    ((TextBox)sender).Focus();
                }
                else
                    errorProvider1.SetError(((TextBox)sender), string.Empty); 
            }
        }
    }
}
