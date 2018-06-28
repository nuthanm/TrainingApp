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
    public class Users
    {

        #region ObjectsCreation
        DBConnection objCon;
        DataTable dtRoles;
        SqlParameter[] param;
        #endregion

        #region Users
        /// <summary>
        /// Check Whether user is exist or not
        /// </summary>
        /// <returns>integer value</returns>
        public DataTable CheckUserExists(UserLogin objLogin)
        {
            param = new SqlParameter[3];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[0].Value = objLogin.UserName;
            param[1] = new SqlParameter("@Password", SqlDbType.VarChar);
            param[1].Value = objLogin.Password;
            param[2] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[2].Value = "CHECKUSER ";
            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);
        }


        /// <summary>
        /// Create New User
        /// </summary>
        /// <returns></returns>
        public int CreateUser(UserDetails objUserDetails, UserLogin objUserLogins, UserType objUserType, BankDetails objBankDetails)
        {
            param = new SqlParameter[22];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[0].Value = objUserLogins.UserName;

            param[1] = new SqlParameter("@Password", SqlDbType.VarChar);
            param[1].Value = objUserLogins.Password;

            param[2] = new SqlParameter("@Email", SqlDbType.VarChar);
            param[2].Value = objUserLogins.Email;

            param[3] = new SqlParameter("@MobileNumber", SqlDbType.BigInt);
            param[3].Value = objUserDetails.MobileNumber;

            param[4] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            param[4].Value = objUserDetails.FirstName;

            param[5] = new SqlParameter("@LastName", SqlDbType.VarChar);
            param[5].Value = objUserDetails.LastName;

            param[6] = new SqlParameter("@AddressLine1", SqlDbType.VarChar);
            param[6].Value = objUserDetails.AddressLine1;

            param[7] = new SqlParameter("@AddressLine2", SqlDbType.VarChar);
            param[7].Value = objUserDetails.AddressLine2;

            param[8] = new SqlParameter("@City", SqlDbType.VarChar);
            param[8].Value = objUserDetails.City;

            param[9] = new SqlParameter("@State", SqlDbType.VarChar);
            param[9].Value = objUserDetails.State;

            param[10] = new SqlParameter("@Country", SqlDbType.VarChar);
            param[10].Value = objUserDetails.Country;

            param[11] = new SqlParameter("@Pincode", SqlDbType.VarChar);
            param[11].Value = objUserDetails.Pincode;

            param[12] = new SqlParameter("@UserType", SqlDbType.Int);
            param[12].Value = objUserType.UserTypeId;

            param[13] = new SqlParameter("@IsActive", SqlDbType.Bit);
            param[13].Value = objUserDetails.isActive;

            param[14] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[14].Value = "INSERT";

            param[15] = new SqlParameter("@BankName", SqlDbType.VarChar);
            param[15].Value = objBankDetails.BankName;

            param[16] = new SqlParameter("@BankBranch", SqlDbType.VarChar);
            param[16].Value = objBankDetails.BankBranch;

            param[17] = new SqlParameter("@BankIFSC", SqlDbType.VarChar);
            param[17].Value = objBankDetails.BankIFSCCode;

            param[18] = new SqlParameter("@BankAccNo", SqlDbType.VarChar);
            param[18].Value = objBankDetails.BankAccountNumber;

            param[19] = new SqlParameter("@BankAccountName", SqlDbType.VarChar);
            param[19].Value = objBankDetails.BankAccountName;

            param[20] = new SqlParameter("@IsBankAccountActive", SqlDbType.VarChar);
            param[20].Value = objBankDetails.isActive;

            param[21] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            param[21].Value = objUserDetails.UserId;


            //param[22] = new SqlParameter("@ReferredBy", SqlDbType.VarChar);
            //param[22].Value = objUserDetails.ReferredBy;



            objCon = new DBConnection();
            return objCon.ExecuteSP("spUsersWithBankDetails", param);
        }

        public int UpdateUser(UserDetails objUserDetails, UserLogin objUserLogins, UserType objUserType, BankDetails objBankDetails)
        {
            param = new SqlParameter[23];

            param[0] = new SqlParameter("@UserID", SqlDbType.Int);
            param[0].Value = objUserDetails.UserId;

            param[1] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[1].Value = objUserLogins.UserName;

            param[2] = new SqlParameter("@Password", SqlDbType.VarChar);
            param[2].Value = objUserLogins.Password;

            param[3] = new SqlParameter("@Email", SqlDbType.VarChar);
            param[3].Value = objUserLogins.Email;

            param[4] = new SqlParameter("@MobileNumber", SqlDbType.BigInt);
            param[4].Value = objUserDetails.MobileNumber;

            param[5] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            param[5].Value = objUserDetails.FirstName;

            param[6] = new SqlParameter("@LastName", SqlDbType.VarChar);
            param[6].Value = objUserDetails.LastName;

            param[7] = new SqlParameter("@AddressLine1", SqlDbType.VarChar);
            param[7].Value = objUserDetails.AddressLine1;

            param[8] = new SqlParameter("@AddressLine2", SqlDbType.VarChar);
            param[8].Value = objUserDetails.AddressLine2;

            param[9] = new SqlParameter("@City", SqlDbType.VarChar);
            param[9].Value = objUserDetails.City;

            param[10] = new SqlParameter("@State", SqlDbType.VarChar);
            param[10].Value = objUserDetails.State;

            param[11] = new SqlParameter("@Country", SqlDbType.VarChar);
            param[11].Value = objUserDetails.Country;

            param[12] = new SqlParameter("@Pincode", SqlDbType.VarChar);
            param[12].Value = objUserDetails.Pincode;

            param[13] = new SqlParameter("@UserType", SqlDbType.Int);
            param[13].Value = objUserType.UserTypeId;

            param[14] = new SqlParameter("@IsActive", SqlDbType.Bit);
            param[14].Value = objUserDetails.isActive;

            param[15] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[15].Value = "UPDATE";

            param[16] = new SqlParameter("@BankName", SqlDbType.VarChar);
            param[16].Value = objBankDetails.BankName;

            param[17] = new SqlParameter("@BankBranch", SqlDbType.VarChar);
            param[17].Value = objBankDetails.BankBranch;

            param[18] = new SqlParameter("@BankIFSC", SqlDbType.VarChar);
            param[18].Value = objBankDetails.BankIFSCCode;

            param[19] = new SqlParameter("@BankAccNo", SqlDbType.VarChar);
            param[19].Value = objBankDetails.BankAccountNumber;

            param[20] = new SqlParameter("@BankAccountName", SqlDbType.VarChar);
            param[20].Value = objBankDetails.BankAccountName;

            param[21] = new SqlParameter("@IsBankAccountActive", SqlDbType.Bit);
            param[21].Value = objBankDetails.isActive;

            param[22] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            param[22].Value = objUserDetails.UserId;
            
            //param[23] = new SqlParameter("@ReferredBy", SqlDbType.VarChar);
            //param[23].Value = objUserDetails.ReferredBy;


            objCon = new DBConnection();
            return objCon.ExecuteSP("spUsersWithBankDetails", param);
        }

        public int DeleteUser(int userID)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@UserID", SqlDbType.Int);
            param[0].Value = userID;// objUserDetails.UserId;

            param[1] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[1].Value = "DELETE";

            objCon = new DBConnection();
            return objCon.ExecuteSP("spUsersWithBankDetails", param);
        }


        public DataTable GetUsers()
        {
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "USERS";

            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);

        }

        public DataTable GetUsers(int userId)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "USER";
            param[1] = new SqlParameter("@UserID", SqlDbType.Int);
            param[1].Value = userId;

            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);

        }

        public int CheckUserNameAvailability(string userName)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[0].Value = userName;

            param[1] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[1].Value = "USERNAMEEXISTS";

            objCon = new DBConnection();
            return objCon.ExecuteGetSingleValueSP("spGetDetails", param);

        }

        public int GetUserID(string userName)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[0].Value = userName;

            param[1] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[1].Value = "GETUID";

            objCon = new DBConnection();
            return objCon.ExecuteGetSingleValueSP("spGetDetails", param);

        }
        #endregion

        #region UserTypes

        public DataTable GetUserTypes()
        {
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "USERTYPES";

            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);
        }
        public int CreateUserType(string userType, string userTypeDesc)
        {
            param = new SqlParameter[3];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "INSERT";

            param[1] = new SqlParameter("@UserType", SqlDbType.VarChar);
            param[1].Value = userType;

            param[2] = new SqlParameter("@UTDesc", SqlDbType.VarChar);
            param[2].Value = userTypeDesc;
            objCon = new DBConnection();
            return objCon.ExecuteSP("spUserTypes", param);
        }

        public int UpdateUserType(int typeId, string userType, string userTypeDesc)
        {
            param = new SqlParameter[4];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "UPDATE";

            param[1] = new SqlParameter("@UserType", SqlDbType.VarChar);
            param[1].Value = userType;

            param[2] = new SqlParameter("@UTDesc", SqlDbType.VarChar);
            param[2].Value = userTypeDesc;

            param[3] = new SqlParameter("@TypeId", SqlDbType.Int);
            param[3].Value = typeId;

            objCon = new DBConnection();
            return objCon.ExecuteSP("spUserTypes", param);
        }

        public int DeleteUserType(int typeId)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "DELETE";

            param[1] = new SqlParameter("@TypeId", SqlDbType.Int);
            param[1].Value = typeId;

            objCon = new DBConnection();
            return objCon.ExecuteSP("spUserTypes", param);
        }
        #endregion
    }

    //public static class UserLogin
    //{
    //    public static string UserName { get; set; }
    //    public static string Password { get; set; }
    //    public static string Email { get; set; }
    //}

    //public static class UserDetails
    //{
    //    public static int UserId { get; set; }
    //    public static int MobileNumber { get; set; }
    //    public static string FirstName { get; set; }
    //    public static string LastName { get; set; }
    //    public static string AddressLine1 { get; set; }
    //    public static string AddressLine2 { get; set; }
    //    public static string AddressLine3 { get; set; }
    //    public static string City { get; set; }
    //    public static string State { get; set; }
    //    public static string Country { get; set; }
    //    public static int Pincode { get; set; }
    //    public static DateTime CreatedDate { get; set; }
    //    public static DateTime ModifiedDate { get; set; }
    //    public static bool isActive { get; set; }
    //}


    //public static class BankDetails
    //{
    //    public static string BankAccountNumber { get; set; }
    //    public static string BankName { get; set; }
    //    public static string BankIFSCCode { get; set; }
    //    public static string BankBranch { get; set; }
    //    public static string BankAccountName { get; set; }
    //    public static string TransactionNumber { get; set; }
    //    public static DateTime CratedDate { get; set; }
    //    public static DateTime ModifiedDate { get; set; }
    //    public static DateTime TransactionDate { get; set; }
    //    public static decimal Amount { get; set; }

    //}

    //public static class UserType
    //{
    //    public static int UserTypeId { get; set; }
    //    public static int UserTypeName { get; set; }
    //    public static DateTime CreatedDate { get; set; }
    //    public static DateTime ModifiedDate { get; set; }
    //}



    public class BankDetails
    {
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankIFSCCode { get; set; }
        public string BankBranch { get; set; }
        public string BankAccountName { get; set; }
        public string TransactionNumber { get; set; }
        public DateTime CratedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public bool isActive { get; set; }
    }

    public class UserType
    {
        public int UserTypeId { get; set; }
        public int UserTypeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
    public class UserDetails
    {
        public int UserId { get; set; }
        public long MobileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Pincode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool isActive { get; set; }
        //public string ReferredBy { get; set; }
    }


}
