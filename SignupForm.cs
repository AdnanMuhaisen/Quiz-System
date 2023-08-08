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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            clsUser NewUser = new clsUser();
            NewUser.UserNameOrEmail = textBoxEmailorUserName.Text;
            NewUser.Password = textBoxPassword.Text;
            if (NewUser.Save())
            {
                MessageBox.Show("The User Added Successfully :)", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("This User Already Exist , Enter Another One !", "Error Message", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
            {
                errorProvider1.SetError(((TextBox)sender), "Required !");
                ((TextBox)sender).Focus();
            }
            else
                errorProvider1.SetError(((TextBox)sender), string.Empty);
        }

        private void textBoxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (!textBoxConfirmPassword.Text.Equals(textBoxPassword.Text))
            {
                errorProvider1.SetError(((TextBox)sender), "Write The Correct Password !");
                ((TextBox)sender).Focus();
            }
            else
                errorProvider1.SetError(((TextBox)sender), string.Empty);
        }



    }
}
