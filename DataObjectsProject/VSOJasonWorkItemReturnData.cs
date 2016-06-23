using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectsProject
{
    
    public class VSOJasonWorkItemReturnData
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "rev")]
        public int Rev { get; set; }
        [JsonProperty(PropertyName = "fields")]
        public JsonArrayAttribute  Fields { get; set; }
        [JsonProperty(PropertyName = "links")]
        public JsonArrayAttribute Links { get; set; }
        
    }
}
