using BAL_DesktopTrainingAPP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using UI_DesktopAppNew.Courses;
using UI_DesktopAppNew.Security;
using UI_DesktopAppNew.Enquiry;
using UI_DesktopAppNew.Fees;
using UI_DesktopAppNew.Notifications;
namespace UI_DesktopAppNew
{
    public partial class MainLoad : Form
    {
        MenuStrip MnuStrip;
        ToolStripMenuItem MnuStripItem;

        public MainLoad()
        {
            InitializeComponent();
        }


        public string username
        {
            get { return lbl_username.Text; }
            set { lbl_username.Text = value; }
        }
        public string password
        {
            get { return lbl_password.Text; }
            set { lbl_password.Text = value; }
        }




        private void Main_Load(object sender, EventArgs e)
        {

            // To make this Form the Parent Form
            this.IsMdiContainer = true;

            //Creating object of MenuStrip class
            MnuStrip = new MenuStrip();

            //Placing the control to the Form
            this.Controls.Add(MnuStrip);

            UsersBLL userBLL = new UsersBLL();
            object userAuthetication = userBLL.ValidateUser(username, password);
            DataSet dsuserAuthetication = (DataSet)userAuthetication;

            if (dsuserAuthetication.Tables[2].Rows.Count > 0)
            {
                //lbl_username.Text = LoginSuccessDetails.userName = username.ToUpper();
                LoginSuccessDetails.userName = username;
                this.Text = "Mohan IT Trainings | " + username.ToUpper();
                DataTable dtmodules = dsuserAuthetication.Tables[2];
                DataTable dtsubmodules = dsuserAuthetication.Tables[1];
                foreach (DataRow dr in dtmodules.Rows)
                {
                    MnuStripItem = new ToolStripMenuItem(dr["ModuleName"].ToString());
                    SubMenu(MnuStripItem, dr["ModuleName"].ToString(), dtsubmodules);
                    MnuStrip.Items.Add(MnuStripItem);
                }
                this.MainMenuStrip = MnuStrip;

                // On Load By default Dashboard screen
                MainLoad mainloadcc = (MainLoad)Application.OpenForms["MainLoad"];
                Panel panelcc = (Panel)mainloadcc.Controls["pnl_Mainload"];
                panelcc.Controls.Clear();

                DashBoard DashBoard = new DashBoard();
                DashBoard.TopLevel = false;
                DashBoard.TopMost = true;
                panelcc.Controls.Add(DashBoard);
                DashBoard.Show();
            }
        }

        public void SubMenu(ToolStripMenuItem mnu, string submenu, DataTable dtmodulessub)
        {

            DataTable dtchild = dtmodulessub.AsEnumerable()
          .Where(row => row.Field<String>("ModuleName") == submenu)
          .OrderByDescending(row => row.Field<String>("FunctionName"))
          .CopyToDataTable();

            foreach (DataRow dr in dtchild.Rows)
            {
                ToolStripMenuItem SSMenu = new ToolStripMenuItem(dr["FunctionName"].ToString(), null, new EventHandler(ChildClick));
                mnu.DropDownItems.Add(SSMenu);
            }

        }

        private void ChildClick(object sender, EventArgs e)
        {
            MainLoad mainloadcc = (MainLoad)Application.OpenForms["MainLoad"];
            Panel panelcc = (Panel)mainloadcc.Controls["pnl_Mainload"];
            panelcc.Controls.Clear();

            if (sender.ToString() == "CourseCreation")
            {
                CourseCreation CourseCreation = new CourseCreation();
                CourseCreation.TopLevel = false;
                CourseCreation.TopMost = true;
                panelcc.Controls.Add(CourseCreation);
                CourseCreation.Show();
            }
            else if (sender.ToString() == "UsersCreation")
            {
                UsersCreation UsersCreation = new UsersCreation();
                UsersCreation.TopLevel = false;
                UsersCreation.TopMost = true;
                panelcc.Controls.Add(UsersCreation);
                UsersCreation.Show();
            }
            else if (sender.ToString() == "ChangePassword")
            {
                ChangePassword ChangePassword = new ChangePassword();
                ChangePassword.TopLevel = false;
                ChangePassword.TopMost = true;
                panelcc.Controls.Add(ChangePassword);
                ChangePassword.Show();
            }
            else if (sender.ToString() == "EnquiryForm")
            {
                EnquiryForm EnquiryForm = new EnquiryForm();
                EnquiryForm.TopLevel = false;
                EnquiryForm.TopMost = true;
                panelcc.Controls.Add(EnquiryForm);
                EnquiryForm.Show();
            }
            else if (sender.ToString() == "UserTypes")
            {
                UserTypes UserTypes = new UserTypes();
                UserTypes.TopLevel = false;
                UserTypes.TopMost = true;
                panelcc.Controls.Add(UserTypes);
                UserTypes.Show();
            }
            else if (sender.ToString() == "RolesCreation")
            {
                RolesCreation RolesCreation = new RolesCreation();
                RolesCreation.TopLevel = false;
                RolesCreation.TopMost = true;
                panelcc.Controls.Add(RolesCreation);
                RolesCreation.Show();
            }
            else if (sender.ToString() == "FeeCreation")
            {
                FeeCreation FeeCreation = new FeeCreation();
                FeeCreation.TopLevel = false;
                FeeCreation.TopMost = true;
                panelcc.Controls.Add(FeeCreation);
                FeeCreation.Show();
            }
            else if (sender.ToString() == "SendCampaign")
            {
                SendCampaign SendCampaign = new SendCampaign();
                SendCampaign.TopLevel = false;
                SendCampaign.TopMost = true;
                panelcc.Controls.Add(SendCampaign);
                SendCampaign.Show();
            }

            else if (sender.ToString() == "MailChimpDetails")
            {
                MailChimpDetails MailChimpDetails = new MailChimpDetails();
                MailChimpDetails.TopLevel = false;
                MailChimpDetails.TopMost = true;
                panelcc.Controls.Add(MailChimpDetails);
                MailChimpDetails.Show();
            }

            else if (sender.ToString() == "DashBoard")
            {
                DashBoard DashBoard = new DashBoard();
                DashBoard.TopLevel = false;
                DashBoard.TopMost = true;
                panelcc.Controls.Add(DashBoard);
                DashBoard.Show();
            }

            else if (sender.ToString() == "Transactions")
            {
                Transactions Transactions = new Transactions();
                Transactions.TopLevel = false;
                Transactions.TopMost = true;
                panelcc.Controls.Add(Transactions);
                Transactions.Show();
            }

            else if (sender.ToString() == "EmployeeCreation")
            {
                EmployeeCreation EmployeeCreation = new EmployeeCreation();
                EmployeeCreation.TopLevel = false;
                EmployeeCreation.TopMost = true;
                panelcc.Controls.Add(EmployeeCreation);
                EmployeeCreation.Show();
            }
            else if (sender.ToString() == "ModuleAccess")
            {
                ModuleAccess ModuleAccess = new ModuleAccess();
                ModuleAccess.TopLevel = false;
                ModuleAccess.TopMost = true;
                panelcc.Controls.Add(ModuleAccess);
                ModuleAccess.Show();
            }

        }

        private void MainLoad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    public static class LoginSuccessDetails
    {
        public static string userName { get; set; }
        public static int UID { get; set; }
    }
}


