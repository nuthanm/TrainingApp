using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL_DesktopTrainingAPP
{
    public class UserProfileHandler
    {
        string Connectionstring = ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();

        public object ValidateUser(string username, string password)
        {

            SqlParameter[] UserDetails = new SqlParameter[2];

            UserDetails[0] = new SqlParameter("@username", SqlDbType.VarChar, 150);
            UserDetails[0].Value = username;
            UserDetails[1] = new SqlParameter("@Password", SqlDbType.VarChar, 150);
            UserDetails[1].Value = password;

            try
            {
                return SqlHelper.ExecuteDataset(Connectionstring, CommandType.StoredProcedure, "dbo.SP_loginvalidate", UserDetails);
            }
            catch (Exception ex)
            {
                //WriteToLog.ErrosMonitor("UserProfileHandler", "ValidateUser", ex.ToString());
                return ex.ToString();
            }
        }
    }
}
