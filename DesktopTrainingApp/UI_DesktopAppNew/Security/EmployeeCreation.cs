using System;
using System.Windows.Forms;
using BAL_DesktopTrainingAPP;
using System.Data;
using System.Text.RegularExpressions;
using Helpers_DesktopTrainingAPP;
namespace UI_DesktopAppNew.Security
{
    public partial class EmployeeCreation : Form
    {
        #region ObjectsCreation
        Employees _objEmployees;
        EmployeeDetails _objEmployeeDetails;
        EmployeeLogin _objLoginDetails;
        EmpBankDetails _objBankDetails;
        Roles _objRoles;
        DataTable dtEmployees;
        DataTable dtRoles;
        string lastUserName = string.Empty;
        #endregion

        public EmployeeCreation()
        {
            InitializeComponent();
            LoadRoles();
            LoadEmpDetails();
            cmbUserActive.SelectedIndex = 0;
            cmbBankAccountActive.SelectedIndex = 0;
            cmbRoles.SelectedIndex = 0;
            
        }

        #region CustomFunctions

        /// <summary>
        /// Loads Employees Details
        /// </summary>
        private void LoadEmpDetails()
        {
            dtEmployees = new DataTable();
            _objEmployees = new Employees();

            dgEmployeesView.DataSource = null;
            dgEmployeesView.AutoGenerateColumns = false;

            //Set Columns Count
            dgEmployeesView.ColumnCount = 8;

            dgEmployeesView.Columns[0].Name = "EmpId";
            dgEmployeesView.Columns[0].HeaderText = "Emp Id";
            dgEmployeesView.Columns[0].DataPropertyName = "EmpId";

            dgEmployeesView.Columns[1].HeaderText = "User Name";
            dgEmployeesView.Columns[1].Name = "UserName";
            dgEmployeesView.Columns[1].DataPropertyName = "UserName";


            dgEmployeesView.Columns[2].Name = "FirstName";
            dgEmployeesView.Columns[2].HeaderText = "First Name";
            dgEmployeesView.Columns[2].DataPropertyName = "FirstName";

            dgEmployeesView.Columns[3].Name = "LastName";
            dgEmployeesView.Columns[3].HeaderText = "Last Name";
            dgEmployeesView.Columns[3].DataPropertyName = "LastName";

            dgEmployeesView.Columns[4].Name = "Email";
            dgEmployeesView.Columns[4].HeaderText = "Email Address";
            dgEmployeesView.Columns[4].DataPropertyName = "Email";
            dgEmployeesView.Columns[4].Width = 200;


            dgEmployeesView.Columns[5].Name = "Mobile";
            dgEmployeesView.Columns[5].HeaderText = "Mobile Number";
            dgEmployeesView.Columns[5].DataPropertyName = "MobileNumber";

            dgEmployeesView.Columns[6].Name = "User Status";
            dgEmployeesView.Columns[6].HeaderText = "User Status";
            dgEmployeesView.Columns[6].DataPropertyName = "User Status";

            dgEmployeesView.Columns[7].Name = "Role Name";
            dgEmployeesView.Columns[7].HeaderText = "Role Name";
            dgEmployeesView.Columns[7].DataPropertyName = "Role Name";

            dgEmployeesView.DataSource = dtEmployees = _objEmployees.GetEmployees();
            dgEmployeesView.Columns[0].Visible = false;

        }

        /// <summary>
        /// Load Role details 
        /// </summary>
        private void LoadRoles()
        {
            dtRoles = new DataTable();
            _objRoles = new Roles();
            dtRoles = _objRoles.GetRoles();

            DataRow dr = dtRoles.NewRow();
            dr[0] = 0;
            dr[1] = "-- Select RoleType --";
            dtRoles.Rows.InsertAt(dr, 0);

            cmbRoles.DataSource = dtRoles;
            cmbRoles.DisplayMember = "RoleName";
            cmbRoles.ValueMember = "RoleId";

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
            cmbRoles.SelectedIndex = 0;
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
            btnEmployee.Text = "Add Employee";
            dgEmployeesView.CurrentRow.Selected = false;
        }
        #endregion


        #region ADD_OR_UPDATE
        /// <summary>
        /// Either ADD or UPDATE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBxFirstName.Text) &&
                !string.IsNullOrEmpty(txtBxLastName.Text) &&
                !string.IsNullOrEmpty(txtBxEmail.Text) &&
                !string.IsNullOrEmpty(txtBxPassword.Text) &&
                !string.IsNullOrEmpty(txtBxUserName.Text) &&
                !string.IsNullOrEmpty(txtBxAddress1.Text) &&
                !string.IsNullOrEmpty(txtBxCity.Text) &&
                !string.IsNullOrEmpty(txtBxState.Text) &&
                !string.IsNullOrEmpty(txtBxCountry.Text) &&
                !string.IsNullOrEmpty(txtBxPincode.Text) &&
                !string.IsNullOrEmpty(txtBxMobile.Text) &&
                cmbRoles.SelectedIndex > 0 &&
                !string.IsNullOrEmpty(txtBAccName.Text) &&
                !string.IsNullOrEmpty(txtBAccNumber.Text) &&
                !string.IsNullOrEmpty(txtBankBranch.Text) &&
                !string.IsNullOrEmpty(txtBankName.Text) &&
                !string.IsNullOrEmpty(txtIFSCCode.Text) &&
                cmbBankAccountActive.SelectedIndex > 0 &&
                cmbUserActive.SelectedIndex > 0)
            {
                _objEmployees = new Employees();
                _objEmployeeDetails = new EmployeeDetails();
                _objLoginDetails = new EmployeeLogin();
                _objBankDetails = new EmpBankDetails();

                _objLoginDetails.UserName = txtBxUserName.Text;
                _objLoginDetails.Password = txtBxPassword.Text;
                _objLoginDetails.Email = txtBxEmail.Text;

                _objEmployeeDetails.FirstName = txtBxFirstName.Text;
                _objEmployeeDetails.LastName = txtBxLastName.Text;
                _objEmployeeDetails.AddressLine1 = txtBxAddress1.Text;

                _objEmployeeDetails.City = txtBxCity.Text;
                _objEmployeeDetails.State = txtBxState.Text;
                _objEmployeeDetails.Country = txtBxCountry.Text;
                _objEmployeeDetails.Pincode = Convert.ToInt32(txtBxPincode.Text);
                _objEmployeeDetails.MobileNumber = Convert.ToInt64(txtBxMobile.Text);
                _objEmployeeDetails.RoleID = Convert.ToInt32(cmbRoles.SelectedValue);

                _objBankDetails.BankAccountName = txtBAccName.Text;
                _objBankDetails.BankAccountNumber = txtBAccNumber.Text;
                _objBankDetails.BankBranch = txtBankBranch.Text;
                _objBankDetails.BankIFSCCode = txtIFSCCode.Text;
                _objBankDetails.BankName = txtBankName.Text;
                _objEmployeeDetails.isActive = cmbUserActive.Text == "No" ? false : true;

                _objBankDetails.isActive = cmbBankAccountActive.Text == "No" ? false : true;

                int result = 0;
                if (btnEmployee.Text.ToUpper().Contains("ADD"))
                {
                    result = _objEmployees.CreateEmployee(_objEmployeeDetails, _objLoginDetails, _objBankDetails);
                }
                else
                {
                    _objEmployeeDetails.EmpId = Convert.ToInt32(dgEmployeesView.CurrentRow.Cells["EmpId"].Value.ToString());
                    result = _objEmployees.UpdateEmployee(_objEmployeeDetails, _objLoginDetails, _objBankDetails);

                }
                //if (result > 0)
                //{
                //    MessageBox.Show("User added successfully");
                LoadEmpDetails();
                ClearAllControls();
                //}
            }
            else
            {
                MessageBox.Show("Please Enter the missing fields.", " Alert While Employee Creation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = txtBxFirstName;
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
            if (dtEmployees != null)
            {
                dgEmployeesView.DataSource = Common.dvSearchData(dtEmployees, "UserName", txtBxSearch);
            }
        }

        private void dgEmployeesView_SelectionChanged(object sender, EventArgs e)
        {

            //DataGridViewRow selectedRow = dgEmployeesView.CurrentRow;
            //DataTable dtRows = _objEmployees.GetEmployees(Convert.ToInt32(selectedRow.Cells["EmpId"].Value.ToString()));
            //if (dtRows != null)
            //{
            //    if (dtRows.Rows.Count > 0)
            //    {
            //        cmbRoles.SelectedValue = dtRows.Rows[0]["RoleId"].ToString();
            //        cmbUserActive.Text = dtRows.Rows[0]["IsActive"].Equals(true) ? "Yes" : "No";
            //        //selectedRow.Cells["IsActive"].Value.ToString();


            //        txtBxFirstName.Text = dtRows.Rows[0]["FirstName"].ToString();
            //        txtBxFirstName.Enabled = false;
            //        txtBxLastName.Text = dtRows.Rows[0]["LastName"].ToString();
            //        txtBxLastName.Enabled = false;
            //        txtBxEmail.Text = dtRows.Rows[0]["Email"].ToString();
            //        txtBxPassword.Text = dtRows.Rows[0]["Password"].ToString();
            //        lastUserName = txtBxUserName.Text = dtRows.Rows[0]["UserName"].ToString();
            //        txtBxAddress1.Text = dtRows.Rows[0]["AddressLine1"].ToString();
            //        txtBxCity.Text = dtRows.Rows[0]["City"].ToString();
            //        txtBxState.Text = dtRows.Rows[0]["State"].ToString();
            //        txtBxCountry.Text = dtRows.Rows[0]["Country"].ToString();
            //        txtBxPincode.Text = dtRows.Rows[0]["Pincode"].ToString();
            //        txtBxMobile.Text = dtRows.Rows[0]["MobileNumber"].ToString();

            //        txtBAccName.Text = dtRows.Rows[0]["BankAccountName"].ToString();
            //        txtBAccNumber.Text = dtRows.Rows[0]["BankAccNo"].ToString();
            //        txtBankBranch.Text = dtRows.Rows[0]["BankBranch"].ToString();
            //        txtBankName.Text = dtRows.Rows[0]["BankName"].ToString();
            //        txtIFSCCode.Text = dtRows.Rows[0]["BankIFSC"].ToString();
            //        cmbBankAccountActive.Text = dtRows.Rows[0]["BankIsActive"].Equals(true) ? "Yes" : "No";
            //        //txtReferredBy.Text = dtRows.Rows[0]["ReferredBy"].ToString();
            //    }
            //}

            //btnDelete.Visible = true;
            //btnEmployee.Text = "Update Employee";

        }

        private void dgEmployeesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = dgEmployeesView.CurrentRow;
            DataTable dtRows = _objEmployees.GetEmployees(Convert.ToInt32(selectedRow.Cells["EmpId"].Value.ToString()));
            if (dtRows != null)
            {
                if (dtRows.Rows.Count > 0)
                {
                    cmbRoles.SelectedValue = dtRows.Rows[0]["RoleId"].ToString();
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
            btnEmployee.Text = "Update Employee";

        }

        #region NumberValidation
        private void txtBxPincode_Leave(object sender, EventArgs e)
        {
            Common.AllowNumeric(txtBxPincode, "Pincode", "Employees Creation");
            //if (!Regex.IsMatch(txtBxPincode.Text, "^[0-9]*$"))
            //{
            //    MessageBox.Show("Pincode: Enter only numbers", "Employees Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtBxPincode.Focus();
            //}
        }
        private void txtBxMobile_Leave(object sender, EventArgs e)
        {
            Common.AllowNumeric(txtBxPincode, "Mobile Number", "Employees Creation");
            //if (!Regex.IsMatch(txtBxMobile.Text, "^[0-9]*$"))
            //{
            //    MessageBox.Show("Mobile Number: Enter only numbers", "Employees Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtBxMobile.Focus();
            //}
        }
        #endregion

        private void EmployeesCreation_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBxFirstName;
            btnDelete.Visible = false;
            dgEmployeesView.CurrentRow.Selected = false;
            foreach (DataGridViewRow dr in dgEmployeesView.Rows)
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
            if (MessageBox.Show("Do you want to delete this Employee : " + dgEmployeesView.CurrentRow.Cells["UserName"].Value.ToString(), "Employee Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _objEmployees = new Employees();
                int queryResult = _objEmployees.DeleteEmployee(Convert.ToInt32(dgEmployeesView.CurrentRow.Cells["EmpID"].Value.ToString()));
                if (queryResult > 0)
                {
                    LoadEmpDetails();
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
                    _objEmployees = new Employees();
                    int result = _objEmployees.CheckEmplyeeNameAvailability(txtBxUserName.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("User Name : Entered username is already exists. Please try to enter new one", "Employee Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
