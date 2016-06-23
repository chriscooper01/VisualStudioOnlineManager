using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Models.Bug.Tables
{
    [Table(Name = "categories")]
    public class SettingTable
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int Not Null IDENTITY")]
        public int Id { get; set; }

        [Column(Name = "settingKey", DbType = "nvarchar(50) Not Null", CanBeNull = false)]
        public string SettingKey { get; set; }

        [Column(Name = "settingValue", DbType = "ntext Not Null", CanBeNull = false)]
        public string SettingValue { get; set; }
    }
}
