using System;
using System.Windows.Forms;
using BAL_DesktopTrainingAPP;
using System.Data;
using System.Text.RegularExpressions;
using Helpers_DesktopTrainingAPP;

namespace UI_DesktopAppNew.Security
{
    public partial class ModuleAccess : Form
    {
        #region ObjectsCreation
        Roles _objRoles;
        ModuleRoleAccess _objModuleAccess;
        DataTable dtModules;
        DataTable dtFunctions;
        DataTable dtModuleFunctions;
        DataTable dtRoles;
        #endregion

        public ModuleAccess()
        {
            InitializeComponent();
            LoadRoles();
            LoadModules();
            
        }

        /// <summary>
        /// Fill roles details in Roles dropdown
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

        private void LoadModules()
        {
            dtModules = new DataTable();
            _objModuleAccess = new ModuleRoleAccess();
            dtModules = _objModuleAccess.GetModules();

            DataRow dr = dtModules.NewRow();
            dr[0] = 0;
            dr[1] = "-- Select Module --";
            dtModules.Rows.InsertAt(dr, 0);

            cmbModules.DataSource = dtModules;
            cmbModules.DisplayMember = "ModuleName";
            cmbModules.ValueMember = "ModuleId";
        }

        /// <summary>
        /// Load All Functions
        /// </summary>
        private void LoadFunctions(int moduleID)
        {
            _objModuleAccess = new ModuleRoleAccess();
            dtFunctions = _objModuleAccess.GetFunctions(moduleID);

            lsbxFunctionsAll.DataSource = dtFunctions;
            lsbxFunctionsAll.DisplayMember = "FunctionName";
            lsbxFunctionsAll.ValueMember = "FunctionId";
        }

        /// <summary>
        /// On change of Modules will show Functions/Sub-Modules into Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModules.SelectedIndex > 0)
            {
                LoadFunctions(Convert.ToInt32(cmbModules.SelectedValue));
                LoadModuleFunctions(Convert.ToInt32(cmbModules.SelectedValue));
            }
        }

        /// <summary>
        /// On selection of module we populate functions of that selected module
        /// </summary>
        /// <param name="moduleID"></param>
        private void LoadModuleFunctions(int moduleID)
        {
            _objModuleAccess = new ModuleRoleAccess();
            dtModuleFunctions = _objModuleAccess.GetModuleFunctions(moduleID);

            lsbxFunctionsSelected.DataSource = dtModuleFunctions;
            lsbxFunctionsSelected.DisplayMember = "FunctionName";
            lsbxFunctionsSelected.ValueMember = "FunctionId";
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedIndex > 0 && cmbModules.SelectedIndex > 0)
            {
                _objModuleAccess = new ModuleRoleAccess();
                int queryResult=_objModuleAccess.CreateModuleAccess(Convert.ToInt32(cmbRoles.SelectedValue), Convert.ToInt32(cmbModules.SelectedValue), Convert.ToInt32(lsbxFunctionsAll.SelectedValue),lsbxFunctionsAll.Text,string.Format("~/{0}/{1}",cmbModules.Text,lsbxFunctionsAll.Text));
                if (queryResult > 0)
                {
                    LoadFunctions(Convert.ToInt32(cmbModules.SelectedValue));
                    LoadModuleFunctions(Convert.ToInt32(cmbModules.SelectedValue));
                }
            }            
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedIndex > 0 && cmbModules.SelectedIndex > 0)
            {
                _objModuleAccess = new ModuleRoleAccess();
                int queryResult = _objModuleAccess.DeleteModuleAccess(Convert.ToInt32(cmbRoles.SelectedValue), Convert.ToInt32(cmbModules.SelectedValue), Convert.ToInt32(lsbxFunctionsAll.SelectedValue));
                if (queryResult > 0)
                {
                    LoadFunctions(Convert.ToInt32(cmbModules.SelectedValue));
                    LoadModuleFunctions(Convert.ToInt32(cmbModules.SelectedValue));
                }

            }            
        }
    }
}
