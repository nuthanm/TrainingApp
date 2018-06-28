using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Helpers_DesktopTrainingAPP
{
    public static class Common
    {
        #region ObjectsDeclare
        static Process[] processes;
        #endregion

        //To delete exe files from Process window
        public static void KillProcess(string processName, string reportName)
        {
            processes = Process.GetProcessesByName(processName);
            foreach (Process p in processes)
            {
                if (string.IsNullOrEmpty(p.ProcessName) == false && p.MainWindowTitle.Contains(reportName) == true)
                {
                    p.Kill();
                }
            }

        }


        /// <summary>
        /// Return filter data based on search
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="columnName"></param>
        /// <param name="txtSearch"></param>
        /// <returns></returns>
        public static System.Data.DataTable dvSearchData(System.Data.DataTable dt, string columnName, System.Windows.Forms.TextBox txtSearch)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("{0} like '%{1}%'", columnName, txtSearch.Text);
            return dv.ToTable();
        }

        public static void AllowNumeric(System.Windows.Forms.TextBox txtBox, string columnName, string pageName)
        {
            if (!Regex.IsMatch(txtBox.Text, "^[0-9]*$"))
            {
                //return false;
                MessageBox.Show(string.Format("{0} : Enter only numbers", columnName), pageName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox.Focus();
            }
        }


        public static void AllowNumericForFee(System.Windows.Forms.TextBox txtBox, string columnName, string pageName)
        {
            if (!Regex.IsMatch(txtBox.Text, "^[0-9]*[.][0-9]{2}$"))
            {
                //return false;
                MessageBox.Show(string.Format("{0} : Enter only decimal Values. Ex:123456.45", columnName), pageName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox.Focus();
            }
        }

        public static void EmailValidation(System.Windows.Forms.TextBox txtBox, string columnName, string pageName)
        {
            if (!Regex.IsMatch(txtBox.Text, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"))
            {
                //return false;
                MessageBox.Show(string.Format("{0} : Please enter valid email address. Ex:info@domain.com", columnName), pageName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox.Focus();
            }
        }
    }


    //public class ExcelGeneration
    //{
    //    #region ObjectsDeclare
    //   // Application appExcel;
    //    Workbook appWBook;
    //    System.Data.DataTable dtData;

    //    #endregion

    //    public ExcelGeneration()
    //    {
    //        appExcel = new Application();
    //        appExcel.DisplayAlerts = false;
    //    }



    //}
}
