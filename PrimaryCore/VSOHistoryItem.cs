using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryCore
{
    class VSOHistoryItem
    {

        private static System.Net.Http.HttpContent httpStringContent;
        private static string historyText;
        public static void Add(int workItemId, string text)
        {
            historyText = text;
            string url = String.Format(Models.VSO.Constants.APICalls.UpdateWorkItem, workItemId.ToString());
            createInitailItemPostObject();


            Models.Helpers.JASONHelper.Patch(url, httpStringContent, new Models.Helpers.JASONHelper.JSONReturnCallBack(historyLinkReturn));
        }

        private static void createInitailItemPostObject()
        {

            StringBuilder msg = new StringBuilder();
            msg.Append("[{");
            msg.Append("\"op\": \"add\",");
            msg.Append("\"path\": \"/fields/System.History\", ");
            msg.Append(String.Format("\"value\": \"{0}\"",historyText));       
            msg.Append("}]");
            httpStringContent = new System.Net.Http.StringContent(msg.ToString(), Encoding.UTF8, "application/json-patch+json");
        }


        private static void historyLinkReturn(string jasonReturnString, string returnType)
        {


        }
    }
}
