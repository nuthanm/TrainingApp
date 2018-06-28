using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_DesktopTrainingAPP;
using System.Data;

namespace BAL_DesktopTrainingAPP
{

    public static class FeeDetails
    {
        public static int FeeID { get; set; }
        public static decimal FeePrice { get; set; }
        public static int Tax { get; set; }
        public static int GST { get; set; }
    }

    public class Fees
    {

        #region ObjectsCreation
        DataTable dtFees;
        DBConnection objCon;
        int queryResult = -1;

        #endregion

        public DataTable GetFees()
        {
            objCon = new DBConnection();
            dtFees = objCon.ExecuteSelectQuery(@"Select f.FeeId,c.CourseName,t.TypeName,f.Fee,f.ServiceTax from
       Courses c inner join FeeDetails f on f.CourseId=c.CourseId
       inner join TrainingTypes t on t.TrainingTypeId=f.TraineeTypeId");

            return dtFees;
        }

        public int CreateFees(int typeId, int courseId, int fee, int serviceTax)
        {
            objCon = new DBConnection();
            queryResult = objCon.ExecuteQuery(string.Format("Insert into FeeDetails Values({0},{1},{2},{3})", fee, typeId, courseId, serviceTax));
            return queryResult;
        }

        public int UpdateFees(int FeeID, int typeId, int courseId, decimal fee, int serviceTax)
        {
            objCon = new DBConnection();
            queryResult = objCon.ExecuteQuery(string.Format("Update FeeDetails SET TraineeTypeId={0},CourseId={1},Fee={2},ServiceTax={3} where FeeId={4}", typeId, courseId, fee, serviceTax, FeeID));
            //queryResult = objCon.ExecuteSP("", "UPDATE");
            return queryResult;
        }

        public int DeleteFees(int FeeID)
        {
            objCon = new DBConnection();
            queryResult = objCon.ExecuteQuery("Delete from FeeDetails where FeeId=" + FeeID);

            return queryResult;
        }

    }
}
