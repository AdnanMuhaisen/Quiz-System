using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_System___Middle_Layer
{
    public abstract class clsQuestion
    {
        public int QuestionID { set; get; }

        public int SubjectID { set; get; }
        public string QuestionContent { set; get; }

        public clsQuestion(int QuestionID,int SubjectID,string QuestionContent)
        {
            this.QuestionID = QuestionID;
            this.SubjectID = SubjectID;
            this.QuestionContent = QuestionContent;
        }



    }
}
