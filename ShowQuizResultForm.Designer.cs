namespace Quiz_System
{
    partial class ShowQuizResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowQuizResultForm));
            this.lblResult = new System.Windows.Forms.Label();
            this.lblShowResult = new System.Windows.Forms.Label();
            this.lblShowScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblShowNumberOfCorrectQuestions = new System.Windows.Forms.Label();
            this.lblNumberOfCorrectQ = new System.Windows.Forms.Label();
            this.lblShowNumberOfWrongQuestions = new System.Windows.Forms.Label();
            this.lblNumberOfWrongQ = new System.Windows.Forms.Label();
            this.btnGoToStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Simple Bold Jut Out", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Location = new System.Drawing.Point(289, 334);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(176, 34);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Your Result Is :";
            // 
            // lblShowResult
            // 
            this.lblShowResult.AutoSize = true;
            this.lblShowResult.Font = new System.Drawing.Font("Simple Bold Jut Out", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShowResult.Location = new System.Drawing.Point(502, 334);
            this.lblShowResult.Name = "lblShowResult";
            this.lblShowResult.Size = new System.Drawing.Size(0, 34);
            this.lblShowResult.TabIndex = 1;
            // 
            // lblShowScore
            // 
            this.lblShowScore.AutoSize = true;
            this.lblShowScore.Font = new System.Drawing.Font("Simple Bold Jut Out", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShowScore.Location = new System.Drawing.Point(512, 46);
            this.lblShowScore.Name = "lblShowScore";
            this.lblShowScore.Size = new System.Drawing.Size(0, 34);
            this.lblShowScore.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Simple Bold Jut Out", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(355, 46);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(91, 34);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score :";
            // 
            // lblShowNumberOfCorrectQuestions
            // 
            this.lblShowNumberOfCorrectQuestions.AutoSize = true;
            this.lblShowNumberOfCorrectQuestions.Font = new System.Drawing.Font("Simple Bold Jut Out", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowNumberOfCorrectQuestions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShowNumberOfCorrectQuestions.Location = new System.Drawing.Point(454, 192);
            this.lblShowNumberOfCorrectQuestions.Name = "lblShowNumberOfCorrectQuestions";
            this.lblShowNumberOfCorrectQuestions.Size = new System.Drawing.Size(0, 34);
            this.lblShowNumberOfCorrectQuestions.TabIndex = 5;
            // 
            // lblNumberOfCorrectQ
            // 
            this.lblNumberOfCorrectQ.AutoSize = true;
            this.lblNumberOfCorrectQ.Font = new System.Drawing.Font("Simple Bold Jut Out", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNumberOfCorrectQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumberOfCorrectQ.Location = new System.Drawing.Point(112, 192);
            this.lblNumberOfCorrectQ.Name = "lblNumberOfCorrectQ";
            this.lblNumberOfCorrectQ.Size = new System.Drawing.Size(240, 34);
            this.lblNumberOfCorrectQ.TabIndex = 4;
            this.lblNumberOfCorrectQ.Text = "# Correct Questions :";
            // 
            // lblShowNumberOfWrongQuestions
            // 
            this.lblShowNumberOfWrongQuestions.AutoSize = true;
            this.lblShowNumberOfWrongQuestions.Font = new System.Drawing.Font("Simple Bold Jut Out", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowNumberOfWrongQuestions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShowNumberOfWrongQuestions.Location = new System.Drawing.Point(892, 192);
            this.lblShowNumberOfWrongQuestions.Name = "lblShowNumberOfWrongQuestions";
            this.lblShowNumberOfWrongQuestions.Size = new System.Drawing.Size(0, 34);
            this.lblShowNumberOfWrongQuestions.TabIndex = 7;
            // 
            // lblNumberOfWrongQ
            // 
            this.lblNumberOfWrongQ.AutoSize = true;
            this.lblNumberOfWrongQ.Font = new System.Drawing.Font("Simple Bold Jut Out", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNumberOfWrongQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumberOfWrongQ.Location = new System.Drawing.Point(558, 192);
            this.lblNumberOfWrongQ.Name = "lblNumberOfWrongQ";
            this.lblNumberOfWrongQ.Size = new System.Drawing.Size(232, 34);
            this.lblNumberOfWrongQ.TabIndex = 6;
            this.lblNumberOfWrongQ.Text = "# Wrong Questions :";
            // 
            // btnGoToStart
            // 
            this.btnGoToStart.Location = new System.Drawing.Point(399, 439);
            this.btnGoToStart.Name = "btnGoToStart";
            this.btnGoToStart.Size = new System.Drawing.Size(202, 40);
            this.btnGoToStart.TabIndex = 8;
            this.btnGoToStart.Text = "Exit";
            this.btnGoToStart.UseVisualStyleBackColor = true;
            this.btnGoToStart.Click += new System.EventHandler(this.btnGoToStart_Click);
            // 
            // ShowQuizResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(157)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1035, 566);
            this.Controls.Add(this.btnGoToStart);
            this.Controls.Add(this.lblShowNumberOfWrongQuestions);
            this.Controls.Add(this.lblNumberOfWrongQ);
            this.Controls.Add(this.lblShowNumberOfCorrectQuestions);
            this.Controls.Add(this.lblNumberOfCorrectQ);
            this.Controls.Add(this.lblShowScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblShowResult);
            this.Controls.Add(this.lblResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowQuizResultForm";
            this.Text = "Quiz Result";
            this.Load += new System.EventHandler(this.ShowQuizResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblShowResult;
        private System.Windows.Forms.Label lblShowScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblShowNumberOfCorrectQuestions;
        private System.Windows.Forms.Label lblNumberOfCorrectQ;
        private System.Windows.Forms.Label lblShowNumberOfWrongQuestions;
        private System.Windows.Forms.Label lblNumberOfWrongQ;
        private System.Windows.Forms.Button btnGoToStart;
    }
}