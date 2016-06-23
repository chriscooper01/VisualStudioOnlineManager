using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.VSO.Constants
{
    public class APICalls
    {
        public static string VSOVersion = "1.0";
        public static string Instance = "healthdiagnostics.visualstudio.com";
        public static string DefaltURL = "https://healthdiagnostics.visualstudio.com/DefaultCollection/Health Options/_apis/wit/";        
        public static string GetItemById = "workitems?api-version={version}&ids={id}";

        public static string AttachItem = "https://[ACCOUNT].visualstudio.com/DefaultCollection/_apis/wit/attachments?filename={0}&api-version=1.0";
        public static string NewWorkItem = "https://[ACCOUNT].visualstudio.com/DefaultCollection/[PROJECT]/_apis/wit/workitems/$Task?api-version=1.0";
        public static string UpdateWorkItem = "https://healthdiagnostics.visualstudio.com/DefaultCollection/_apis/wit/workitems/{0}?api-version=1.0";
        public static string GetAllItems = "https://[ACCOUNT]/DefaultCollection/_apis/wit/workitems?api-version={version}";

    }
}

