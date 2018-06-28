using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_DesktopTrainingAPP;
using System.Data;
using System.Data.SqlClient;

namespace BAL_DesktopTrainingAPP
{
    public class Enquiries
    {

        DataTable dtEnquries;
        DBConnection _objCon;
        SqlParameter[] parameters;
        int queryResult = -1;

        #region properties
        public int EID { get; set; }
        public string Technology { get; set; }
        public string StudentName { get; set; }
        public decimal StudentFee { get; set; }
        public string StudentEmail { get; set; }
        public long StudentMobile { get; set; }
        public string TrainerName { get; set; }
        public decimal TrainerFee { get; set; }
        public long TrainerMobile { get; set; }
        public string TrainerEmail { get; set; }
        public string EnquiryStatus { get; set; }
        public string Remarks { get; set; }
        public int LastModifiedBy { get; set; }
        public int TraineeTypeId { get; set; }
        public string StudentReferredBy { get; set; }
        public string TrainerReferredBy { get; set; }
        #endregion

        public DataTable LoadEnquries()
        {
            _objCon = new DBConnection();
            dtEnquries = new DataTable("Enquiries");

            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            parameters[0].Value = "ALL";

            dtEnquries = _objCon.ExecuteGetSP("spGetEnquiryDetails", parameters);
            return dtEnquries;

        }

        public int CreateEnquiry(Enquiries objEnquiries)
        {
            _objCon = new DBConnection();

            parameters = new SqlParameter[16];
            parameters[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            parameters[0].Value = "INSERT";

            parameters[1] = new SqlParameter("@SName", SqlDbType.VarChar);
            parameters[1].Value = objEnquiries.StudentName;

            parameters[2] = new SqlParameter("@SPhoneNo", SqlDbType.BigInt);
            parameters[2].Value = objEnquiries.StudentMobile;

            parameters[3] = new SqlParameter("@SEmail", SqlDbType.VarChar);
            parameters[3].Value = objEnquiries.StudentEmail;

            parameters[4] = new SqlParameter("@SFee", SqlDbType.Decimal);
            parameters[4].Value = objEnquiries.StudentFee;

            parameters[5] = new SqlParameter("@TName", SqlDbType.VarChar);
            parameters[5].Value = objEnquiries.TrainerName;
            parameters[6] = new SqlParameter("@TPhoneNo", SqlDbType.BigInt);
            parameters[6].Value = objEnquiries.TrainerMobile;
            parameters[7] = new SqlParameter("@TEmail", SqlDbType.VarChar);
            parameters[7].Value = objEnquiries.TrainerEmail;

            parameters[8] = new SqlParameter("@Status", SqlDbType.VarChar);
            parameters[8].Value = objEnquiries.EnquiryStatus;

            parameters[9] = new SqlParameter("@Technology", SqlDbType.VarChar);
            parameters[9].Value = objEnquiries.Technology;
            parameters[10] = new SqlParameter("@Remarks", SqlDbType.VarChar);
            parameters[10].Value = objEnquiries.Remarks;

            parameters[11] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            parameters[11].Value = objEnquiries.LastModifiedBy;

            parameters[12] = new SqlParameter("@TFee", SqlDbType.Decimal);
            parameters[12].Value = objEnquiries.TrainerFee;

            parameters[13] = new SqlParameter("@TraineeTypeId", SqlDbType.Int);
            parameters[13].Value = objEnquiries.TraineeTypeId;

            parameters[14] = new SqlParameter("@StudentReferredBy", SqlDbType.VarChar);
            parameters[14].Value = objEnquiries.StudentReferredBy;

            parameters[15] = new SqlParameter("@TrainerReferredBy", SqlDbType.VarChar);
            parameters[15].Value = objEnquiries.TrainerReferredBy;

            return _objCon.ExecuteSP("spEnquires", parameters);
        }


        public int UpdateEnquiry(Enquiries objEnquiries)
        {

            _objCon = new DBConnection();

            parameters = new SqlParameter[17];

            parameters[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            parameters[0].Value = "UPDATE";

            parameters[1] = new SqlParameter("@SName", SqlDbType.VarChar);
            parameters[1].Value = objEnquiries.StudentName;

            parameters[2] = new SqlParameter("@SPhoneNo", SqlDbType.BigInt);
            parameters[2].Value = objEnquiries.StudentMobile;

            parameters[3] = new SqlParameter("@SEmail", SqlDbType.VarChar);
            parameters[3].Value = objEnquiries.StudentEmail;

            parameters[4] = new SqlParameter("@SFee", SqlDbType.Decimal);
            parameters[4].Value = objEnquiries.StudentFee;

            parameters[5] = new SqlParameter("@TName", SqlDbType.VarChar);
            parameters[5].Value = objEnquiries.TrainerName;

            parameters[6] = new SqlParameter("@TPhoneNo", SqlDbType.BigInt);
            parameters[6].Value = objEnquiries.TrainerMobile;

            parameters[7] = new SqlParameter("@TEmail", SqlDbType.VarChar);
            parameters[7].Value = objEnquiries.TrainerEmail;

            parameters[8] = new SqlParameter("@Status", SqlDbType.VarChar);
            parameters[8].Value = objEnquiries.EnquiryStatus;

            parameters[9] = new SqlParameter("@Technology", SqlDbType.VarChar);
            parameters[9].Value = objEnquiries.Technology;

            parameters[10] = new SqlParameter("@Remarks", SqlDbType.VarChar);
            parameters[10].Value = objEnquiries.Remarks;

            parameters[11] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            parameters[11].Value = objEnquiries.LastModifiedBy;

            parameters[12] = new SqlParameter("@EID", SqlDbType.Int);
            parameters[12].Value = objEnquiries.EID;

            parameters[13] = new SqlParameter("@TFee", SqlDbType.Decimal);
            parameters[13].Value = objEnquiries.TrainerFee;

            parameters[14] = new SqlParameter("@TraineeTypeId", SqlDbType.Int);
            parameters[14].Value = objEnquiries.TraineeTypeId;


            parameters[15] = new SqlParameter("@StudentReferredBy", SqlDbType.VarChar);
            parameters[15].Value = objEnquiries.StudentReferredBy;

            parameters[16] = new SqlParameter("@TrainerReferredBy", SqlDbType.VarChar);
            parameters[16].Value = objEnquiries.TrainerReferredBy;

            return _objCon.ExecuteSP("spEnquires", parameters);
        }


        public int DeleteEnquiry(int eid)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ActionType", SqlDbType.VarChar);
            parameters[0].Value = "DELETE";

            parameters[0] = new SqlParameter("@EID", SqlDbType.Int);
            parameters[0].Value = eid;

            return _objCon.ExecuteSP("spEnquires", parameters);
        }
    }
}
