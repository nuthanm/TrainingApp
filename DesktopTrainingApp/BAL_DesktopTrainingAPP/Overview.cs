using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_DesktopTrainingAPP;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace BAL_DesktopTrainingAPP
{
    public class Overview
    {
        #region ObjectsCreation
        DBConnection objCon;
        DataTable dt;
        SqlParameter[] param;
        #endregion

        /// <summary>
        /// Returns total count of trainingtypes over all
        /// Ex: Trainings - 20
        ///     Proxy     - 10
        ///     Exam      - 5
        /// </summary>
        /// <returns></returns>
        public DataTable GetTotalTrainingTypes()
        {
            objCon = new DBConnection();
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "TOTALTYPESCOUNT";

            return objCon.ExecuteGetSP("spDashBoard", param);
        }


        /// <summary>
        /// Returns total count of trainingtypes over all
        /// Ex: Trainings - 20
        ///     Proxy     - 10
        ///     Exam      - 5
        /// </summary>
        /// <returns></returns>
        public DataTable GetTotalTrainingTypesBasedOnYears()
        {
            objCon = new DBConnection();
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "TOTALTYPESCOUNTWITHYEARS";

            return objCon.ExecuteGetSP("spDashBoard", param);
        }


        /// <summary>
        /// Returns total count of trainingtypes over all
        /// Ex: InProgress - 20
        ///     Scheduled - 2
        ///     
        /// </summary>
        /// <returns></returns>
        public DataTable GetTotalCurrentRunningStatus()
        {
            objCon = new DBConnection();
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "CURRENTRUNNING";

            return objCon.ExecuteGetSP("spDashBoard", param);
        }
    }
}
