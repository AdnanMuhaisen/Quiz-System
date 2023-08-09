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
    public partial class LoginForm : Form
    {
        private SignupForm _SignUp;
        private StartQuizForm _StartQuizForm;
        private ForgetPasswordForm _ForgetPasswordForm;

        public LoginForm()
        {
            InitializeComponent();
            _SignUp = new SignupForm();
            _ForgetPasswordForm = new ForgetPasswordForm();
        }

        private void btnLoginNow_Click(object sender, EventArgs e)
        {
            clsUser User = new clsUser(textBoxEmailorUserName.Text, textBoxPassword.Text);
            if (User.VerifyPassword())
            {
                lblLoginMessage.Text = string.Empty;
                _StartQuizForm = new StartQuizForm(User);
                this.Hide();
                if (_StartQuizForm.ShowDialog() == DialogResult.Cancel)
                {
                    _ResetTheForm();
                    User = null;
                    this.Show();
                }
            }
            else
            {
                lblLoginMessage.Text = "Invalid Username / Password !";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxEmailorUserName.Focus();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            lblLoginMessage.Text = string.Empty;
            if (((TextBox)sender).Text == string.Empty)
            {
                errorProvider1.SetError(((TextBox)sender), "Required !");
                ((TextBox)sender).Focus();
            }
            else
                errorProvider1.SetError(((TextBox)sender), string.Empty);
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            if (_SignUp.ShowDialog() == DialogResult.Cancel)
            {
                _ResetTheForm();
                this.Show();
            }
        }

        private void _ResetTheForm()
        {
            textBoxEmailorUserName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxEmailorUserName.Focus();
            lblLoginMessage.Text = string.Empty;
        }

        private void linkLabelForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            if (_ForgetPasswordForm.ShowDialog() == DialogResult.Cancel)
            {
                this._ResetTheForm();
                this.Show();
            }
        }
    }
}
