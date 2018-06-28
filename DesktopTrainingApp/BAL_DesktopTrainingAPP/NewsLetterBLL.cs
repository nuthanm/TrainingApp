using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_DesktopTrainingAPP;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BAL_DesktopTrainingAPP
{
    public class EmailMarketing
    {
        public string EUserName { get; set; }
        public string EPassword { get; set; }
        public string EAPIKEY { get; set; }
        public string EAPIVersion { get; set; }
        public string EAcceptType { get; set; }
        public string EContentType { get; set; }
        public string EEmail { get; set; }
        public string EFolderID { get; set; }
        public int ENID { get; set; }
    }

    public class NewsLetterBLL
    {
        #region ObjectsCreation
        DataTable dtNewsLetters;
        DBConnection _objCon;
        SqlParameter[] parameters;
        #endregion


        public int CreateEmailNewsLetter(EmailMarketing objMarkettingDetails)
        {

            _objCon = new DBConnection();
            parameters = new SqlParameter[9];

            parameters[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            parameters[0].Value = "INSERT";

            parameters[1] = new SqlParameter("@Email", SqlDbType.VarChar);
            parameters[1].Value = objMarkettingDetails.EEmail;

            parameters[2] = new SqlParameter("@UserName", SqlDbType.VarChar);
            parameters[2].Value = objMarkettingDetails.EUserName;

            parameters[3] = new SqlParameter("@Password", SqlDbType.VarChar);
            parameters[3].Value = objMarkettingDetails.EPassword;

            parameters[4] = new SqlParameter("@APIKey", SqlDbType.VarChar);
            parameters[4].Value = objMarkettingDetails.EAPIKEY;

            parameters[5] = new SqlParameter("@APIVersion", SqlDbType.VarChar);
            parameters[5].Value = objMarkettingDetails.EAPIVersion;

            parameters[6] = new SqlParameter("@FolderID", SqlDbType.VarChar);
            parameters[6].Value = objMarkettingDetails.EFolderID;

            parameters[7] = new SqlParameter("@AcceptType", SqlDbType.VarChar);
            parameters[7].Value = objMarkettingDetails.EAcceptType;

            parameters[8] = new SqlParameter("@ContentType", SqlDbType.VarChar);
            parameters[8].Value = objMarkettingDetails.EContentType;

            return _objCon.ExecuteSP("spNewsLetters", parameters);
        }

        public int UpdateEmailNewsLetter(EmailMarketing objMarkettingDetails)
        {
            _objCon = new DBConnection();
            parameters = new SqlParameter[10];
            parameters[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            parameters[0].Value = "UPDATE";

            parameters[1] = new SqlParameter("@Email", SqlDbType.VarChar);
            parameters[1].Value = objMarkettingDetails.EEmail;

            parameters[2] = new SqlParameter("@UserName", SqlDbType.VarChar);
            parameters[2].Value = objMarkettingDetails.EUserName;

            parameters[3] = new SqlParameter("@Password", SqlDbType.VarChar);
            parameters[3].Value = objMarkettingDetails.EPassword;

            parameters[4] = new SqlParameter("@APIKey", SqlDbType.VarChar);
            parameters[4].Value = objMarkettingDetails.EAPIKEY;

            parameters[5] = new SqlParameter("@APIVersion", SqlDbType.VarChar);
            parameters[5].Value = objMarkettingDetails.EAPIVersion;

            parameters[6] = new SqlParameter("@FolderID", SqlDbType.VarChar);
            parameters[6].Value = objMarkettingDetails.EFolderID;

            parameters[7] = new SqlParameter("@AcceptType", SqlDbType.VarChar);
            parameters[7].Value = objMarkettingDetails.EAcceptType;

            parameters[8] = new SqlParameter("@ContentType", SqlDbType.VarChar);
            parameters[8].Value = objMarkettingDetails.EContentType;

            parameters[9] = new SqlParameter("@NID", SqlDbType.VarChar);
            parameters[9].Value = objMarkettingDetails.ENID;


            return _objCon.ExecuteSP("spNewsLetters", parameters);
        }

        public int DeleteEmailNewsLetter(int newsLetterID)
        {
            _objCon = new DBConnection();

            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            parameters[0].Value = "DELETE";

            parameters[1] = new SqlParameter("@Nid", SqlDbType.Int);
            parameters[1].Value = newsLetterID;

            return _objCon.ExecuteSP("spNewsLetters", parameters);
        }

        /// <summary>
        /// Return available type of works
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmailMarketingDetails()
        {
            dtNewsLetters = new DataTable();
            _objCon = new DBConnection();

            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            parameters[0].Value = "NEWSLETTERS";

            return _objCon.ExecuteGetSP("spGetDetails", parameters); ;
        }
    }

}
