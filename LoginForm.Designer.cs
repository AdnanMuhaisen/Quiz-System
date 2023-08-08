namespace Quiz_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginMessage = new System.Windows.Forms.Label();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.btnLoginNow = new System.Windows.Forms.Button();
            this.linkLabelForgetPassword = new System.Windows.Forms.LinkLabel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxEmailorUserName = new System.Windows.Forms.TextBox();
            this.lblEmailorUserName = new System.Windows.Forms.Label();
            this.lblLoginIntoYourAccount = new System.Windows.Forms.Label();
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.lblLoginMessage);
            this.panel1.Controls.Add(this.linkLabelRegister);
            this.panel1.Controls.Add(this.btnLoginNow);
            this.panel1.Controls.Add(this.linkLabelForgetPassword);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.textBoxEmailorUserName);
            this.panel1.Controls.Add(this.lblEmailorUserName);
            this.panel1.Controls.Add(this.lblLoginIntoYourAccount);
            this.panel1.Controls.Add(this.lblWelcomeBack);
            this.panel1.Location = new System.Drawing.Point(279, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 535);
            this.panel1.TabIndex = 3;
            // 
            // lblLoginMessage
            // 
            this.lblLoginMessage.AutoSize = true;
            this.lblLoginMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginMessage.ForeColor = System.Drawing.Color.Red;
            this.lblLoginMessage.Location = new System.Drawing.Point(163, 304);
            this.lblLoginMessage.Name = "lblLoginMessage";
            this.lblLoginMessage.Size = new System.Drawing.Size(0, 20);
            this.lblLoginMessage.TabIndex = 5;
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLabelRegister.LinkArea = new System.Windows.Forms.LinkArea(21, 33);
            this.linkLabelRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelRegister.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabelRegister.Location = new System.Drawing.Point(18, 454);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(217, 20);
            this.linkLabelRegister.TabIndex = 4;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Not Registered Yet ? Register -->";
            this.linkLabelRegister.UseCompatibleTextRendering = true;
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // btnLoginNow
            // 
            this.btnLoginNow.BackColor = System.Drawing.Color.White;
            this.btnLoginNow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(67)))), ((int)(((byte)(250)))));
            this.btnLoginNow.FlatAppearance.BorderSize = 0;
            this.btnLoginNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginNow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginNow.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoginNow.Location = new System.Drawing.Point(167, 355);
            this.btnLoginNow.Name = "btnLoginNow";
            this.btnLoginNow.Size = new System.Drawing.Size(560, 45);
            this.btnLoginNow.TabIndex = 2;
            this.btnLoginNow.Text = "Login Now";
            this.btnLoginNow.UseVisualStyleBackColor = false;
            this.btnLoginNow.Click += new System.EventHandler(this.btnLoginNow_Click);
            // 
            // linkLabelForgetPassword
            // 
            this.linkLabelForgetPassword.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabelForgetPassword.AutoSize = true;
            this.linkLabelForgetPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelForgetPassword.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabelForgetPassword.Location = new System.Drawing.Point(669, 224);
            this.linkLabelForgetPassword.Name = "linkLabelForgetPassword";
            this.linkLabelForgetPassword.Size = new System.Drawing.Size(127, 15);
            this.linkLabelForgetPassword.TabIndex = 3;
            this.linkLabelForgetPassword.TabStop = true;
            this.linkLabelForgetPassword.Text = "Forget Password ?";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(210)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPassword.Location = new System.Drawing.Point(167, 257);
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(560, 35);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(560, 25);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(108, 219);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // textBoxEmailorUserName
            // 
            this.textBoxEmailorUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(210)))));
            this.textBoxEmailorUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmailorUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailorUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxEmailorUserName.Location = new System.Drawing.Point(167, 155);
            this.textBoxEmailorUserName.MinimumSize = new System.Drawing.Size(560, 35);
            this.textBoxEmailorUserName.Name = "textBoxEmailorUserName";
            this.textBoxEmailorUserName.Size = new System.Drawing.Size(560, 25);
            this.textBoxEmailorUserName.TabIndex = 0;
            this.textBoxEmailorUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmailorUserName.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lblEmailorUserName
            // 
            this.lblEmailorUserName.AutoSize = true;
            this.lblEmailorUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailorUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmailorUserName.Location = new System.Drawing.Point(108, 117);
            this.lblEmailorUserName.Name = "lblEmailorUserName";
            this.lblEmailorUserName.Size = new System.Drawing.Size(169, 20);
            this.lblEmailorUserName.TabIndex = 2;
            this.lblEmailorUserName.Text = "E-Mail or Username";
            // 
            // lblLoginIntoYourAccount
            // 
            this.lblLoginIntoYourAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoginIntoYourAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginIntoYourAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoginIntoYourAccount.Location = new System.Drawing.Point(0, 37);
            this.lblLoginIntoYourAccount.Name = "lblLoginIntoYourAccount";
            this.lblLoginIntoYourAccount.Size = new System.Drawing.Size(892, 41);
            this.lblLoginIntoYourAccount.TabIndex = 1;
            this.lblLoginIntoYourAccount.Text = "Login Into Your Account";
            this.lblLoginIntoYourAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcomeBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBack.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWelcomeBack.Location = new System.Drawing.Point(0, 0);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.Size = new System.Drawing.Size(892, 37);
            this.lblWelcomeBack.TabIndex = 0;
            this.lblWelcomeBack.Text = "Welcome Back";
            this.lblWelcomeBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1397, 88);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Quiz Master";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(157)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1397, 768);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.Button btnLoginNow;
        private System.Windows.Forms.LinkLabel linkLabelForgetPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxEmailorUserName;
        private System.Windows.Forms.Label lblEmailorUserName;
        private System.Windows.Forms.Label lblLoginIntoYourAccount;
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblLoginMessage;
    }
}