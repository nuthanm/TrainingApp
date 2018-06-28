using System;
using System.Windows.Forms;
using BAL_DesktopTrainingAPP;
using System.Data;
using Helpers_DesktopTrainingAPP;
namespace UI_DesktopAppNew.Enquiry
{
    public partial class EnquiryForm : Form
    {
        #region ObjectsCreation
        TrainerDetails _objTrainers;
        Enquiries _objEnquries;
        TraineeTypes _objTraineeTypeDetails;
        DataTable dtTrainers;
        DataTable dtEnquries;
        DataTable dtTrainingTypes;
        #endregion

        public EnquiryForm()
        {
            InitializeComponent();
            this.cmBxTrainers.SelectedIndexChanged -= new EventHandler(cmBxTrainers_SelectedIndexChanged);

            cmBxStatus.SelectedIndex = 0;
            LoadTrainerDetails();
            LoadEnquiryDetails();
            LoadTrainingTypes();
            GetUID();
            this.cmBxTrainers.SelectedIndexChanged += new EventHandler(cmBxTrainers_SelectedIndexChanged);
        }


        private void GetUID()
        {
            Users _objUsers = new Users();
            LoginSuccessDetails.UID = _objUsers.GetUserID(LoginSuccessDetails.userName);
        }
        /// <summary>
        /// Load Trainer Details
        /// </summary>
        private void LoadTrainerDetails()
        {
            dtTrainers = new DataTable();

            _objTrainers = new TrainerDetails();
            dtTrainers = _objTrainers.LoadTrainers();

            DataRow dr = dtTrainers.NewRow();
            dr[0] = 0;
            dr[1] = "-- Select Trainer --";
            dtTrainers.Rows.InsertAt(dr, 0);

            cmBxTrainers.DataSource = dtTrainers;
            cmBxTrainers.DisplayMember = "Name";
            cmBxTrainers.ValueMember = "UserId";

        }

        /// <summary>
        /// Loads Users Details
        /// </summary>
        private void LoadEnquiryDetails()
        {
            dtEnquries = new DataTable();
            _objEnquries = new Enquiries();

            dgEnquiries.DataSource = dtEnquries = _objEnquries.LoadEnquries();
            dgEnquiries.Columns[0].Visible = false;

        }

        private void LoadTrainingTypes()
        {
            dtTrainingTypes = new DataTable();
            //            DataTable dtTypes = new DataTable();
            _objTraineeTypeDetails = new TraineeTypes();
            dtTrainingTypes = _objTraineeTypeDetails.GetTraineeTypes();

            //dgViewTrainingFees.AutoGenerateColumns = false;
            //dgViewTrainingFees.DataSource = dtTypes;


            //dtTrainingTypes = dtTypes.Copy();
            DataRow dr = dtTrainingTypes.NewRow();
            dr[0] = 0;
            dr[1] = "-- Select Training Type --";
            dtTrainingTypes.Rows.InsertAt(dr, 0);

            cmbTraineeTypes.DataSource = dtTrainingTypes;
            cmbTraineeTypes.DisplayMember = "TypeName";
            cmbTraineeTypes.ValueMember = "TrainingTypeId";



        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllControls();
        }

        /// <summary>
        /// Clear all controls
        /// </summary>
        private void ClearAllControls()
        {
            cmBxStatus.SelectedIndex = 0;
            cmBxTrainers.SelectedIndex = 0;
            cmbTraineeTypes.SelectedIndex = 0;

            txtBxTechnology.Text = string.Empty;
            txtBxStudentName.Text = string.Empty;
            txtBxStudentFee.Text = string.Empty;
            txtBxSMobileNo.Text = string.Empty;
            txtBxSEmail.Text = string.Empty;

            txtBxTrainerEmail.Text = string.Empty;
            txtBxTrainerFee.Text = string.Empty;
            txtBxTrainerMobileNo.Text = string.Empty;
            txtBxSearch.Text = string.Empty;
            txtBxRemarks.Text = string.Empty;
            txtStudentReferredBy.Text = string.Empty;
            txtTrainerReferredBy.Text = string.Empty;

            btnEnquiry.Text = "ADD Enquiry";
            btnDelete.Visible = false;
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            int queryResult = -1;
            if (!string.IsNullOrWhiteSpace(txtBxTechnology.Text) &&
                !string.IsNullOrWhiteSpace(txtBxStudentName.Text) &&
                !string.IsNullOrWhiteSpace(txtBxStudentFee.Text) &&
                !string.IsNullOrWhiteSpace(txtBxSMobileNo.Text) &&
                !string.IsNullOrWhiteSpace(txtBxSEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtBxTrainerEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtBxTrainerFee.Text) &&
                !string.IsNullOrWhiteSpace(txtBxTrainerMobileNo.Text) &&
                cmBxTrainers.SelectedIndex > 0 &&
                cmBxStatus.SelectedIndex > 0 &&
                cmbTraineeTypes.SelectedIndex > 0
                )
            {
                _objEnquries = new Enquiries();

                _objEnquries.Technology = txtBxTechnology.Text;
                _objEnquries.StudentEmail = txtBxSEmail.Text;
                _objEnquries.StudentFee = Convert.ToDecimal(txtBxStudentFee.Text);
                _objEnquries.StudentMobile = Convert.ToInt64(txtBxSMobileNo.Text);
                _objEnquries.StudentName = txtBxStudentName.Text;

                _objEnquries.TrainerEmail = txtBxTrainerEmail.Text;
                _objEnquries.TrainerFee = Convert.ToDecimal(txtBxTrainerFee.Text);
                _objEnquries.TrainerMobile = Convert.ToInt64(txtBxTrainerMobileNo.Text);
                _objEnquries.TrainerName = cmBxTrainers.Text;
                _objEnquries.TraineeTypeId = Convert.ToInt32(cmbTraineeTypes.SelectedValue);
                _objEnquries.EnquiryStatus = cmBxStatus.Text;
                _objEnquries.Remarks = txtBxRemarks.Text;
                _objEnquries.LastModifiedBy = LoginSuccessDetails.UID;
                
                _objEnquries.StudentReferredBy = txtStudentReferredBy.Text;
                _objEnquries.TrainerReferredBy = txtTrainerReferredBy.Text;
                
                if (btnEnquiry.Text.ToUpper().Contains("ADD"))
                {
                    queryResult = _objEnquries.CreateEnquiry(_objEnquries);
                }
                else
                {
                    _objEnquries.EID = Convert.ToInt32(dgEnquiries.CurrentRow.Cells["EID"].Value.ToString());
                    queryResult = _objEnquries.UpdateEnquiry(_objEnquries);
                }

                if (queryResult > 0)
                {
                    LoadEnquiryDetails();
                    ClearAllControls();
                }
            }
            else
            {
                MessageBox.Show("Please enter missed fields", "Enquiry Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this enquiry Details : " + dgEnquiries.CurrentRow.Cells["EID"].Value.ToString(), "User Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _objEnquries = new Enquiries();
                int queryResult = _objEnquries.DeleteEnquiry(Convert.ToInt32(dgEnquiries.CurrentRow.Cells["EID"].Value.ToString()));
                if (queryResult > 0)
                {
                    LoadEnquiryDetails();
                    ClearAllControls();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllControls();
        }

        private void EnquiryForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBxTechnology;
            btnDelete.Visible = false;
            dgEnquiries.CurrentRow.Selected = false;
            //LoadEnquiryDetails();
        }

        private void dgEnquiries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgEnquiries.CurrentRow;

            txtBxTechnology.Text = selectedRow.Cells["Technology"].Value.ToString();
            txtBxStudentName.Text = selectedRow.Cells["SName"].Value.ToString();
            txtBxStudentFee.Text = selectedRow.Cells["SFee"].Value.ToString();
            txtBxSMobileNo.Text = selectedRow.Cells["SPhoneNo"].Value.ToString();
            txtBxSEmail.Text = selectedRow.Cells["SEmail"].Value.ToString();

            txtBxTrainerFee.Text = selectedRow.Cells["TFee"].Value.ToString();
            txtBxTrainerEmail.Text = selectedRow.Cells["TEmail"].Value.ToString();
            txtBxTrainerMobileNo.Text = selectedRow.Cells["TPhoneNo"].Value.ToString();
            cmBxTrainers.Text = selectedRow.Cells["TName"].Value.ToString();
            cmBxStatus.Text = selectedRow.Cells["Status"].Value.ToString();
            cmbTraineeTypes.Text = selectedRow.Cells["TypeName"].Value.ToString();
            txtBxRemarks.Text = selectedRow.Cells["Remarks"].Value != null ? selectedRow.Cells["Remarks"].Value.ToString() : string.Empty;
            txtStudentReferredBy.Text = selectedRow.Cells["StudentReferredBy"].Value.ToString();
            txtTrainerReferredBy.Text = selectedRow.Cells["TrainerReferredBy"].Value.ToString();
            btnEnquiry.Text = "UPDATE";
            //btnDelete.Visible = true;
        }

        private void txtBxSMobileNo_Leave(object sender, EventArgs e)
        {
            Common.AllowNumeric(txtBxSMobileNo, "Student Mobile", "Enquiry Form");
        }

        private void txtBxTrainerMobileNo_Leave(object sender, EventArgs e)
        {
            Common.AllowNumeric(txtBxSMobileNo, "Trainer Mobile", "Enquiry Form");
        }

        private void txtBxStudentFee_Leave(object sender, EventArgs e)
        {
            Common.AllowNumericForFee(txtBxStudentFee, "Student Fee", "Enquiry Form");
        }

        private void txtBxTrainerFee_Leave(object sender, EventArgs e)
        {
            Common.AllowNumericForFee(txtBxTrainerFee, "Trainer Fee", "Enquiry Form");
        }

        private void txtBxSEmail_Leave(object sender, EventArgs e)
        {
            Common.EmailValidation(txtBxSEmail, "Student Email", "Enquiry Form");
        }

        private void txtBxTrainerEmail_Leave(object sender, EventArgs e)
        {
            Common.EmailValidation(txtBxTrainerEmail, "Trainer Email", "Enquiry Form");
        }

        private void cmBxTrainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgViewTrainingFees.DataSource = _objTraineeTypeDetails.GetTrainerFeeDetails(Convert.ToInt32(cmBxTrainers.SelectedValue));
        }


    }
}
