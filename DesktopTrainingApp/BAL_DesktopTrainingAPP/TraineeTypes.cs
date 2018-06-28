using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DAL_DesktopTrainingAPP;
using System.Data.SqlClient;
namespace BAL_DesktopTrainingAPP
{
    public static class TraineeTypeDetails
    {
        public static int TraineeTypeId { get; set; }
        public static string TypeName { get; set; }
        public static DateTime CreatedDate { get; set; }
        public static DateTime ModifiedDate { get; set; }
    }

    public class TraineeTypes
    {
        #region ObjectsCreation
        DataTable dtTraineeTypes;
        DBConnection objCon;
        int queryResult = -1;
        SqlParameter[] param;
        #endregion

        #region TraineeTypes


        public DataTable GetTrainerFeeDetails(int trainerID)
        {
            objCon = new DBConnection();
            dtTraineeTypes = new DataTable("Trainee Fees");

            param = new SqlParameter[2];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "TRAINERFEES";
                       
            param[1] = new SqlParameter("@TrainerID", SqlDbType.Int);
            param[1].Value = trainerID;
            
            dtTraineeTypes = objCon.ExecuteGetSP("spGetDetails", param);
            return dtTraineeTypes;
            
        }
        public DataTable GetTraineeTypes()
        {
            objCon = new DBConnection();
            dtTraineeTypes = new DataTable("Trainee Types");

            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "TRAININGTYPES";

            dtTraineeTypes = objCon.ExecuteGetSP("spGetDetails", param);
            return dtTraineeTypes;
            //return objCon.ExecuteSelectQuery(@"Select TrainingTypeId,TypeName from TrainingTypes;");
        }


        public int CreateTraineeTypes()
        {
            objCon = new DBConnection();
            return objCon.ExecuteSP("", param);
        }

        public int UpdateTraineeTypes()
        {
            objCon = new DBConnection();
            return objCon.ExecuteSP("", param);
        }

        public int DeleteTraineeTypes()
        {
            objCon = new DBConnection();
            return objCon.ExecuteSP("", param);
        }
        #endregion

    }
}
