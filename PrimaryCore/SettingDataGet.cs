using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryCore
{
    public class SettingDataGet
    {

        public static void UserDetails(System.Windows.Forms.TextBox username, System.Windows.Forms.TextBox password)
        {
            var data = Models.Bug.Queries.SettingQuery.UserDetails();
            username.Text = data.Username;
            password.Text = data.Password;
        }

        public static void VSODetails(System.Windows.Forms.TextBox account, System.Windows.Forms.TextBox project)
        {
            var data = Models.Bug.Queries.SettingQuery.AccountDetails();
            account.Text = data.Account;
            project.Text = data.Project;
        }
        
    }
}
