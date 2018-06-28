using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL_DesktopTrainingAPP;

namespace UI_DesktopAppNew.Security
{
    public partial class Transactions : Form
    {
        #region Objects
        DataTable dtValues;
        BAL_DesktopTrainingAPP.TrainerDetails _objTrainers;

        BAL_DesktopTrainingAPP.TransactionDetails objTransDetails;

        #endregion

        public Transactions()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dtValues = new DataTable();
            _objTrainers = new TrainerDetails();


            dtValues = _objTrainers.LoadTrainers();
            DataRow dr = dtValues.NewRow();
            dr[0] = 0;
            dr[1] = "-- Select User --";
            dtValues.Rows.InsertAt(dr, 0);


            cmbUsers.DataSource = dtValues;
            cmbUsers.DisplayMember = "Name";
            cmbUsers.ValueMember = "UserId";

        }
        private void btnAddTransactions_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtModeofPayment.Text) &&
                !string.IsNullOrWhiteSpace(txtTransactionAmount.Text) &&
                !string.IsNullOrWhiteSpace(txtTransactionID.Text) &&
                cmbPaymentStatus.SelectedIndex > 0 &&
                cmbUsers.SelectedIndex > 0)
            {
                TransDetails objTrxDetails = new TransDetails();
                objTrxDetails.ModeofPayment = txtModeofPayment.Text;
                objTrxDetails.TransactionAmount = Convert.ToDecimal(txtTransactionAmount.Text);
                objTrxDetails.TransactionID = txtTransactionID.Text;
                objTrxDetails.PaymentStatus = cmbPaymentStatus.Text;
                objTrxDetails.UserId = Convert.ToInt32(cmbUsers.SelectedValue);
                objTrxDetails.TransferDate = Convert.ToDateTime(dtpTransferDate.Text);
                objTrxDetails.Remarks = txtRemarks.Text;

                objTransDetails = new TransactionDetails();
                int result = 0;
                string statusMsg = string.Empty;
                if (btnAddTransactions.Text.ToUpper().Contains("ADD"))
                {
                    result = objTransDetails.CreateTransaction(objTrxDetails);
                    statusMsg = "Added new Transaction Details successfully.";
                }

                if (result > 0)
                {
                    ClearAllControls();
                    MessageBox.Show(statusMsg, "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Transaction Fields", "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllControls();
        }

        private void ClearAllControls()
        {
            txtTransactionAmount.Text = string.Empty;
            txtModeofPayment.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtTransactionID.Text = string.Empty;
            cmbPaymentStatus.SelectedIndex = -1;
            cmbUsers.SelectedIndex = -1;
            btnAddTransactions.Text = "Add Transactions";
        }

    }
}
