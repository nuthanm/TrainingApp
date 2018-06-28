using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_DesktopTrainingAPP;
using System.Data;
using System.Data.SqlClient;
namespace BAL_DesktopTrainingAPP
{

    public static class RoleDetails
    {
        public static int RoleID { get; set; }
        public static string RoleName { get; set; }
        public static string RoleDesc { get; set; }
        public static DateTime CreatedDate { get; set; }
        public static DateTime ModifiedDate { get; set; }
    }

    public class Roles
    {
        #region ObjectsCreation
        DataTable dtRoles;
        DataTable dtRolesAccess;
        DBConnection objCon;
        int queryResult = -1;
        static string strRoles = "Select RoleId,RoleName from Roles";
        SqlParameter[] param;
        #endregion

        /// <summary>
        /// Get all Roles
        /// </summary>
        /// <returns>All Roles</returns>
        public DataTable GetRoles()
        {

            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "ROLES";

            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);
        }

        public int CreateRole(string roleName, string roleDesc)
        {

            param = new SqlParameter[3];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "INSERT";
            param[1] = new SqlParameter("@RName", SqlDbType.VarChar);
            param[1].Value = roleName;
            param[2] = new SqlParameter("@RDesc", SqlDbType.VarChar);
            param[2].Value = roleDesc;

            objCon = new DBConnection();
            return objCon.ExecuteSP("spRoles", param);


        }

        public int UpdateRole(int roleID, string roleName, string roleDesc)
        {
            param = new SqlParameter[4];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "UPDATE";
            param[1] = new SqlParameter("@RName", SqlDbType.VarChar);
            param[1].Value = roleName;
            param[2] = new SqlParameter("@RDesc", SqlDbType.VarChar);
            param[2].Value = roleDesc;
            param[3] = new SqlParameter("@RoleId", SqlDbType.Int);
            param[3].Value = roleID;

            objCon = new DBConnection();
            return objCon.ExecuteSP("spRoles", param);

        }

        public int DeleteRole(int roleID)
        {
            param = new SqlParameter[4];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "DELETE";
            param[1] = new SqlParameter("@RoleId", SqlDbType.VarChar);
            param[1].Value = roleID;
            objCon = new DBConnection();
            return objCon.ExecuteSP("spRoles", param);

        }

        public int AssignRoleToUser()
        {
            objCon = new DBConnection();
            queryResult = objCon.ExecuteSP("", param);
            return queryResult;
        }

        public DataTable GetUserRoles()
        {
            objCon = new DBConnection();
            dtRolesAccess = objCon.ExecuteSelectQuery("");
            return dtRolesAccess;
        }

        public DataTable RoleMappingToModules()
        {
            return dtRoles;
        }
    }

    public class ModuleRoleAccess
    {
        #region ObjectsCreation
        DataTable dtModules;        
        DBConnection objCon;
        int queryResult = -1;        
        SqlParameter[] param;
        #endregion

        /// <summary>
        /// Get all Modules
        /// </summary>
        /// <returns>All Roles</returns>
        public DataTable GetModules()
        {
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "MODULES";

            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);
        }


        /// <summary>
        /// Get all Functions
        /// </summary>
        /// <returns>All Roles</returns>
        public DataTable GetFunctions(int moduleID)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "FUNCTIONS";
            param[1] = new SqlParameter("@ModuleId", SqlDbType.VarChar);
            param[1].Value = moduleID;

            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);
        }


        /// <summary>
        /// Get all Module Functions
        /// </summary>
        /// <returns>All Roles</returns>
        public DataTable GetModuleFunctions(int moduleID)
        {
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "MFunctions";
            param[1] = new SqlParameter("@ModuleID", SqlDbType.Int);
            param[1].Value = moduleID;

            objCon = new DBConnection();
            return objCon.ExecuteGetSP("spGetDetails", param);
        }

        public int CreateModuleAccess(int roleID, int moduleId, int functionID,string fName,string fUrl)
        {
            param = new SqlParameter[6];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "INSERT";
            param[1] = new SqlParameter("@RoleID", SqlDbType.Int);
            param[1].Value = roleID;
            param[2] = new SqlParameter("@ModuleID", SqlDbType.Int);
            param[2].Value = moduleId;
            param[3] = new SqlParameter("@FunctionID", SqlDbType.Int);
            param[3].Value = functionID;
            
            param[4] = new SqlParameter("@FName", SqlDbType.VarChar);
            param[4].Value = fName;
            param[5] = new SqlParameter("@FURL", SqlDbType.VarChar);
            param[5].Value = fUrl;
            

            objCon = new DBConnection();
            return objCon.ExecuteSP("spModuleAccess", param);


        }

        public int DeleteModuleAccess(int roleID, int moduleId, int functionID)
        {

            param = new SqlParameter[4];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "DELETE";
            param[1] = new SqlParameter("@RoleID", SqlDbType.Int);
            param[1].Value = roleID;
            param[2] = new SqlParameter("@ModuleID", SqlDbType.Int);
            param[2].Value = moduleId;
            param[3] = new SqlParameter("@FunctionID", SqlDbType.Int);
            param[3].Value = functionID;

            objCon = new DBConnection();
            return objCon.ExecuteSP("spModuleAccess", param);

        }


    }
}
