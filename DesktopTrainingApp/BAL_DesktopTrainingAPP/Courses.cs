using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_DesktopTrainingAPP;
using System.Data.SqlClient;

namespace BAL_DesktopTrainingAPP
{
    public class Courses
    {
        #region ObjectsCreation
        DataTable dtCourses;
        DataTable dtTraineeTypes;
        DBConnection objCon;
        int queryResult = -1;
        SqlParameter[] param;
        #endregion

        public DataTable GetCourses()
        {
            objCon = new DBConnection();
            return objCon.ExecuteSelectQuery("Select CourseId,CourseName from Courses;");
        }

        public int CreateCourses()
        {
            objCon = new DBConnection();
            queryResult = objCon.ExecuteSP("",param );
            return queryResult;
        }

        public int UpdateCourses()
        {
            objCon = new DBConnection();
            queryResult = objCon.ExecuteSP("", param);
            return queryResult;
        }

        public int DeleteCourses()
        {
            objCon = new DBConnection();
            queryResult = objCon.ExecuteSP("", param);
            return queryResult;
        }
    }

    public static class CourseDetails
    {
        public static int CourseID { get; set; }
        public static string CourseName { get; set; }
        public static string CourseDesc { get; set; }
        public static DateTime CreatedDate { get; set; }
        public static DateTime ModifiedDate { get; set; }
    }

}
