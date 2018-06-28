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
using System.Threading;
namespace UI_DesktopAppNew.Security
{
    public partial class Login : Form
    {
        #region Objects
        int queryResult = -1;
        DataTable dtUserRoles = null;
        SplashScreen objSplash;
        #endregion

        public Login()
        {
            Thread t = new Thread(new ThreadStart(StartSplash));
            t.Start();
            Thread.Sleep(5000);
            //    objSplash = new SplashScreen();
            //    objSplash.Show();                      

            InitializeComponent();
            t.Abort();
            this.ActiveControl = txtUserName;
        }

        public void StartSplash()
        {
            Application.Run(new SplashScreen());
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            if (Loginvalidation())
            {

                UsersBLL userBLL = new UsersBLL();
                string clearText = txtPassword.Text.Trim();

                object userAuthetication = userBLL.ValidateUser(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                switch (userAuthetication.GetType().Name)
                {
                    case "DataSet":
                        DataSet dsuserAuthetication = (DataSet)userAuthetication;
                        if (dsuserAuthetication.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Login details provided are incorrect, please login again", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            return;
                        }

                        if (dsuserAuthetication.Tables[0].Rows[0]["IsActive"].ToString().ToLower() == "1")
                        {
                            MessageBox.Show("Access denied, contact administrator!!!", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            return;
                        }

                        if (dsuserAuthetication.Tables[1].Rows.Count > 0)
                        {
                            MainLoad ML = new MainLoad();
                            ML.username = txtUserName.Text.Trim();
                            ML.password = txtPassword.Text.Trim();
                            ActiveForm.Hide();
                            ML.Show();
                        }
                        else
                        {
                            MessageBox.Show("You do not have access to the application, please contact administrator!!!", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            return;
                        }

                        return;
                }
            }
        }

        private bool Loginvalidation()
        {
            bool IsValidated = true;

            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter User Name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUserName.Focus();
                txtUserName.BackColor = Color.Pink;
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPassword.Focus();
                txtPassword.BackColor = Color.Pink;
                return false;
            }

            return IsValidated;
        }

        private void btnLogon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogon.PerformClick();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
