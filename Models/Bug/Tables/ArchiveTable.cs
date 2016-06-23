using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Bug.Tables
{
    [Table(Name = "categories")]
    class ArchiveTable
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int Not Null IDENTITY")]
        public int Id { get; set; }

        [Column(Name = "vsoId", DbType = "int Not Null IDENTITY")]
        public int VSOId { get; set; }


        [Column(Name = "title", DbType = "ntext Not Null", CanBeNull = false)]
        public string Title { get; set; }

        [Column(Name = "created", DbType = "DateTime Not Null", CanBeNull = false)]
        public DateTime Created { get; set; }

    }
}
