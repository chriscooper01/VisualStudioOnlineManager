using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectsProject
{
    public class VSOJasonWorkItemAttachmentPostData
    {
     
        [JsonProperty(PropertyName = "rel")]
        public string Reference;
        [JsonProperty(PropertyName = "url")]
        public string URL;
        [JsonProperty(PropertyName = "attributes")]
        public List<object> Attributes;
        
        
    }
}
