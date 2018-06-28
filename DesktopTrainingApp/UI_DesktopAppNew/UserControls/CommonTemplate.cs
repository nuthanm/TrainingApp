using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
namespace UI_DesktopAppNew.UserControls
{
    public partial class CommonTemplate : UserControl
    {
        public CommonTemplate()
        {
            InitializeComponent();
        }

        private void CommonTemplate_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            //lblVersion.Text = "Version : "+fvi.FileVersion;
        }


    }
}
