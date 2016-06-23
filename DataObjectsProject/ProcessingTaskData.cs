using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectsProject
{
    public class ProcessingTaskData
    {
        public int WorkItemId { get; set; }
        public string Title;
        public string Tags;
        public string Description;
        public List<string> ScreenGrap; 
    }
}
