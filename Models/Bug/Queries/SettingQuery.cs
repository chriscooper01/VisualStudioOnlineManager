using Models.Bug.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Bug.Queries
{
    public class SettingQuery : Models.Bug.Helpers.LinqContextHelper
    {
        public static void Insert(SettingENUM settingKey, string settingValue)
        {

            try
            {
                using (var context = GetContext())
                {

                    var model = context.GetTable<Tables.SettingTable>();

                    var item = new Tables.SettingTable() { SettingKey = settingKey.ToString(), SettingValue = settingValue };
                    model.InsertOnSubmit(item);
                    context.SubmitChanges();

                }

            }
            catch { }
        }

        public static void Update(SettingENUM settingKey, string settingValue)
        {

            try
            {
                using (var context = GetContext())
                {

                    var model = context.GetTable<Tables.SettingTable>();
                    var data = model.SingleOrDefault(x => x.SettingKey.Equals(settingKey.ToString()));
                    if (data != null)
                    {
                        data.SettingValue = settingValue;
                        context.SubmitChanges();
                    }
                }

            }
            catch { }
        }


        public static string SingleValue(SettingENUM settingKey)
        {

            try
            {
                using (var context = GetContext())
                {

                    var model = context.GetTable<Tables.SettingTable>();
                    var data = model.SingleOrDefault(x => x.SettingKey.Equals(settingKey.ToString()));
                    if (data != null)
                        return data.SettingValue;

                 

                }

            }
            catch (Exception e)
            {
            }

            return String.Empty;
        }

        public static DataObjectsProject.VSOUserDetailsData UserDetails()
        {
            
                return new DataObjectsProject.VSOUserDetailsData()
                {
                    Username = SingleValue(ENUMS.SettingENUM.VSOUsername),
                    Password = SingleValue(ENUMS.SettingENUM.VSOPassword)
                };
                
               
        }

        public static DataObjectsProject.VSOAccountDetailsData AccountDetails()
        {

            return new DataObjectsProject.VSOAccountDetailsData()
            {
                Account = SingleValue(ENUMS.SettingENUM.VSOAccount),
                Project = SingleValue(ENUMS.SettingENUM.VSOProject)
            };


        }
    }
}
