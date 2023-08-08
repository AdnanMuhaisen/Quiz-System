using System;
using System.Data;
using System.Collections.Generic;
using Quiz_System___Data_Access_Layer;


namespace Quiz_System___Middle_Layer
{
    public class clsQuiz
    {
        public int QuizID { set; get; }

        public DateTime QuizDate { set; get; }

        public int SubjectID { set; get; }

        public List<clsMCQ> QuestionsList { set; get; } 

        public string DepartmentName { set; get; }

        public string SubjectName { set; get; }

        public int NumberOfCorrectQuestions { set; get; }

        public int NumberOfWrongQuestions { set; get; }


        public clsQuiz(string DepartmentName,int SubjectID,string SubjectName)
        {
            this.QuizDate = DateTime.Now;
            this.SubjectID = SubjectID;
            this.DepartmentName = DepartmentName;
            this.SubjectName = SubjectName;
            QuestionsList = _GetQuestionsList();
            _Save();
            _SaveQuizQuestions();
            NumberOfCorrectQuestions = NumberOfWrongQuestions = 0;
        }


        private List<clsMCQ> _GetQuestionsList()
        {
            List<clsMCQ> _Questions = new List<clsMCQ>();
            DataTable TempDt = DataAccess.GetQuizQuestions(this.SubjectID);
            foreach (DataRow Row in TempDt.Rows) 
            {
                _Questions.Add(new clsMCQ(Convert.ToInt16(Row["QuestionID"]), Convert.ToInt16(Row["SubjectID"]), Row["QuestionContent"].ToString(),
                    Convert.ToInt16(Row["MCQID"]), Convert.ToInt16(Row["MCQResultID"])));
            }
            return _Questions;
        }

        private bool _Save()
        {
            this.QuizID = DataAccess.SaveAQuiz(this.SubjectID, this.QuizDate);
            return QuizID != default;
        }

        private bool _SaveQuizQuestions()
        {
            foreach (clsMCQ q in QuestionsList)
            {
                if (!DataAccess.SaveQuizQuestion(this.QuizID, q.QuestionID))
                    return false;
            }
            return true;
        }



    }
}
