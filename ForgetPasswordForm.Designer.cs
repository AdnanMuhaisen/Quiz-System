namespace Quiz_System
{
    partial class ForgetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            this.lblEnterUserNameOrEmail = new System.Windows.Forms.Label();
            this.textBoxEmailOrUserName = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterUserNameOrEmail
            // 
            this.lblEnterUserNameOrEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnterUserNameOrEmail.AutoSize = true;
            this.lblEnterUserNameOrEmail.Font = new System.Drawing.Font("Simple Bold Jut Out", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEnterUserNameOrEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnterUserNameOrEmail.Location = new System.Drawing.Point(129, 61);
            this.lblEnterUserNameOrEmail.Name = "lblEnterUserNameOrEmail";
            this.lblEnterUserNameOrEmail.Size = new System.Drawing.Size(173, 29);
            this.lblEnterUserNameOrEmail.TabIndex = 1;
            this.lblEnterUserNameOrEmail.Text = "Username /Email :";
            // 
            // textBoxEmailOrUserName
            // 
            this.textBoxEmailOrUserName.Location = new System.Drawing.Point(414, 55);
            this.textBoxEmailOrUserName.MinimumSize = new System.Drawing.Size(4, 35);
            this.textBoxEmailOrUserName.Name = "textBoxEmailOrUserName";
            this.textBoxEmailOrUserName.Size = new System.Drawing.Size(445, 24);
            this.textBoxEmailOrUserName.TabIndex = 2;
            this.textBoxEmailOrUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEmailOrUserName_KeyDown);
            this.textBoxEmailOrUserName.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(414, 155);
            this.textBoxNewPassword.MinimumSize = new System.Drawing.Size(4, 35);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(445, 24);
            this.textBoxNewPassword.TabIndex = 4;
            this.textBoxNewPassword.Visible = false;
            this.textBoxNewPassword.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Simple Bold Jut Out", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewPassword.Location = new System.Drawing.Point(129, 161);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(154, 29);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "New Password :";
            this.lblNewPassword.Visible = false;
            // 
            // textBoxConfirmNewPassword
            // 
            this.textBoxConfirmNewPassword.Location = new System.Drawing.Point(414, 251);
            this.textBoxConfirmNewPassword.MinimumSize = new System.Drawing.Size(4, 35);
            this.textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            this.textBoxConfirmNewPassword.PasswordChar = '*';
            this.textBoxConfirmNewPassword.Size = new System.Drawing.Size(445, 24);
            this.textBoxConfirmNewPassword.TabIndex = 6;
            this.textBoxConfirmNewPassword.Visible = false;
            this.textBoxConfirmNewPassword.TextChanged += new System.EventHandler(this.textBoxConfirmNewPassword_TextChanged);
            this.textBoxConfirmNewPassword.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Simple Bold Jut Out", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblConfirmNewPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(129, 257);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(227, 29);
            this.lblConfirmNewPassword.TabIndex = 5;
            this.lblConfirmNewPassword.Text = "Confirm New Password :";
            this.lblConfirmNewPassword.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(177, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(226, 40);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(596, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(226, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(157)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1102, 533);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxConfirmNewPassword);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.textBoxEmailOrUserName);
            this.Controls.Add(this.lblEnterUserNameOrEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgetPasswordForm";
            this.Text = "Get Your Password";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterUserNameOrEmail;
        private System.Windows.Forms.TextBox textBoxEmailOrUserName;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}