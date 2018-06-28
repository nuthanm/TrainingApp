using System;
using System.Windows.Forms;
using BAL_DesktopTrainingAPP;
using System.Data;
using System.Text.RegularExpressions;
using Helpers_DesktopTrainingAPP;
namespace UI_DesktopAppNew.Security
{
    public partial class UsersCreation : Form
    {
        #region ObjectsCreation
        Users _objUsers;
        UserDetails _objUserDetails;
        UserLogin _objLoginDetails;
        UserType _objUserTypes;
        BankDetails _objBankDetails;
        DataTable dtValues;
        DataTable dtUsers;
        string lastUserName = string.Empty;
        #endregion

        public UsersCreation()
        {
            InitializeComponent();
            LoadUserDetails();
            LoadUserTypes();
            cmbUserActive.SelectedIndex = 0;
            cmbBankAccountActive.SelectedIndex = 0;
            
            //txtBxFirstName.Focus();
        }

        #region CustomFunctions
        /// <summary>
        /// Values are Trainer/Student/Employee/Admin
        /// </summary>
        private void LoadUserTypes()
        {
            dtValues = new DataTable();
            _objUsers = new Users();
            dtValues = _objUsers.GetUserTypes();

            DataRow dr = dtValues.NewRow();
            dr[0] = 0;
            dr[1] = "-- Select UserType --";
            dtValues.Rows.InsertAt(dr, 0);

            cmBxUserTypes.DataSource = dtValues;
            cmBxUserTypes.DisplayMember = "UserType";
            cmBxUserTypes.ValueMember = "TypeID";
            //cmBxUserTypes.SelectedIndex = -1;
        }

        /// <summary>
        /// Loads Users Details
        /// </summary>
        private void LoadUserDetails()
        {
            dtUsers = new DataTable();

            _objUsers = new Users();
            dgUsersView.DataSource = null;
            dgUsersView.AutoGenerateColumns = false;
            //Set Columns Count
            dgUsersView.ColumnCount = 8;

            dgUsersView.Columns[0].Name = "UserId";
            dgUsersView.Columns[0].HeaderText = "User Id";
            dgUsersView.Columns[0].DataPropertyName = "UserId";

            dgUsersView.Columns[1].HeaderText = "User Name";
            dgUsersView.Columns[1].Name = "UserName";
            dgUsersView.Columns[1].DataPropertyName = "UserName";


            dgUsersView.Columns[2].Name = "FirstName";
            dgUsersView.Columns[2].HeaderText = "First Name";
            dgUsersView.Columns[2].DataPropertyName = "FirstName";

            dgUsersView.Columns[3].Name = "LastName";
            dgUsersView.Columns[3].HeaderText = "Last Name";
            dgUsersView.Columns[3].DataPropertyName = "LastName";

            dgUsersView.Columns[4].Name = "Email";
            dgUsersView.Columns[4].HeaderText = "Email Address";
            dgUsersView.Columns[4].DataPropertyName = "Email";
            dgUsersView.Columns[4].Width = 200;


            dgUsersView.Columns[5].Name = "Mobile";
            dgUsersView.Columns[5].HeaderText = "Mobile Number";
            dgUsersView.Columns[5].DataPropertyName = "MobileNumber";

            dgUsersView.Columns[6].Name = "User Status";
            dgUsersView.Columns[6].HeaderText = "User Status";
            dgUsersView.Columns[6].DataPropertyName = "User Status";

            dgUsersView.Columns[7].Name = "User Type";
            dgUsersView.Columns[7].HeaderText = "User Type";
            dgUsersView.Columns[7].DataPropertyName = "Type of User";

            dgUsersView.DataSource = dtUsers = _objUsers.GetUsers();
            dgUsersView.Columns[0].Visible = false;



        }

        #endregion

        #region ClosetheApplication
        /// <summary>
        /// On click of Menu=Exit application closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region ClearScreen
        /// <summary>
        /// To clear all the controls on click of Reset Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllControls();
        }

        /// <summary>
        /// Function to clear all the controls
        /// </summary>
        private void ClearAllControls()
        {
            cmBxUserTypes.SelectedIndex = 0;
            cmbUserActive.SelectedIndex = 0;
            cmbBankAccountActive.SelectedIndex = 0;

            txtBxFirstName.Text = string.Empty;
            txtBxFirstName.Enabled = true;
            txtBxFirstName.Focus();
            txtBxLastName.Text = string.Empty;
            txtBxLastName.Enabled = true;
            txtBxEmail.Text = string.Empty;
            txtBxPassword.Text = string.Empty;
            txtBxUserName.Text = string.Empty;
            txtBxAddress1.Text = string.Empty;
            txtBxAddress2.Text = string.Empty;
            txtBxCity.Text = string.Empty;
            txtBxState.Text = string.Empty;
            txtBxCountry.Text = string.Empty;
            txtBxPincode.Text = string.Empty;
            txtBxMobile.Text = string.Empty;

            txtBAccName.Text = string.Empty;
            txtBAccNumber.Text = string.Empty;
            txtBankBranch.Text = string.Empty;
            txtBankName.Text = string.Empty;
            txtIFSCCode.Text = string.Empty;
            btnDelete.Visible = false;
            btnUser.Text = "ADD USER";
            dgUsersView.CurrentRow.Selected = false;
        }
        #endregion


        #region ADD_OR_UPDATE
        /// <summary>
        /// Either ADD or UPDATE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBxFirstName.Text) &&
                !string.IsNullOrEmpty(txtBxLastName.Text) &&
                !string.IsNullOrEmpty(txtBxEmail.Text) &&
                !string.IsNullOrEmpty(txtBxPassword.Text) &&
                !string.IsNullOrEmpty(txtBxUserName.Text) &&
                !string.IsNullOrEmpty(txtBxAddress1.Text) &&
                !string.IsNullOrEmpty(txtBxAddress2.Text) &&
                !string.IsNullOrEmpty(txtBxCity.Text) &&
                !string.IsNullOrEmpty(txtBxState.Text) &&
                !string.IsNullOrEmpty(txtBxCountry.Text) &&
                !string.IsNullOrEmpty(txtBxPincode.Text) &&
                !string.IsNullOrEmpty(txtBxMobile.Text) &&
                cmBxUserTypes.SelectedIndex > 0 &&
                !string.IsNullOrEmpty(txtBAccName.Text) &&
                !string.IsNullOrEmpty(txtBAccNumber.Text) &&
                !string.IsNullOrEmpty(txtBankBranch.Text) &&
                !string.IsNullOrEmpty(txtBankName.Text) &&
                !string.IsNullOrEmpty(txtIFSCCode.Text) &&
                cmbBankAccountActive.SelectedIndex > 0 &&
                cmbUserActive.SelectedIndex > 0)
            {
                _objUsers = new Users();
                _objUserDetails = new UserDetails();
                _objLoginDetails = new UserLogin();
                _objUserTypes = new UserType();
                _objBankDetails = new BankDetails();

                _objLoginDetails.UserName = txtBxUserName.Text;
                _objLoginDetails.Password = txtBxPassword.Text;
                _objLoginDetails.Email = txtBxEmail.Text;

                _objUserDetails.FirstName = txtBxFirstName.Text;
                _objUserDetails.LastName = txtBxLastName.Text;
                _objUserDetails.AddressLine1 = txtBxAddress1.Text;
                _objUserDetails.AddressLine2 = txtBxAddress2.Text;
                _objUserDetails.City = txtBxCity.Text;
                _objUserDetails.State = txtBxState.Text;
                _objUserDetails.Country = txtBxCountry.Text;
                _objUserDetails.Pincode = Convert.ToInt32(txtBxPincode.Text);
                _objUserDetails.MobileNumber = Convert.ToInt64(txtBxMobile.Text);
                _objUserTypes.UserTypeId = Convert.ToInt32(cmBxUserTypes.SelectedValue);

                _objBankDetails.BankAccountName = txtBAccName.Text;
                _objBankDetails.BankAccountNumber = txtBAccNumber.Text;
                _objBankDetails.BankBranch = txtBankBranch.Text;
                _objBankDetails.BankIFSCCode = txtIFSCCode.Text;
                _objBankDetails.BankName = txtBankName.Text;
                _objUserDetails.isActive = cmbUserActive.Text == "No" ? false : true;

                _objBankDetails.isActive = cmbBankAccountActive.Text == "No" ? false : true;

                int result = 0;
                if (btnUser.Text.ToUpper().Contains("ADD"))
                {
                    result = _objUsers.CreateUser(_objUserDetails, _objLoginDetails, _objUserTypes, _objBankDetails);
                }
                else
                {
                    _objUserDetails.UserId = Convert.ToInt32(dgUsersView.CurrentRow.Cells["UserId"].Value.ToString());
                    result = _objUsers.UpdateUser(_objUserDetails, _objLoginDetails, _objUserTypes, _objBankDetails);

                }
                //if (result > 0)
                //{
                //    MessageBox.Show("User added successfully");
                LoadUserDetails();
                ClearAllControls();
                //}
            }
            else
            {
                MessageBox.Show("Please Enter the missing fields.", " Alert While User Creation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        /// <summary>
        /// Filter rows based on user name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dtUsers != null)
            {
                dgUsersView.DataSource = Common.dvSearchData(dtUsers, "UserName", txtBxSearch);
            }
        }



        private void dgUsersView_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = dgUsersView.CurrentRow;
            DataTable dtRows = _objUsers.GetUsers(Convert.ToInt32(selectedRow.Cells["UserId"].Value.ToString()));
            if (dtRows != null)
            {
                if (dtRows.Rows.Count > 0)
                {
                    cmBxUserTypes.SelectedValue = dtRows.Rows[0]["UserType"].ToString();
                    cmbUserActive.Text = dtRows.Rows[0]["IsActive"].Equals(true) ? "Yes" : "No";
                    //selectedRow.Cells["IsActive"].Value.ToString();


                    txtBxFirstName.Text = dtRows.Rows[0]["FirstName"].ToString();
                    txtBxFirstName.Enabled = false;
                    txtBxLastName.Text = dtRows.Rows[0]["LastName"].ToString();
                    txtBxLastName.Enabled = false;
                    txtBxEmail.Text = dtRows.Rows[0]["Email"].ToString();
                    txtBxPassword.Text = dtRows.Rows[0]["Password"].ToString();
                    lastUserName = txtBxUserName.Text = dtRows.Rows[0]["UserName"].ToString();
                    txtBxAddress1.Text = dtRows.Rows[0]["AddressLine1"].ToString();
                    txtBxAddress2.Text = dtRows.Rows[0]["AddressLine1"].ToString();
                    txtBxCity.Text = dtRows.Rows[0]["City"].ToString();
                    txtBxState.Text = dtRows.Rows[0]["State"].ToString();
                    txtBxCountry.Text = dtRows.Rows[0]["Country"].ToString();
                    txtBxPincode.Text = dtRows.Rows[0]["Pincode"].ToString();
                    txtBxMobile.Text = dtRows.Rows[0]["MobileNumber"].ToString();

                    txtBAccName.Text = dtRows.Rows[0]["BankAccountName"].ToString();
                    txtBAccNumber.Text = dtRows.Rows[0]["BankAccNo"].ToString();
                    txtBankBranch.Text = dtRows.Rows[0]["BankBranch"].ToString();
                    txtBankName.Text = dtRows.Rows[0]["BankName"].ToString();
                    txtIFSCCode.Text = dtRows.Rows[0]["BankIFSC"].ToString();
                    cmbBankAccountActive.Text = dtRows.Rows[0]["BankIsActive"].Equals(true) ? "Yes" : "No";
                    //txtReferredBy.Text = dtRows.Rows[0]["ReferredBy"].ToString();
                }
            }

            btnDelete.Visible = true;
            btnUser.Text = "UPDATE USER";

        }

        private void dgUsersView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow selectedRow = dgUsersView.CurrentRow;
            
            ////    DataTable dtRows = _objUsers.GetUsers(Convert.ToInt32(selectedRow.Cells["UserId"].Value.ToString()));
            //    if (dtRows != null)
            //    {
            //        if (dtRows.Rows.Count > 0)
            //        {
            //            cmBxUserTypes.SelectedValue = dtRows.Rows[0]["UserType"].ToString();
            //            cmbUserActive.Text = dtRows.Rows[0]["IsActive"].Equals(true) ? "Yes" : "No";
            //            //selectedRow.Cells["IsActive"].Value.ToString();


            //            txtBxFirstName.Text = dtRows.Rows[0]["FirstName"].ToString();
            //            txtBxFirstName.Enabled = false;
            //            txtBxLastName.Text = dtRows.Rows[0]["LastName"].ToString();
            //            txtBxLastName.Enabled = false;
            //            txtBxEmail.Text = dtRows.Rows[0]["Email"].ToString();
            //            txtBxPassword.Text = dtRows.Rows[0]["Password"].ToString();
            //            lastUserName = txtBxUserName.Text = dtRows.Rows[0]["UserName"].ToString();
            //            txtBxAddress1.Text = dtRows.Rows[0]["AddressLine1"].ToString();
            //            txtBxAddress2.Text = dtRows.Rows[0]["AddressLine1"].ToString();
            //            txtBxCity.Text = dtRows.Rows[0]["City"].ToString();
            //            txtBxState.Text = dtRows.Rows[0]["State"].ToString();
            //            txtBxCountry.Text = dtRows.Rows[0]["Country"].ToString();
            //            txtBxPincode.Text = dtRows.Rows[0]["Pincode"].ToString();
            //            txtBxMobile.Text = dtRows.Rows[0]["MobileNumber"].ToString();

            //            txtBAccName.Text = dtRows.Rows[0]["BankAccountName"].ToString();
            //            txtBAccNumber.Text = dtRows.Rows[0]["BankAccNo"].ToString();
            //            txtBankBranch.Text = dtRows.Rows[0]["BankBranch"].ToString();
            //            txtBankName.Text = dtRows.Rows[0]["BankName"].ToString();
            //            txtIFSCCode.Text = dtRows.Rows[0]["BankIFSC"].ToString();
            //            cmbBankAccountActive.Text = dtRows.Rows[0]["BankIsActive"].Equals(true) ? "Yes" : "No";
            //            txtReferredBy.Text = dtRows.Rows[0]["ReferredBy"].ToString();
            //        }
            //    }

            //    btnDelete.Visible = true;
            //    btnUser.Text = "UPDATE USER";

        }

        #region NumberValidation
        private void txtBxPincode_Leave(object sender, EventArgs e)
        {
            Common.AllowNumeric(txtBxPincode, "Pincode", "Users Creation");
            //if (!Regex.IsMatch(txtBxPincode.Text, "^[0-9]*$"))
            //{
            //    MessageBox.Show("Pincode: Enter only numbers", "Users Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtBxPincode.Focus();
            //}
        }
        private void txtBxMobile_Leave(object sender, EventArgs e)
        {
            Common.AllowNumeric(txtBxPincode, "Mobile Number", "Users Creation");
            //if (!Regex.IsMatch(txtBxMobile.Text, "^[0-9]*$"))
            //{
            //    MessageBox.Show("Mobile Number: Enter only numbers", "Users Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtBxMobile.Focus();
            //}
        }
        #endregion

        private void UsersCreation_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBxFirstName;
            btnDelete.Visible = false;
            dgUsersView.CurrentRow.Selected = false;

            foreach (DataGridViewRow dr in dgUsersView.Rows)
            {
                if (dr.Cells["User Status"].Value.Equals("IN ACTIVE"))
                {
                    dr.Cells["User Status"].Style.BackColor = System.Drawing.Color.LightGray;
                    dr.Cells["User Status"].Style.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this user : " + dgUsersView.CurrentRow.Cells["UserName"].Value.ToString(), "User Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _objUsers = new Users();
                int queryResult = _objUsers.DeleteUser(Convert.ToInt32(dgUsersView.CurrentRow.Cells["UserID"].Value.ToString()));
                if (queryResult > 0)
                {
                    LoadUserDetails();
                    ClearAllControls();
                }
            }
        }

        private void txtBxUserName_Leave(object sender, EventArgs e)
        {
            if (txtBxUserName.Text.Length > 0)
            {
                if (txtBxUserName.Text.Length >= 8)
                {
                    MessageBox.Show("User Name: Length should be less than or equal to 8", " User Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBxUserName.Focus();
                }
                if (!lastUserName.Equals(txtBxUserName.Text))
                {
                    _objUsers = new Users();
                    int result = _objUsers.CheckUserNameAvailability(txtBxUserName.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("User Name : Entered username is already exists. Please try to enter new one", "User Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBxUserName.Focus();
                    }
                }
            }
        }

        private void txtBxEmail_Leave(object sender, EventArgs e)
        {
            Common.EmailValidation(txtBxEmail, "User Email", "User Creation");
        }


    }
}
