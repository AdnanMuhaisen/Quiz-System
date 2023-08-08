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
    public partial class ShowQuizResultForm : Form
    {
        int NumberOfCorrectQuestions, NumberOfWrongQuestions;
        float Score;
        public ShowQuizResultForm(float Score,int NumberOfCorrectQuestions,int NumberOfWrongQuestions)
        {
            InitializeComponent();

            this.Score = Score;
            this.NumberOfCorrectQuestions = NumberOfCorrectQuestions;
            this.NumberOfWrongQuestions = NumberOfWrongQuestions;
        }

        private void ShowQuizResultForm_Load(object sender, EventArgs e)
        {
            lblShowNumberOfCorrectQuestions.Text = this.NumberOfCorrectQuestions.ToString();
            lblShowNumberOfWrongQuestions.Text = this.NumberOfWrongQuestions.ToString();
            lblShowScore.Text = this.Score.ToString("p");
            lblShowResult.Text = _GetQuizResult();
        }

        private string _GetQuizResult() => (this.Score*100.0 >= 50.0) ? "PASS :)" : "FAIL :(";
 
        private void btnGoToStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
