using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_DesktopTrainingAPP;
using System.Data.SqlClient;

namespace BAL_DesktopTrainingAPP
{
    public class TransDetails
    {
        public int TranxID { get; set; }
        public string TransactionID { get; set; }
        public string ModeofPayment { get; set; }
        public string PaymentStatus { get; set; }
        public decimal TransactionAmount { get; set; }
        public string Remarks { get; set; }
        public int UserId { get; set; }
        public DateTime TransferDate { get; set; }
    }
    public class TransactionDetails
    {

        #region ObjectsCreation
        DataTable dtTransactions;
        DBConnection objCon;
        int queryResult = -1;
        SqlParameter[] param;
        #endregion

        public DataTable GetSingleTransaction(int trxID)
        {
            objCon = new DBConnection();
            param = new SqlParameter[2];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "SELECTONE";
            param[0] = new SqlParameter("@TXID", SqlDbType.Int);
            param[0].Value = trxID;
            return objCon.ExecuteGetSP("spTransactions", param);
        }

        public DataTable GetTransactions()
        {
            objCon = new DBConnection();
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[0].Value = "SELECT";
            return objCon.ExecuteGetSP("spTransactions", param);
        }

        public int CreateTransaction(TransDetails objTrans)
        {
            objCon = new DBConnection();
            param = new SqlParameter[8];

            param[0] = new SqlParameter("@TransactionID", SqlDbType.VarChar);
            param[0].Value = objTrans.TransactionID;

            param[1] = new SqlParameter("@TrxAmount", SqlDbType.Decimal);
            param[1].Value = objTrans.TransactionAmount;

            param[2] = new SqlParameter("@ModeofPayment", SqlDbType.VarChar);
            param[2].Value = objTrans.ModeofPayment;

            param[3] = new SqlParameter("@PaymentStatus", SqlDbType.VarChar);
            param[3].Value = objTrans.PaymentStatus;
                        
            param[4] = new SqlParameter("@Remarks", SqlDbType.VarChar);
            param[4].Value = objTrans.Remarks;

            param[5] = new SqlParameter("@UserId", SqlDbType.Int);
            param[5].Value = objTrans.UserId;

            param[6] = new SqlParameter("@TransferDate", SqlDbType.DateTime);
            param[6].Value = objTrans.TransferDate;

            param[7] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[7].Value = "INSERT";

            return objCon.ExecuteSP("spTransactions", param);
        }

        public int UpdateTransaction(TransDetails objTrans)
        {

            objCon = new DBConnection();
            param = new SqlParameter[9];

            param[0] = new SqlParameter("@TransactionID", SqlDbType.VarChar);
            param[0].Value = objTrans.TransactionID;

            param[1] = new SqlParameter("@TrxAmount", SqlDbType.Decimal);
            param[1].Value = objTrans.TransactionAmount;

            param[2] = new SqlParameter("@ModeofPayment", SqlDbType.VarChar);
            param[2].Value = objTrans.ModeofPayment;

            param[3] = new SqlParameter("@PaymentStatus", SqlDbType.VarChar);
            param[3].Value = objTrans.PaymentStatus;
                        
            param[4] = new SqlParameter("@Remarks", SqlDbType.VarChar);
            param[4].Value = objTrans.Remarks;

            param[5] = new SqlParameter("@UserId", SqlDbType.Int);
            param[5].Value = objTrans.UserId;

            param[6] = new SqlParameter("@TransferDate", SqlDbType.DateTime);
            param[6].Value = objTrans.TransferDate;

            param[7] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            param[7].Value = "UPDATE";

            param[8] = new SqlParameter("@TXID", SqlDbType.Int);
            param[8].Value = objTrans.TranxID;

            return objCon.ExecuteSP("spTransactions", param);
        }

    }
}
