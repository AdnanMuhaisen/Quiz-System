using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quiz_System___Data_Access_Layer
{
    public class DataAccess
    {
        static string ConnectionString = "Server=.;Database = QuizSystem_DB;User ID=sa;Password=sa123456;";

        // For Users Table :
        public static bool IsUserExist(string UsernameOrEmail)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"SELECT UserID FROM Users WHERE UsernameOrEmail = @UsernameOrEmail; ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            bool IsExist = false;

            Command.Parameters.AddWithValue("@UsernameOrEmail", UsernameOrEmail);

            try
            {
                Connection.Open();
                IsExist = Command.ExecuteScalar() != null;
            }
            catch (Exception) { return true; }
            finally { Connection.Close(); } 
                
            return IsExist;
        }

        public static bool AddNewUser(string UsernameOrEmail,string HashValue,int Salt)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"INSERT INTO Users VALUES
                            (@UsernameOrEmail,@HashValue,@Salt);";
            SqlCommand Command=new SqlCommand(Query,Connection);
            bool IsInserted = false;

            Command.Parameters.AddWithValue("@UsernameOrEmail", UsernameOrEmail);
            Command.Parameters.AddWithValue("@HashValue", HashValue);
            Command.Parameters.AddWithValue("@Salt", Salt);

            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                IsInserted = RowsAffected > 0;
            }
            catch (Exception) { return false; }
            finally { Connection.Close(); } 

            return IsInserted;  
        }

        public static Tuple<string,int> GetHashValueAndSalt(string UsernameOrEmail)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"SELECT HashValue,Salt FROM Users WHERE UsernameOrEmail = @UsernameOrEmail;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Tuple<string, int> T = null;

            Command.Parameters.AddWithValue("@UsernameOrEmail", UsernameOrEmail);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    T = new Tuple<string, int>(Convert.ToString(Reader["HashValue"]), int.Parse(Reader["Salt"].ToString()));
                }
                Reader.Close();
            }
            catch (Exception) { return null; }
            finally { Connection.Close(); } 

            return T;
        }


        /// <summary>
        /// Methods For Users Table :
        /// 1- IsExist
        /// 2- Add New User 
        /// 
        /// </summary>
        /// <returns></returns>




        // Department Methods :
        public static DataTable GetAllDepartments()
        {
            SqlConnection Connection=new SqlConnection(ConnectionString);
            string Query = @"SELECT * FROM Departments ORDER BY DepartmentID ASC;";
            SqlCommand Command=new SqlCommand(Query,Connection);    
            DataTable DepartmentsTable=new DataTable();

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                DepartmentsTable.Load(Reader);
                Reader.Close();
            }
            catch (Exception) { return null;}
            finally { Connection.Close(); } 

            return DepartmentsTable;
        }

        public static DataTable GetAllDepartmentSubjects(int DepartmentID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"SELECT SubjectID,SubjectName FROM Subjects WHERE DepartmentID = @DepartmentID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable DepartmentSubjectsTable = new DataTable();

            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                DepartmentSubjectsTable.Load(Reader);
                Reader.Close();
            }
            catch (Exception) { return null; }
            finally { Connection.Close(); }

            return DepartmentSubjectsTable;
        }








        public static DataTable GetMCQChoices(int MCQID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"SELECT ChoiceID,ChoiceValue,IsResult FROM MCQChoices WHERE MCQID = @MCQID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable dataTable = new DataTable();

            Command.Parameters.AddWithValue("@MCQID", MCQID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                dataTable.Load(Reader);
                Reader.Close();
            }
            catch (Exception) { return null; }
            finally { Connection.Close(); }

            return dataTable; 
        }

        public static DataTable GetQuizQuestions(int SubjectID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"SELECT TOP 10 Questions.QuestionID,MultipleChoiceQuestions.MCQID,Questions.SubjectID,Questions.QuestionContent,MultipleChoiceQuestions.MCQResultID
                            FROM Questions Inner Join MultipleChoiceQuestions ON Questions.QuestionID = MultipleChoiceQuestions.QuestionID
                            WHERE SubjectID = @SubjectID
                            ORDER BY NEWID();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable dataTable = new DataTable();

            Command.Parameters.AddWithValue("@SubjectID", SubjectID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                dataTable.Load(Reader);
                Reader.Close();
            }
            catch (Exception) { return null; }
            finally { Connection.Close(); }

            return dataTable;
        }

        public static int SaveAQuiz(int SubjectID,DateTime QuizDate)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"INSERT INTO Quizzes VALUES
                            (@QuizDate,@SubjectID);
                            SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            int QuizID = default;

            Command.Parameters.AddWithValue("@QuizDate", QuizDate);
            Command.Parameters.AddWithValue("@SubjectID", SubjectID);

            try
            {
                Connection.Open();
                QuizID = Convert.ToInt32(Command.ExecuteScalar());
            }
            catch (Exception) { return default; }
            finally { Connection.Close(); }

            return QuizID;
        }

        public static bool SaveQuizQuestion(int QuizID,int QuestionID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"INSERT INTO QuizQuestions VALUES
                            (@QuizID,@QuestionID);";
            SqlCommand Command = new SqlCommand(Query, Connection);
            bool IsInserted = false;

            Command.Parameters.AddWithValue("QuizID", QuizID);
            Command.Parameters.AddWithValue("QuestionID", QuestionID);
            
            try
            {
                Connection.Open();
                IsInserted = (Command.ExecuteNonQuery() > 0);
            }
            catch (Exception) { return false; }
            finally { Connection.Close(); }

            return IsInserted;
        }
    }
}
