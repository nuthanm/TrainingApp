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
    public class Employees
    {

        #region ObjectsCreation
        DBConnection objCon;
        DataTable dtRoles;
        SqlParameter[] param;
        #endregion

        #region Employees
        /// <summary>
        /// Check Whether Employee is exist or not
        /// </summary>
        /// <returns>integer value</returns>
        public DataTable CheckEmployeeExists(EmployeeLogin objLogin)
        {
            param = new SqlParameter[3];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[0].Value = objLogin.UserName;
            param[1] = new SqlParameter("@Password", SqlDbType.VarChar);
            param[1].Value = objLogin.Password;
            param[2] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[2].Value = "CHECKUSER";
            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);
        }


        /// <summary>
        /// Create New Employee
        /// </summary>
        /// <returns></returns>
        public int CreateEmployee(EmployeeDetails objEmployeeDetails, EmployeeLogin objEmployeeLogins, EmpBankDetails objBankDetails)
        {
            param = new SqlParameter[21];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[0].Value = objEmployeeLogins.UserName;

            param[1] = new SqlParameter("@Password", SqlDbType.VarChar);
            param[1].Value = objEmployeeLogins.Password;

            param[2] = new SqlParameter("@Email", SqlDbType.VarChar);
            param[2].Value = objEmployeeLogins.Email;

            param[3] = new SqlParameter("@MobileNumber", SqlDbType.BigInt);
            param[3].Value = objEmployeeDetails.MobileNumber;

            param[4] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            param[4].Value = objEmployeeDetails.FirstName;

            param[5] = new SqlParameter("@LastName", SqlDbType.VarChar);
            param[5].Value = objEmployeeDetails.LastName;

            param[6] = new SqlParameter("@AddressLine1", SqlDbType.VarChar);
            param[6].Value = objEmployeeDetails.AddressLine1;

            param[7] = new SqlParameter("@City", SqlDbType.VarChar);
            param[7].Value = objEmployeeDetails.City;

            param[8] = new SqlParameter("@State", SqlDbType.VarChar);
            param[8].Value = objEmployeeDetails.State;

            param[9] = new SqlParameter("@Country", SqlDbType.VarChar);
            param[9].Value = objEmployeeDetails.Country;

            param[10] = new SqlParameter("@Pincode", SqlDbType.VarChar);
            param[10].Value = objEmployeeDetails.Pincode;

            param[11] = new SqlParameter("@IsActive", SqlDbType.Bit);
            param[11].Value = objEmployeeDetails.isActive;

            param[12] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[12].Value = "INSERT";

            param[13] = new SqlParameter("@BankName", SqlDbType.VarChar);
            param[13].Value = objBankDetails.BankName;

            param[14] = new SqlParameter("@BankBranch", SqlDbType.VarChar);
            param[14].Value = objBankDetails.BankBranch;

            param[15] = new SqlParameter("@BankIFSC", SqlDbType.VarChar);
            param[15].Value = objBankDetails.BankIFSCCode;

            param[16] = new SqlParameter("@BankAccNo", SqlDbType.VarChar);
            param[16].Value = objBankDetails.BankAccountNumber;

            param[17] = new SqlParameter("@BankAccountName", SqlDbType.VarChar);
            param[17].Value = objBankDetails.BankAccountName;

            param[18] = new SqlParameter("@IsBankAccountActive", SqlDbType.VarChar);
            param[18].Value = objBankDetails.isActive;

            param[19] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            param[19].Value = objEmployeeDetails.AddedBy;

            param[20] = new SqlParameter("@RoleID", SqlDbType.Int);
            param[20].Value = objEmployeeDetails.RoleID;


            objCon = new DBConnection();
            return objCon.ExecuteSP("spEmployeeWithBankDetails", param);
        }

        public int UpdateEmployee(EmployeeDetails objEmployeeDetails, EmployeeLogin objEmployeeLogins, EmpBankDetails objBankDetails)
        {
            param = new SqlParameter[22];

            param[0] = new SqlParameter("@EmpID", SqlDbType.Int);
            param[0].Value = objEmployeeDetails.EmpId;

            param[1] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[1].Value = objEmployeeLogins.UserName;

            param[2] = new SqlParameter("@Password", SqlDbType.VarChar);
            param[2].Value = objEmployeeLogins.Password;

            param[3] = new SqlParameter("@Email", SqlDbType.VarChar);
            param[3].Value = objEmployeeLogins.Email;

            param[4] = new SqlParameter("@MobileNumber", SqlDbType.BigInt);
            param[4].Value = objEmployeeDetails.MobileNumber;

            param[5] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            param[5].Value = objEmployeeDetails.FirstName;

            param[6] = new SqlParameter("@LastName", SqlDbType.VarChar);
            param[6].Value = objEmployeeDetails.LastName;

            param[7] = new SqlParameter("@AddressLine1", SqlDbType.VarChar);
            param[7].Value = objEmployeeDetails.AddressLine1;

            param[8] = new SqlParameter("@City", SqlDbType.VarChar);
            param[8].Value = objEmployeeDetails.City;

            param[9] = new SqlParameter("@State", SqlDbType.VarChar);
            param[9].Value = objEmployeeDetails.State;

            param[10] = new SqlParameter("@Country", SqlDbType.VarChar);
            param[10].Value = objEmployeeDetails.Country;

            param[11] = new SqlParameter("@Pincode", SqlDbType.VarChar);
            param[11].Value = objEmployeeDetails.Pincode;

            param[12] = new SqlParameter("@IsActive", SqlDbType.Bit);
            param[12].Value = objEmployeeDetails.isActive;

            param[13] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[13].Value = "UPDATE";

            param[14] = new SqlParameter("@BankName", SqlDbType.VarChar);
            param[14].Value = objBankDetails.BankName;

            param[15] = new SqlParameter("@BankBranch", SqlDbType.VarChar);
            param[15].Value = objBankDetails.BankBranch;

            param[16] = new SqlParameter("@BankIFSC", SqlDbType.VarChar);
            param[16].Value = objBankDetails.BankIFSCCode;

            param[17] = new SqlParameter("@BankAccNo", SqlDbType.VarChar);
            param[17].Value = objBankDetails.BankAccountNumber;

            param[18] = new SqlParameter("@BankAccountName", SqlDbType.VarChar);
            param[18].Value = objBankDetails.BankAccountName;

            param[19] = new SqlParameter("@IsBankAccountActive", SqlDbType.Bit);
            param[19].Value = objBankDetails.isActive;

            param[20] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            param[20].Value = objEmployeeDetails.AddedBy;
        
            param[21] = new SqlParameter("@RoleID", SqlDbType.Int);
            param[21].Value = objEmployeeDetails.RoleID;


            objCon = new DBConnection();
            return objCon.ExecuteSP("spEmployeeWithBankDetails", param);
        }

        public int DeleteEmployee(int empID)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@EmpID", SqlDbType.Int);
            param[0].Value = empID;

            param[1] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[1].Value = "DELETE";

            objCon = new DBConnection();
            return objCon.ExecuteSP("spEmployeeWithBankDetails", param);
        }

        public DataTable GetEmployees()
        {
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "EMPLOYEES";

            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);

        }

        public DataTable GetEmployees(int empId)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "EMPLOYEE";
            param[1] = new SqlParameter("@EmpID", SqlDbType.Int);
            param[1].Value = empId;

            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);

        }

        /// <summary>
        /// Check wether employee exists or not
        /// </summary>
        /// <param name="empName"></param>
        /// <returns></returns>
        public int CheckEmplyeeNameAvailability(string empName)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[0].Value = empName;

            param[1] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[1].Value = "EMPLOYEENAMEEXISTS";

            objCon = new DBConnection();
            return objCon.ExecuteGetSingleValueSP("spGetDetails", param);

        }

        /// <summary>
        /// Get Employee Id based on UserName
        /// </summary>
        /// <param name="empName"></param>
        /// <returns></returns>
        public int GetEmployeeID(string empName)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[0].Value = empName;

            param[1] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[1].Value = "GETEID";

            objCon = new DBConnection();
            return objCon.ExecuteGetSingleValueSP("spGetDetails", param);

        }
        #endregion
    }




    public class EmpBankDetails
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

    public class EmployeeType
    {
        public int EmployeeTypeId { get; set; }
        public int EmployeeTypeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class EmployeeLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
    public class EmployeeDetails
    {
        public int EmpId { get; set; }
        public long MobileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Pincode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool isActive { get; set; }
        public int AddedBy { get; set; }
        public int RoleID { get; set; }
        //public string ReferredBy { get; set; }
    }


}
