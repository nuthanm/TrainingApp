using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL_DesktopTrainingAPP
{
    public class DBConnection
    {
        #region DBObjects
        SqlConnection sqlCon;
        SqlDataAdapter sqlADP;
        DataTable dtResults = null;
        int queryResult = -1;
        #endregion
        public DBConnection()
        {
            try
            {
                //sqlADP = new SqlDataAdapter();
                sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }


        /// <summary>
        /// Execute Inline Queries and send result in datatable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable ExecuteSelectQuery(string query)
        {
            using (sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString()))
            {
                if (dtResults == null)
                    dtResults = new DataTable();
                sqlADP = new SqlDataAdapter(query, sqlCon);
                sqlADP.Fill(dtResults);
            }

            return dtResults;
        }

        /// <summary>
        /// Insert/Update/Delete
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int ExecuteQuery(string query)
        {
            using (sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString()))
            {
                SqlCommand objCmd = new SqlCommand(query, sqlCon);
                sqlCon.Open();
                queryResult = objCmd.ExecuteNonQuery();
            }

            return queryResult;
        }

        /// <summary>
        /// Returns Integer value
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int ExecuteInlineSelectQuery(string query)
        {
            using (sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString()))
            {
                sqlCon.Open();
                sqlADP = new SqlDataAdapter(query, sqlCon);
                queryResult = (int)sqlADP.SelectCommand.ExecuteScalar();
            }

            return queryResult;
        }

        /// <summary>
        /// Execute Stored Procedures - SELECT
        /// </summary>
        /// <param name="spProcedure"></param>
        /// <returns></returns>
        public DataTable ExecuteSelectSP(string spProcedure)
        {
            using (sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString()))
            {
                sqlADP = new SqlDataAdapter(spProcedure, sqlCon);
                sqlADP.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlADP.Fill(dtResults);
            }
            return dtResults;
        }

        /// <summary>
        /// Execute Insert/Update/Delete operations using Stored Procedure
        /// </summary>
        /// <param name="spProcedure"></param>
        /// <param name="operationType"></param>
        /// <returns></returns>
        public int ExecuteSP(string spProcedure, SqlParameter[] parameters)
        {
            using (sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString()))
            {
                sqlCon.Open();
                SqlCommand objCommand = new SqlCommand(spProcedure, sqlCon);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddRange(parameters);
                queryResult = objCommand.ExecuteNonQuery();

            }
            return queryResult;
        }

        public DataTable ExecuteGetSP(string spProcedure, SqlParameter[] parameters)
        {
            dtResults = new DataTable();

            using (sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString()))
            {
                sqlADP = new SqlDataAdapter(spProcedure, sqlCon);
                sqlADP.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlADP.SelectCommand.Parameters.AddRange(parameters);
                sqlADP.Fill(dtResults);

            }
            return dtResults;
        }

        public int ExecuteGetSingleValueSP(string spProcedure, SqlParameter[] parameters)
        {
            int result = 0;
            dtResults = new DataTable();
            using (sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString()))
            {
                sqlADP = new SqlDataAdapter(spProcedure, sqlCon);
                sqlADP.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlADP.SelectCommand.Parameters.AddRange(parameters);
                sqlADP.Fill(dtResults);

                result = Convert.ToInt32(dtResults.Rows[0][0].ToString());

            }
            return result;
        }
    }
}
