using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL_DesktopTrainingAPP;

namespace UI_DesktopAppNew.Notifications
{
    public partial class MailChimpDetails : Form
    {
        #region ObjectsCreation
        DataTable dtRows;
        NewsLetterBLL _objNewsLetter;
        int ENid = -1;
        #endregion

        public MailChimpDetails()
        {
            InitializeComponent();
            LoadMarketingDetails();
        }

        private void MailChimp_Details_Load(object sender, EventArgs e)
        {


            toolTipEmailMarketing.SetToolTip(txtUserName, "Enter your User Name");
            toolTipEmailMarketing.SetToolTip(txtPassword, "Enter your Password");
            toolTipEmailMarketing.SetToolTip(txtApiKey, "Enter your API KEY");
            toolTipEmailMarketing.SetToolTip(txtAcceptType, "Enter Accept Type");
            toolTipEmailMarketing.SetToolTip(txtContentType, "Enter Content Type");
            toolTipEmailMarketing.SetToolTip(txtVersion, "Enter version like V2.0, V3.0,...");

        }

        private void LoadMarketingDetails()
        {
            _objNewsLetter = new NewsLetterBLL();
            dtRows = _objNewsLetter.GetEmailMarketingDetails();
            if (dtRows != null)
            {
                if (dtRows.Rows.Count > 0)
                {
                    txtUserName.Text = dtRows.Rows[0]["UserName"].ToString();
                    txtPassword.Text = dtRows.Rows[0]["Password"].ToString();
                    txtAcceptType.Text = dtRows.Rows[0]["AcceptType"].ToString();
                    txtContentType.Text = dtRows.Rows[0]["ContentType"].ToString();
                    txtVersion.Text = dtRows.Rows[0]["APIVersion"].ToString();
                    txtEmail.Text = dtRows.Rows[0]["Email"].ToString();
                    txtApiKey.Text = dtRows.Rows[0]["ApiKey"] == null ? null : dtRows.Rows[0]["ApiKey"].ToString();
                    btnAddDetails.Text = "Update Details";
                    btnReset.Text = "Delete Details";
                    ENid = Convert.ToInt32(dtRows.Rows[0]["NID"].ToString());
                }
            }
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text.Length > 0 && !string.IsNullOrWhiteSpace(txtUserName.Text)) && (txtPassword.Text.Length > 0 && !string.IsNullOrWhiteSpace(txtPassword.Text)) && (txtAcceptType.Text.Length > 0 && !string.IsNullOrWhiteSpace(txtAcceptType.Text)) && (txtContentType.Text.Length > 0 && !string.IsNullOrWhiteSpace(txtContentType.Text)) && (txtVersion.Text.Length > 0 && !string.IsNullOrWhiteSpace(txtVersion.Text)) && (txtEmail.Text.Length > 0 && !string.IsNullOrWhiteSpace(txtEmail.Text)))
            {
                EmailMarketing objEMarketing = new EmailMarketing();

                objEMarketing.EUserName = txtUserName.Text.Trim();
                objEMarketing.EPassword = txtPassword.Text.Trim();
                objEMarketing.EAcceptType = txtAcceptType.Text.Trim();
                objEMarketing.EContentType = txtContentType.Text.Trim();
                objEMarketing.EEmail = txtEmail.Text.Trim();
                objEMarketing.EAPIKEY = txtApiKey.Text.Trim();
                objEMarketing.EAPIVersion = txtVersion.Text.Trim();

                _objNewsLetter = new NewsLetterBLL();

                int result = -1;
                string type = string.Empty;
                if (btnAddDetails.Text.Contains("Add"))
                {
                    result = _objNewsLetter.CreateEmailNewsLetter(objEMarketing);
                    type = "Insert";
                }
                else
                {
                    if (ENid != -1)
                    {
                        objEMarketing.ENID = ENid;
                        result = _objNewsLetter.UpdateEmailNewsLetter(objEMarketing);
                        type = "Update";
                    }
                    else
                    {
                        MessageBox.Show("Email NewsLetter details are something wrong.");
                        return;
                    }
                }

                if (result.Equals(1) && type.Equals("Insert"))
                {
                    lblMessage.Text = "Email Marketing Details are added successfully.";
                    btnAddDetails.Text = "Update Details";

                }
                else
                {
                    lblMessage.Text = "Email Marketing Details are updated successfully.";

                }
                lblMessage.ForeColor = Color.Green;
                LoadMarketingDetails();
            }
            else
            {
                MessageBox.Show("Please Enter the missed fields before adding.");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text.Contains("Reset"))
                ClearAllControls();
            else
            {
                if (MessageBox.Show("Are you sure want to delete?", "MailChimp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _objNewsLetter = new NewsLetterBLL();
                    int result = _objNewsLetter.DeleteEmailNewsLetter(ENid);
                    if (result > 0)
                    {
                        MessageBox.Show("Deleted Successfully.", "MailChimp", MessageBoxButtons.OK);
                        ClearAllControls();
                    }
                }
            }

        }

        private void ClearAllControls()
        {
            btnAddDetails.Text = "Add Details";
            btnReset.Text = "Reset";

            txtAcceptType.Text = string.Empty;
            txtApiKey.Text = string.Empty;
            txtContentType.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtVersion.Text = string.Empty;
        }


    }
}
