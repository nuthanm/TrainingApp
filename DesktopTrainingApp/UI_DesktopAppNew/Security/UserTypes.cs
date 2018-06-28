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
    public partial class UserTypes : Form
    {
        Users _objUserTypes;
        public UserTypes()
        {            
            InitializeComponent();
            LoadUserTypes();
        }

        private void LoadUserTypes()
        {
            _objUserTypes = new Users();
            dgUserTypes.DataSource = _objUserTypes.GetUserTypes();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgUsersType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgUserTypes.CurrentRow;
            txtBoxUserTypeName.Text = selectedRow.Cells[1].Value.ToString();
            txtBoxUserTypeDesc.Text = selectedRow.Cells[2].Value != null ? selectedRow.Cells[2].Value.ToString() : string.Empty;
            btnUserType.Text = "UPDATE TYPE";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text.ToUpper().Contains("DELETE"))
            {
                if (MessageBox.Show("Do you want to delete the selected row?", string.Format("Userzzzzzztype Deletion Record #{0}", dgUserTypes.CurrentRow.Cells[0].Value.ToString()), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _objUserTypes = new Users();
                        int result = _objUserTypes.DeleteUserType((int)dgUserTypes.CurrentRow.Cells[0].Value);
                        if (result > 0)
                        {
                            LoadUserTypes();
                            ClearAllControls();
                        }
                        else
                        {
                            MessageBox.Show("Delete is not successfull");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error.... While Deletion " + ex.Message);
                    }
                }

            }
            else
            {
                ClearAllControls();
            }

        }

        private void ClearAllControls()
        {
            txtBoxUserTypeName.Text = string.Empty;
            txtBoxUserTypeDesc.Text = string.Empty;
            dgUserTypes.CurrentRow.Selected = false;
        }
        private void btnUserType_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxUserTypeName.Text) && txtBoxUserTypeName.Text.Length > 0)
            {
                _objUserTypes = new Users();
                int result = 0;
                string statusMsg = string.Empty;
                if (btnUserType.Text.ToUpper().Contains("ADD"))
                {
                    result = _objUserTypes.CreateUserType(txtBoxUserTypeName.Text.Trim(), txtBoxUserTypeDesc.Text.Trim());
                    statusMsg = "Added new record successfully.";
                }
                else
                {
                    result = _objUserTypes.UpdateUserType((int)dgUserTypes.CurrentRow.Cells[0].Value, txtBoxUserTypeName.Text, txtBoxUserTypeDesc.Text.Trim());
                    statusMsg = "Updated record successfully.";
                }

                if (result > 0)
                {
                    LoadUserTypes();
                    ClearAllControls();
                    MessageBox.Show(statusMsg, "User Type Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void UserTypes_Load(object sender, EventArgs e)
        {
            dgUserTypes.CurrentRow.Selected = false;
        }

    }
}
