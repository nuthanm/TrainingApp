using DAL_DesktopTrainingAPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAL_DesktopTrainingAPP
{
    public class UsersBLL
    {
        UserProfileHandler userprofilehandler = new UserProfileHandler();

        public object ValidateUser(string username, string password)
        {
            return userprofilehandler.ValidateUser(username, password);
        }


    }
}
