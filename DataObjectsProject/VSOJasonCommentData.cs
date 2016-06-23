using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectsProject
{
    public class VSOJasonCommentData
    {
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

    }
}
