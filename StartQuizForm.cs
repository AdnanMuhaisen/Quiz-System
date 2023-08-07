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
    public partial class StartQuizForm : Form
    {
        public int DepartmentID = default, SubjectID = default;
        public string DepartmentName=default, SubjectName=default;

        public StartQuizForm()
        {
            InitializeComponent();
            _ShowDateAndTime();
        }

        private void _ShowDateAndTime()
        {
            lblShowDate.Text = DateTime.Now.ToShortDateString();
            lblShowTime.Text = DateTime.Now.ToShortTimeString();
            lblShowUTCDateTime.Text = DateTime.UtcNow.ToShortTimeString();
        }

        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            _ShowDateAndTime();
        }

        private int _GetIDFromString(string str)
        {
            if (!str.Equals(null))
                return int.Parse(str.Substring(0, str.IndexOf(" ")));
            throw new NullReferenceException();
        }
        private void _FillDepartmentsComboBox()
        {
            DataTable DepartmentsDt = clsDepartment.GetAllDepartments();
            foreach (DataRow dr in DepartmentsDt.Rows)
            {
                comboBoxDepartments.Items.Add(dr["DepartmentID"] + " " + dr["DepartmentName"]);
            }
        }

        private void _FillSubjectsComboBox(int DepartmentID)
        {
            DataTable DepartmentSubjectsDt = clsDepartment.GetAllDepartmentSubjects(DepartmentID);

            if (DepartmentSubjectsDt == null)
                return;

            foreach (DataRow dr in DepartmentSubjectsDt.Rows)
            {
                comboBoxSubject.Items.Add(dr["SubjectID"] + " " + dr["SubjectName"]);
            }
        }


        private void StartQuizForm_Load(object sender, EventArgs e)
        {
            _FillDepartmentsComboBox();
        }

        ApplyToQuizForm ApplyToQuizFrm;
        private void btnStart_Click(object sender, EventArgs e)
        {
            clsQuiz NewQuiz=new clsQuiz(this.DepartmentName,this.SubjectID,this.SubjectName);
            ApplyToQuizFrm = new ApplyToQuizForm(NewQuiz);
            this.Hide();
            if (ApplyToQuizFrm.ShowDialog() == DialogResult.Cancel)
            {
                this._ResetFormData();
                this.Show();
            }


        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == -1)
            {
                errorProvider1.SetError(((ComboBox)sender), "Required !");
                ((ComboBox)sender).Focus();
            }
            else
            {
                errorProvider1.SetError(((ComboBox)sender), string.Empty);

                if (((ComboBox)sender).Name == comboBoxDepartments.Name)
                {
                    _FillSubjectsComboBox(_GetIDFromString(comboBoxDepartments.SelectedItem.ToString()));
                    comboBoxSubject.Focus();
                }
            }
        }

        private void _GetAllFormData()
        {
            this.DepartmentID = _GetIDFromString(comboBoxDepartments.SelectedItem.ToString());
            this.SubjectID = _GetIDFromString(comboBoxSubject.SelectedItem.ToString());
            this.DepartmentName = _GetNameFromComboBox(comboBoxDepartments.SelectedItem.ToString());
            this.SubjectName = _GetNameFromComboBox(comboBoxSubject.SelectedItem.ToString());
        }

        private void _ResetFormData()
        {
            this.DepartmentID = default;
            this.SubjectID = default;
            _LblReadyMessageController("No Subject", false);
            btnStart.Enabled = false;
            comboBoxDepartments.SelectedIndex = comboBoxSubject.SelectedIndex = -1;
            //comboBoxDepartments.Focus();
           // comboBoxSubject.Items.Clear();
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != -1)
            {
                _GetAllFormData();
                _LblReadyMessageController(comboBoxSubject.SelectedItem.ToString(), true);
                btnStart.Enabled = true;
            }
            else
                _ResetFormData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this._ResetFormData();
        }

        private void _LblReadyMessageController(string SubjectName,bool Visible)
        {
            lblReadyMessage.Text = "Are You Ready To Start Your Quiz With " + Environment.NewLine +
                SubjectName;
            lblReadyMessage.Visible = Visible;
        }

        private string _GetNameFromComboBox(string str)
        {
            return str.Substring(str.IndexOf("") + 1);
        }

    }
}
