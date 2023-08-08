namespace Quiz_System
{
    partial class StartQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartQuizForm));
            this.lblStartQuizFormHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sWEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuizSubject = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartments = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.panelDateAndTime = new System.Windows.Forms.Panel();
            this.lblShowUTCDateTime = new System.Windows.Forms.Label();
            this.lblUTCDateTime = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timerDateTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblReadyMessage = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelDateAndTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartQuizFormHeader
            // 
            this.lblStartQuizFormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartQuizFormHeader.AutoSize = true;
            this.lblStartQuizFormHeader.Font = new System.Drawing.Font("Simple Bold Jut Out", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStartQuizFormHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStartQuizFormHeader.Location = new System.Drawing.Point(528, 18);
            this.lblStartQuizFormHeader.Name = "lblStartQuizFormHeader";
            this.lblStartQuizFormHeader.Size = new System.Drawing.Size(119, 29);
            this.lblStartQuizFormHeader.TabIndex = 0;
            this.lblStartQuizFormHeader.Text = "Quiz Master";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(157)))), ((int)(((byte)(231)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(136, 64);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSToolStripMenuItem,
            this.sWEToolStripMenuItem,
            this.cISToolStripMenuItem,
            this.cYSToolStripMenuItem,
            this.bITToolStripMenuItem,
            this.aIDSToolStripMenuItem});
            this.departmentsToolStripMenuItem.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.departmentsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.departmentsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // cSToolStripMenuItem
            // 
            this.cSToolStripMenuItem.Font = new System.Drawing.Font("Simple Bold Jut Out", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cSToolStripMenuItem.Name = "cSToolStripMenuItem";
            this.cSToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.cSToolStripMenuItem.Text = "CS";
            // 
            // sWEToolStripMenuItem
            // 
            this.sWEToolStripMenuItem.Font = new System.Drawing.Font("Simple Bold Jut Out", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sWEToolStripMenuItem.Name = "sWEToolStripMenuItem";
            this.sWEToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.sWEToolStripMenuItem.Text = "SWE";
            // 
            // cISToolStripMenuItem
            // 
            this.cISToolStripMenuItem.Font = new System.Drawing.Font("Simple Bold Jut Out", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cISToolStripMenuItem.Name = "cISToolStripMenuItem";
            this.cISToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.cISToolStripMenuItem.Text = "CIS";
            // 
            // cYSToolStripMenuItem
            // 
            this.cYSToolStripMenuItem.Font = new System.Drawing.Font("Simple Bold Jut Out", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cYSToolStripMenuItem.Name = "cYSToolStripMenuItem";
            this.cYSToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.cYSToolStripMenuItem.Text = "CYS";
            // 
            // bITToolStripMenuItem
            // 
            this.bITToolStripMenuItem.Font = new System.Drawing.Font("Simple Bold Jut Out", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bITToolStripMenuItem.Name = "bITToolStripMenuItem";
            this.bITToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.bITToolStripMenuItem.Text = "BIT";
            // 
            // aIDSToolStripMenuItem
            // 
            this.aIDSToolStripMenuItem.Font = new System.Drawing.Font("Simple Bold Jut Out", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aIDSToolStripMenuItem.Name = "aIDSToolStripMenuItem";
            this.aIDSToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.aIDSToolStripMenuItem.Text = "AI";
            // 
            // lblQuizSubject
            // 
            this.lblQuizSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuizSubject.AutoSize = true;
            this.lblQuizSubject.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblQuizSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuizSubject.Location = new System.Drawing.Point(230, 184);
            this.lblQuizSubject.Name = "lblQuizSubject";
            this.lblQuizSubject.Size = new System.Drawing.Size(84, 25);
            this.lblQuizSubject.TabIndex = 2;
            this.lblQuizSubject.Text = "Subject :";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(344, 183);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(269, 24);
            this.comboBoxSubject.TabIndex = 1;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            this.comboBoxSubject.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // comboBoxDepartments
            // 
            this.comboBoxDepartments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartments.FormattingEnabled = true;
            this.comboBoxDepartments.Location = new System.Drawing.Point(344, 109);
            this.comboBoxDepartments.Name = "comboBoxDepartments";
            this.comboBoxDepartments.Size = new System.Drawing.Size(269, 24);
            this.comboBoxDepartments.TabIndex = 0;
            this.comboBoxDepartments.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDepartment.Location = new System.Drawing.Point(209, 109);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(118, 25);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department :";
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(668, 93);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(599, 85);
            this.lblWelcomeMessage.TabIndex = 8;
            this.lblWelcomeMessage.Text = "Remember, every question is an opportunity to learn something new,\r\nso don\'t hesi" +
    "tate to take up the challenge. Stay curious, stay engaged,\r\nand most importantly" +
    ", have fun!\r\n";
            // 
            // panelDateAndTime
            // 
            this.panelDateAndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDateAndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDateAndTime.Controls.Add(this.lblShowUTCDateTime);
            this.panelDateAndTime.Controls.Add(this.lblUTCDateTime);
            this.panelDateAndTime.Controls.Add(this.lblShowTime);
            this.panelDateAndTime.Controls.Add(this.lblTime);
            this.panelDateAndTime.Controls.Add(this.lblShowDate);
            this.panelDateAndTime.Controls.Add(this.lblDate);
            this.panelDateAndTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDateAndTime.Location = new System.Drawing.Point(750, 242);
            this.panelDateAndTime.Name = "panelDateAndTime";
            this.panelDateAndTime.Size = new System.Drawing.Size(480, 207);
            this.panelDateAndTime.TabIndex = 9;
            // 
            // lblShowUTCDateTime
            // 
            this.lblShowUTCDateTime.AutoSize = true;
            this.lblShowUTCDateTime.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowUTCDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShowUTCDateTime.Location = new System.Drawing.Point(140, 145);
            this.lblShowUTCDateTime.Name = "lblShowUTCDateTime";
            this.lblShowUTCDateTime.Size = new System.Drawing.Size(0, 26);
            this.lblShowUTCDateTime.TabIndex = 12;
            // 
            // lblUTCDateTime
            // 
            this.lblUTCDateTime.AutoSize = true;
            this.lblUTCDateTime.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUTCDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUTCDateTime.Location = new System.Drawing.Point(40, 145);
            this.lblUTCDateTime.Name = "lblUTCDateTime";
            this.lblUTCDateTime.Size = new System.Drawing.Size(60, 26);
            this.lblUTCDateTime.TabIndex = 11;
            this.lblUTCDateTime.Text = "UTC :";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShowTime.Location = new System.Drawing.Point(135, 86);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(0, 26);
            this.lblShowTime.TabIndex = 10;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(35, 83);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 26);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time :";
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShowDate.Location = new System.Drawing.Point(135, 21);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(0, 26);
            this.lblShowDate.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(35, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 26);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date :";
            // 
            // timerDateTimeUpdate
            // 
            this.timerDateTimeUpdate.Interval = 60000;
            this.timerDateTimeUpdate.Tick += new System.EventHandler(this.timerDateTimeUpdate_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(254, 502);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(234, 38);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Location = new System.Drawing.Point(585, 502);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(234, 38);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblReadyMessage
            // 
            this.lblReadyMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReadyMessage.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyMessage.ForeColor = System.Drawing.Color.Green;
            this.lblReadyMessage.Location = new System.Drawing.Point(259, 262);
            this.lblReadyMessage.Name = "lblReadyMessage";
            this.lblReadyMessage.Size = new System.Drawing.Size(388, 164);
            this.lblReadyMessage.TabIndex = 12;
            this.lblReadyMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Location = new System.Drawing.Point(896, 502);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(234, 38);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // StartQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(157)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1313, 634);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblReadyMessage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelDateAndTime);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.comboBoxDepartments);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.lblQuizSubject);
            this.Controls.Add(this.lblStartQuizFormHeader);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartQuizForm";
            this.Text = "Choose Your Quiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartQuizForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDateAndTime.ResumeLayout(false);
            this.panelDateAndTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartQuizFormHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.Label lblQuizSubject;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxDepartments;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Panel panelDateAndTime;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblShowUTCDateTime;
        private System.Windows.Forms.Label lblUTCDateTime;
        private System.Windows.Forms.Timer timerDateTimeUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem cSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sWEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cYSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIDSToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblReadyMessage;
        private System.Windows.Forms.Button btnLogout;
    }
}

