using Quiz_System___Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_System___Middle_Layer
{
    public class clsDepartment
    {
        public int DepartmentID { set; get; }

        public string DepartmentName { set; get; }

        public clsDepartment() { ; }  
        public clsDepartment(int departmentID, string departmentName) 
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;
        }

        public static DataTable GetAllDepartments()
        {
            return DataAccess.GetAllDepartments();
        }

        public static DataTable GetAllDepartmentSubjects(int DepartmentID)
        {
            return DataAccess.GetAllDepartmentSubjects(DepartmentID);
        }
    }
}
