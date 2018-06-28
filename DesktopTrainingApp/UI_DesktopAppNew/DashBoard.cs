using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL_DesktopTrainingAPP;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI_DesktopAppNew
{
    public partial class DashBoard : Form
    {
        DataTable dt = null;
        Overview objOverview = null;

        public DashBoard()
        {
            InitializeComponent();
        }

        public DashBoard(string UserRole)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            objOverview = new Overview();

            #region  TrainingTypes

            //dt = objOverview.GetTotalTrainingTypes();
            dt = objOverview.GetTotalTrainingTypesBasedOnYears();

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    switch (dr["TypeName"].ToString())
                    {
                        case "Training": chartTrainingTypes.Series["Training"].Points.AddXY(dr["YearWise"], dr["Total"]);
                            break;
                        case "Support": chartTrainingTypes.Series["Support"].Points.AddXY(dr["YearWise"], dr["Total"]); break;
                        case "Proxy": chartTrainingTypes.Series["Proxy"].Points.AddXY(dr["YearWise"], dr["Total"]); break;
                        case "Exam": chartTrainingTypes.Series["Exam"].Points.AddXY(dr["YearWise"], dr["Total"]); break;
                    }
                }
            }
            #endregion

            #region  RunningStatus
            dt.Rows.Clear();
            dt = objOverview.GetTotalCurrentRunningStatus();

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    switch (dr["Status"].ToString())
                    {
                        case "Accepted": chartRunningStatus.Series["Accepted"].Points.AddXY(dr["Status"], dr["Total"]);
                            break;
                        case "Following": chartRunningStatus.Series["Following"].Points.AddXY(dr["Status"], dr["Total"]);
                            break;
                        case "Rejected": chartRunningStatus.Series["Rejected"].Points.AddXY(dr["Status"], dr["Total"]);
                            break;
                        case "InProgress": chartRunningStatus.Series["InProgress"].Points.AddXY(dr["Status"], dr["Total"]);
                            break;
                        case "Scheduled": chartRunningStatus.Series["Scheduled"].Points.AddXY(dr["Status"], dr["Total"]);
                            break;
                    }
                }
                chartRunningStatus.DataSource = dt;
                chartRunningStatus.DataBind();
            }

            #endregion

            #region TransactionDetails

            #endregion
        }
    }
}
