using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectsProject
{
    public class VSOJasonWorkAttachmentPostData
    {
        public string FileName { get; set; }
        public string FileContent { get; set; }
        public string Data { get; set; }
        public bool ProcessData { get; set; }
    }
}
