using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryCore
{
    public class SettingDataSave
    {

        public static void VSOUserDetails(string username, string password)
        {
            if(String.IsNullOrEmpty(Models.Bug.Queries.SettingQuery.SingleValue(Models.Bug.ENUMS.SettingENUM.VSOUsername)))
                Models.Bug.Queries.SettingQuery.Insert(Models.Bug.ENUMS.SettingENUM.VSOUsername, username);
            else
                Models.Bug.Queries.SettingQuery.Update(Models.Bug.ENUMS.SettingENUM.VSOUsername, username);

            if (String.IsNullOrEmpty(Models.Bug.Queries.SettingQuery.SingleValue(Models.Bug.ENUMS.SettingENUM.VSOPassword)))
                Models.Bug.Queries.SettingQuery.Insert(Models.Bug.ENUMS.SettingENUM.VSOPassword, password);
            else
                Models.Bug.Queries.SettingQuery.Update(Models.Bug.ENUMS.SettingENUM.VSOPassword, password);
        }

        public static void VSODetails(string account, string project)
        {
            if (String.IsNullOrEmpty(Models.Bug.Queries.SettingQuery.SingleValue(Models.Bug.ENUMS.SettingENUM.VSOAccount)))
                Models.Bug.Queries.SettingQuery.Insert(Models.Bug.ENUMS.SettingENUM.VSOAccount, account);
            else
                Models.Bug.Queries.SettingQuery.Update(Models.Bug.ENUMS.SettingENUM.VSOAccount, account);

            if (String.IsNullOrEmpty(Models.Bug.Queries.SettingQuery.SingleValue(Models.Bug.ENUMS.SettingENUM.VSOProject)))
                Models.Bug.Queries.SettingQuery.Insert(Models.Bug.ENUMS.SettingENUM.VSOProject, project);
            else
                Models.Bug.Queries.SettingQuery.Update(Models.Bug.ENUMS.SettingENUM.VSOProject, project);
        }
    }
}
