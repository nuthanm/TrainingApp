using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BAL_DesktopTrainingAPP;
namespace UI_DesktopAppNew.Notifications
{
    public partial class SendCampaign : Form
    {
        DataTable dtLists;
        public SendCampaign()
        {
            InitializeComponent();
            LoadMailLists();
        }

        private void LoadMailLists()
        {
            dtLists = new DataTable();

            dtLists = null;

            DataRow dr = dtLists.NewRow();
            dr[0] = 0;
            dr[1] = "-- Select Lists --";
            dtLists.Rows.InsertAt(dr, 0);

           
        }

        private void SendCampaign_Load(object sender, EventArgs e)
        {

        }
    }
}
