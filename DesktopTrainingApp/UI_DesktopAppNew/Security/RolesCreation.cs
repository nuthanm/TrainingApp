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
    public partial class RolesCreation : Form
    {
        #region ObjectCreation
        Roles objRoles;
        #endregion

        public RolesCreation()
        {
            InitializeComponent();
            LoadRoles();
            this.ActiveControl = txtBoxRoleName;

        }

        private void LoadRoles()
        {
            objRoles = new Roles();
            dgViewRoles.DataSource = objRoles.GetRoles();
            dgViewRoles.Columns[0].Visible = false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text.ToUpper().Contains("DELETE"))
            {
                if (MessageBox.Show("Do you want to delete the selected row?", string.Format("Role Deletion Record #{0}", dgViewRoles.CurrentRow.Cells[0].Value.ToString()), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        objRoles = new Roles();
                        int result = objRoles.DeleteRole((int)dgViewRoles.CurrentRow.Cells[0].Value);
                        if (result > 0)
                        {
                            LoadRoles();
                            ClearControls();
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
                ClearControls();
            }

        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxRoleName.Text) && txtBoxRoleName.Text.Length > 0)
            {
                objRoles = new Roles();
                int result = 0;
                string statusMsg = string.Empty;
                if (btnRole.Text.ToUpper().Contains("ADD"))
                {
                    result = objRoles.CreateRole(txtBoxRoleName.Text.Trim(), txtRoleDesc.Text.Trim());
                    statusMsg = "Added new record successfully.";
                }
                else
                {
                    result = objRoles.UpdateRole((int)dgViewRoles.CurrentRow.Cells[0].Value, txtBoxRoleName.Text, txtRoleDesc.Text.Trim());
                    statusMsg = "Updated record successfully.";
                }

                if (result > 0)
                {
                    LoadRoles();
                    ClearControls();
                    MessageBox.Show(statusMsg, "Role Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearControls()
        {
            txtBoxRoleName.Text = string.Empty;
            txtRoleDesc.Text = string.Empty;
            btnRole.Text = "ADD ROLE";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgViewRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgViewRoles.CurrentRow;
            txtBoxRoleName.Text = selectedRow.Cells[1].Value.ToString();
            txtRoleDesc.Text = selectedRow.Cells[2].Value != null ? selectedRow.Cells[2].Value.ToString() : string.Empty;
            btnRole.Text = "UPDATE ROLE";

        }

        private void RolesCreation_Load(object sender, EventArgs e)
        {
            dgViewRoles.CurrentRow.Selected = false;
        }

    }
}
