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
    public partial class ApplyToQuizForm : Form
    {
        private clsQuiz _Quiz;
        private int _IndexOfQuizQuestion;
        private ShowQuizResultForm _ShowQuizResultForm;
        private clsUser _CurrentUser;

        public ApplyToQuizForm(clsUser CurrentUser,clsQuiz Quiz)
        {
            InitializeComponent();
            this._CurrentUser = CurrentUser;
            this._Quiz = Quiz;
            _IndexOfQuizQuestion = 0;
        }

        private void ApplyToQuizForm_Load(object sender, EventArgs e)
        {
            lblShowQuizDepartment.Text = _Quiz.DepartmentName;
            lblShowSubject.Text = _Quiz.SubjectName;
            lblShowDate.Text = DateTime.Now.ToShortDateString();
            lblShowTime.Text = DateTime.Now.ToShortTimeString();
            lblShowCurrentUser.Text = _CurrentUser.UserNameOrEmail;


            _ShowAQuestion(_Quiz.QuestionsList[_IndexOfQuizQuestion]);
            _SetTagOfQuestionResult(_Quiz.QuestionsList[_IndexOfQuizQuestion++]);
            _UnCheckAllRadioButtons();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblShowDate.Text = DateTime.Now.ToShortDateString();
            lblShowTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void _ShowAQuestion(clsMCQ MCQ)
        {
            lblShowQuestion.Text = MCQ.QuestionContent;
            radioButtonChoice1.Text = MCQ.MCQChoices[0].ChoiceValue;
            radioButtonChoice2.Text = MCQ.MCQChoices[1].ChoiceValue;
            radioButtonChoice3.Text = MCQ.MCQChoices[2].ChoiceValue;
            radioButtonChoice4.Text = MCQ.MCQChoices[3].ChoiceValue;
        }

        private void _SetTagOfQuestionResult(clsMCQ TempMcq)
        {
            if (TempMcq.MCQChoices[0].IsResult)
                radioButtonChoice1.Tag = "1";
            else
                radioButtonChoice1.Tag = "0";

            if (TempMcq.MCQChoices[1].IsResult)
                radioButtonChoice2.Tag = "1";
            else
                radioButtonChoice2.Tag = "0";

            if (TempMcq.MCQChoices[2].IsResult)
                radioButtonChoice3.Tag = "1";
            else
                radioButtonChoice3.Tag = "0";

            if (TempMcq.MCQChoices[3].IsResult)
                radioButtonChoice4.Tag = "1";
            else
                radioButtonChoice4.Tag = "1";

        }

        private void _ResetRadioButtonsTags()
            => radioButtonChoice1.Tag = radioButtonChoice2.Tag = radioButtonChoice3.Tag = radioButtonChoice4.Tag = "";



        private bool _ChectQuestionResult()
        {
            if (radioButtonChoice1.Checked && radioButtonChoice1.Tag.ToString().Equals("1"))
                return true;
            else if (radioButtonChoice2.Checked && radioButtonChoice2.Tag.ToString().Equals("1"))
                return true;
            else if (radioButtonChoice3.Checked && radioButtonChoice3.Tag.ToString().Equals("1"))
                return true;
            else if (radioButtonChoice4.Checked && radioButtonChoice4.Tag.ToString().Equals("1"))
                return true;

            return false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text.Equals("Finish"))
            {
                _ShowQuizResultForm = new ShowQuizResultForm(_CalculateQuizScore(), _Quiz.NumberOfCorrectQuestions,
                    _Quiz.NumberOfWrongQuestions);
                this.Hide();
                if (_ShowQuizResultForm.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }
            }

            if (_IsTheAnswerSelected())
            {
                if (_ChectQuestionResult())
                {
                    _Quiz.NumberOfCorrectQuestions++;
                }
                else
                {
                    _Quiz.NumberOfWrongQuestions++;
                }
            }
            else
            {
                MessageBox.Show("You Must Select An Option !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_IndexOfQuizQuestion == _Quiz.QuestionsList.Count)
            {
                btnNext.Text = "Finish";
                return;
            }

            _UnCheckAllRadioButtons();
            _ResetRadioButtonsTags();
            _ShowAQuestion(_Quiz.QuestionsList[_IndexOfQuizQuestion]);
            _SetTagOfQuestionResult(_Quiz.QuestionsList[_IndexOfQuizQuestion++]);

        }

        private void _UnCheckAllRadioButtons()
        {
            radioButtonChoice1.Checked = radioButtonChoice2.Checked = radioButtonChoice3.Checked =
                 radioButtonChoice4.Checked = false;
        }

        private bool _IsTheAnswerSelected() =>
            (radioButtonChoice1.Checked || radioButtonChoice2.Checked || radioButtonChoice3.Checked ||
            radioButtonChoice4.Checked) ? true : false;

        private float _CalculateQuizScore()
            => Convert.ToSingle((_Quiz.NumberOfCorrectQuestions / (float)_Quiz.QuestionsList.Count));
    }
}
