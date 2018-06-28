using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_DesktopTrainingAPP;
using System.Data;
using System.Data.SqlClient;
namespace BAL_DesktopTrainingAPP
{
    public class TrainerDetails
    {
        DataTable dtTraines;
        DBConnection _objCon;
        SqlParameter[] parameters;

        public DataTable LoadTrainers()
        {
            _objCon = new DBConnection();
            dtTraines = new DataTable("Trainers");

            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            parameters[0].Value = "TRAINER";

            parameters[1] = new SqlParameter("@UserTypeName", SqlDbType.VarChar);
            parameters[1].Value = "Trainer";

            dtTraines = _objCon.ExecuteGetSP("spGetDetails", parameters);
            return dtTraines;

        }

        
    }
}
