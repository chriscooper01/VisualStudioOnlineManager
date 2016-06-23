using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Bug.Helpers
{
    public class Update
    {

        public static void CreateDatabase(string location)
        {
            if (!File.Exists(location))
            {
                string connectionString = String.Format("DataSource=\"{0}\"; Password=\"mypassword\"", location);
                System.Data.SqlServerCe.SqlCeEngine en = new System.Data.SqlServerCe.SqlCeEngine(connectionString);
                en.CreateDatabase();

                createDBTables();

                Models.Bug.Queries.VersionQuery.Insert(1);
            }

        }

        private static void createDBTables()
        {
            Models.Bug.Helpers.LinqContextHelper.CreateTable(typeof(Models.Bug.Tables.SettingTable));
            Models.Bug.Helpers.LinqContextHelper.CreateTable(typeof(Models.Bug.Tables.ArchiveTable));
            Models.Bug.Helpers.LinqContextHelper.CreateTable(typeof(Models.Bug.Tables.VersionTable));

        }
    }
}
