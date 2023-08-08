using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using Quiz_System___Data_Access_Layer;


namespace Quiz_System___Middle_Layer
{
    public class clsMCQ : clsQuestion
    {
        public struct stMCQChoice
        {
            public int ChoiceID;
            public string ChoiceValue;
            public bool IsResult;
            public stMCQChoice(int ChoiceID, string ChoiceValue, bool IsResult = false)
            {
                this.ChoiceID = ChoiceID;
                this.ChoiceValue = ChoiceValue;
                this.IsResult = IsResult;   
            }
        }

        public int MCQID { set; get; }

        public int MCQResultID { set; get; }

        public List<stMCQChoice> MCQChoices;


        public clsMCQ(int QuestionID, int SubjectID, string QuestionContent, int mCQID, int mCQResultID) 
            : base (QuestionID,SubjectID,QuestionContent)

        {
            MCQID = mCQID;
            MCQResultID = mCQResultID;
            MCQChoices = _ConvertChoicesDataTableToList();
        }

        private List<stMCQChoice> _ConvertChoicesDataTableToList()
        {
            List<stMCQChoice> _choices = new List<stMCQChoice>();
            DataTable ChoicesDt = _GetMCQChoices();

            foreach (DataRow dr in ChoicesDt.Rows)
            {
                if (Convert.ToInt16(dr["IsResult"]) == 1)
                    _choices.Add(new stMCQChoice(Convert.ToInt16(dr["ChoiceID"]), dr["ChoiceValue"].ToString(), true));
                else
                    _choices.Add(new stMCQChoice(Convert.ToInt16(dr["ChoiceID"]), dr["ChoiceValue"].ToString()));
            }
            return _choices;
        }

        private DataTable _GetMCQChoices()
        {
            return DataAccess.GetMCQChoices(this.MCQID);
        }
    }
}
