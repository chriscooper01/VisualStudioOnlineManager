using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Bug.Queries
{
    public class ArchiveQuery : Models.Bug.Helpers.LinqContextHelper
    {
        public static void Insert(int vsoId, string title)
        {

            try
            {
                using (var context = GetContext())
                {

                    var model = context.GetTable<Tables.ArchiveTable>();

                    var item = new Tables.ArchiveTable() { VSOId = vsoId, Title = title, Created = DateTime.Now};
                    model.InsertOnSubmit(item);
                    context.SubmitChanges();

                }

            }
            catch { }
        }
    }
}
