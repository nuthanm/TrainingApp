using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL_DesktopTrainingAPP;
using UI_DesktopAppNew;
using UI_DesktopAppNew.Courses;

namespace UI_DesktopAppNew.Fees
{
    public partial class FeeCreation : Form
    {
        #region Objects
        DataTable dtValues;
        BAL_DesktopTrainingAPP.Fees objFees;
        TraineeTypes objTypes;
        BAL_DesktopTrainingAPP.Courses objCourses;
        #endregion

        public FeeCreation()
        {
            InitializeComponent();
            LoadFeeDetails();
            LoadTrainingTypes();
            

        }

        private void LoadTrainingTypes()
        {
            dtValues = new DataTable();
            objTypes = new TraineeTypes();
            dtValues = objTypes.GetTraineeTypes();

            DataRow dr = dtValues.NewRow();
            dr[0] = 0;
            dr[1] = "-- Select Trainee Type --";
            dtValues.Rows.InsertAt(dr, 0);

            cmbBoxTraineeTypes.DataSource = dtValues;
            cmbBoxTraineeTypes.DisplayMember = "TypeName";
            cmbBoxTraineeTypes.ValueMember = "TrainingTypeId";
            cmbBoxTraineeTypes.SelectedIndex = -1;

        }

        /// <summary>
        /// Closing the form on click of X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// Reset the controls values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text.ToUpper().Contains("DELETE"))
            {
                if (MessageBox.Show("Do you want to delete the selected row?", string.Format("Fee Deletion Record #{0}", dgViewFees.CurrentRow.Cells[0].Value.ToString()), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        objFees = new BAL_DesktopTrainingAPP.Fees();
                        int result = objFees.DeleteFees((int)dgViewFees.CurrentRow.Cells[0].Value);
                        if (result > 0)
                        {
                            LoadFeeDetails();
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

        /// <summary>
        /// Clear all the controls
        /// </summary>
        private void ClearAllControls()
        {
            cmbBoxTraineeTypes.SelectedIndex = -1;
            cmbBoxCourses.SelectedIndex = -1;

            txtBoxFee.Text = string.Empty;
            txtBoxSTax.Text = string.Empty;
            btnFee.Text = "Add Fee";
            btnReset.Text = "Reset";
        }

        //private void FeeCreation_Load(object sender, EventArgs e)
        //{
        //    LoadFeeDetails();
        //}

        private void LoadFeeDetails()
        {
            objFees = new BAL_DesktopTrainingAPP.Fees();
            dgViewFees.DataSource = objFees.GetFees();
            dgViewFees.Columns[0].Visible = false;
        }


        /// <summary>
        /// Load Courses based on Selection of Trainings
        /// </summary>
        private void LoadCourses()
        {
            dtValues = new DataTable();
            objCourses = new BAL_DesktopTrainingAPP.Courses();
            dtValues = objCourses.GetCourses();

            DataRow dr = dtValues.NewRow();
            dr[0] = 0;
            dr[1] = "-- Select Courses --";
            dtValues.Rows.InsertAt(dr, 0);



            cmbBoxCourses.DataSource = dtValues;
            cmbBoxCourses.DisplayMember = "CourseName";
            cmbBoxCourses.ValueMember = "CourseId";
            cmbBoxCourses.SelectedIndex = -1;
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            if (cmbBoxTraineeTypes.SelectedIndex > -1 && cmbBoxCourses.SelectedIndex > -1 && txtBoxFee.Text.Length != 0)
            {
                objFees = new BAL_DesktopTrainingAPP.Fees();
                int result = 0;
                string statusMsg = string.Empty;
                if (btnFee.Text.ToUpper().Contains("ADD"))
                {
                    result = objFees.CreateFees(Convert.ToInt32(cmbBoxTraineeTypes.SelectedValue), Convert.ToInt32(cmbBoxCourses.SelectedValue), Convert.ToInt32(txtBoxFee.Text), Convert.ToInt32(txtBoxSTax.Text));
                    statusMsg = "Added new record successfully.";
                }
                else
                {
                    result = objFees.UpdateFees(Convert.ToInt32(dgViewFees.CurrentRow.Cells[0].Value), Convert.ToInt32(cmbBoxTraineeTypes.SelectedValue), Convert.ToInt32(cmbBoxCourses.SelectedValue), Convert.ToDecimal(txtBoxFee.Text), Convert.ToInt32(txtBoxSTax.Text));
                    statusMsg = "Updated record successfully.";
                }

                if (result > 0)
                {
                    LoadFeeDetails();
                    ClearAllControls();
                    MessageBox.Show(statusMsg, "Fee Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgViewFees_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgViewFees.SelectedRows)
            {
                cmbBoxTraineeTypes.Text = row.Cells[2].Value.ToString();
                cmbBoxCourses.Text = row.Cells[1].Value.ToString();
                txtBoxFee.Text = row.Cells[3].Value.ToString();
                txtBoxSTax.Text = row.Cells[4].Value.ToString();
            }
            btnFee.Text = "Update Fee";
            btnReset.Text = "Delete";

        }

        private void cmbBoxTraineeTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if (cmbBoxTraineeTypes.Text.Contains("Training"))
            LoadCourses();
        }

        private void FeeCreation_Load(object sender, EventArgs e)
        {
            dgViewFees.CurrentRow.Selected = false;
        }

    }
}
