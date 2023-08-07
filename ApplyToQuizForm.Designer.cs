namespace Quiz_System
{
    partial class ApplyToQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyToQuizForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblShowSubject = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblShowQuizDepartment = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.radioButtonChoice4 = new System.Windows.Forms.RadioButton();
            this.radioButtonChoice3 = new System.Windows.Forms.RadioButton();
            this.radioButtonChoice2 = new System.Windows.Forms.RadioButton();
            this.radioButtonChoice1 = new System.Windows.Forms.RadioButton();
            this.lblShowQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(210)))));
            this.panelHeader.Controls.Add(this.lblShowSubject);
            this.panelHeader.Controls.Add(this.lblSubject);
            this.panelHeader.Controls.Add(this.lblShowQuizDepartment);
            this.panelHeader.Controls.Add(this.lblDepartment);
            this.panelHeader.Controls.Add(this.lblShowTime);
            this.panelHeader.Controls.Add(this.lblTime);
            this.panelHeader.Controls.Add(this.lblShowDate);
            this.panelHeader.Controls.Add(this.lblDate);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1394, 161);
            this.panelHeader.TabIndex = 0;
            // 
            // lblShowSubject
            // 
            this.lblShowSubject.AutoSize = true;
            this.lblShowSubject.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowSubject.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblShowSubject.Location = new System.Drawing.Point(614, 88);
            this.lblShowSubject.Name = "lblShowSubject";
            this.lblShowSubject.Size = new System.Drawing.Size(0, 25);
            this.lblShowSubject.TabIndex = 7;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSubject.Location = new System.Drawing.Point(490, 88);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(85, 25);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Subject :";
            // 
            // lblShowQuizDepartment
            // 
            this.lblShowQuizDepartment.AutoSize = true;
            this.lblShowQuizDepartment.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowQuizDepartment.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblShowQuizDepartment.Location = new System.Drawing.Point(614, 27);
            this.lblShowQuizDepartment.Name = "lblShowQuizDepartment";
            this.lblShowQuizDepartment.Size = new System.Drawing.Size(0, 25);
            this.lblShowQuizDepartment.TabIndex = 5;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDepartment.Location = new System.Drawing.Point(490, 27);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(119, 25);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department :";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblShowTime.Location = new System.Drawing.Point(111, 88);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(0, 25);
            this.lblShowTime.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTime.Location = new System.Drawing.Point(28, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 25);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time :";
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblShowDate.Location = new System.Drawing.Point(111, 27);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(0, 25);
            this.lblShowDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDate.Location = new System.Drawing.Point(28, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date :";
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.radioButtonChoice4);
            this.panelQuestion.Controls.Add(this.radioButtonChoice3);
            this.panelQuestion.Controls.Add(this.radioButtonChoice2);
            this.panelQuestion.Controls.Add(this.radioButtonChoice1);
            this.panelQuestion.Controls.Add(this.lblShowQuestion);
            this.panelQuestion.Location = new System.Drawing.Point(33, 249);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(1330, 303);
            this.panelQuestion.TabIndex = 1;
            // 
            // radioButtonChoice4
            // 
            this.radioButtonChoice4.AutoSize = true;
            this.radioButtonChoice4.Location = new System.Drawing.Point(995, 233);
            this.radioButtonChoice4.Name = "radioButtonChoice4";
            this.radioButtonChoice4.Size = new System.Drawing.Size(44, 21);
            this.radioButtonChoice4.TabIndex = 5;
            this.radioButtonChoice4.TabStop = true;
            this.radioButtonChoice4.Text = "c4";
            this.radioButtonChoice4.UseVisualStyleBackColor = true;
            // 
            // radioButtonChoice3
            // 
            this.radioButtonChoice3.AutoSize = true;
            this.radioButtonChoice3.Location = new System.Drawing.Point(700, 233);
            this.radioButtonChoice3.Name = "radioButtonChoice3";
            this.radioButtonChoice3.Size = new System.Drawing.Size(44, 21);
            this.radioButtonChoice3.TabIndex = 4;
            this.radioButtonChoice3.TabStop = true;
            this.radioButtonChoice3.Text = "c3";
            this.radioButtonChoice3.UseVisualStyleBackColor = true;
            // 
            // radioButtonChoice2
            // 
            this.radioButtonChoice2.AutoSize = true;
            this.radioButtonChoice2.Location = new System.Drawing.Point(405, 233);
            this.radioButtonChoice2.Name = "radioButtonChoice2";
            this.radioButtonChoice2.Size = new System.Drawing.Size(44, 21);
            this.radioButtonChoice2.TabIndex = 3;
            this.radioButtonChoice2.TabStop = true;
            this.radioButtonChoice2.Text = "c2";
            this.radioButtonChoice2.UseVisualStyleBackColor = true;
            // 
            // radioButtonChoice1
            // 
            this.radioButtonChoice1.AutoSize = true;
            this.radioButtonChoice1.Location = new System.Drawing.Point(110, 233);
            this.radioButtonChoice1.Name = "radioButtonChoice1";
            this.radioButtonChoice1.Size = new System.Drawing.Size(44, 21);
            this.radioButtonChoice1.TabIndex = 2;
            this.radioButtonChoice1.TabStop = true;
            this.radioButtonChoice1.Text = "c1";
            this.radioButtonChoice1.UseVisualStyleBackColor = true;
            // 
            // lblShowQuestion
            // 
            this.lblShowQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblShowQuestion.Font = new System.Drawing.Font("Simple Bold Jut Out", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowQuestion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblShowQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblShowQuestion.Name = "lblShowQuestion";
            this.lblShowQuestion.Size = new System.Drawing.Size(1330, 189);
            this.lblShowQuestion.TabIndex = 1;
            this.lblShowQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(787, 594);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(275, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // ApplyToQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(157)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1394, 763);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplyToQuizForm";
            this.Text = "ApplyToQuizForm";
            this.Load += new System.EventHandler(this.ApplyToQuizForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblShowSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblShowQuizDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.RadioButton radioButtonChoice4;
        private System.Windows.Forms.RadioButton radioButtonChoice3;
        private System.Windows.Forms.RadioButton radioButtonChoice2;
        private System.Windows.Forms.RadioButton radioButtonChoice1;
        private System.Windows.Forms.Label lblShowQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timerDateTime;
    }
}