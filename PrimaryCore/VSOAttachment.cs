using DataObjectsProject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryCore
{
    public class VSOAttachment
    {
        private static DataObjectsProject.VSOJasonAttachmentUploadReturnData attachmentUploadReturnObject;
        private static List<DataObjectsProject.VSOJasonWorkItemPostData> wiPostDataArr;
        private static System.Net.Http.HttpContent httpStringContent;
        private static int workItemId;
        private static string attachmentName;
        public static bool AttachFiles(List<string> fileLocations, int itemId)
        {

            workItemId = itemId;
            foreach (string fileLocation in fileLocations)
            {
                FileInfo info = new FileInfo(fileLocation);
                byte[] bytes = File.ReadAllBytes(info.FullName);
                String file = Convert.ToBase64String(bytes);
                string url = String.Format(Models.VSO.Constants.APICalls.AttachItem, info.Name);

                Models.Helpers.JASONHelper.PostSimple(url, file, new Models.Helpers.JASONHelper.JSONReturnCallBack(attachmentReturn));

                attachmentName = info.Name;

                linkAttachment(itemId);
            }

            return true;
        }

        public static void linkAttachment(int itemId)
        {
            createInitailItemPostObject();

            string url = String.Format(Models.VSO.Constants.APICalls.UpdateWorkItem, itemId.ToString());       
           
            ConvertDataClassToJason(wiPostDataArr);

            Models.Helpers.JASONHelper.Patch(url, httpStringContent, new Models.Helpers.JASONHelper.JSONReturnCallBack(attachmentLinkReturn));
        }


        public static System.Net.Http.HttpContent ConvertDataClassToJason(object dataClass)
        {
            string wiPostDataString = Newtonsoft.Json.JsonConvert.SerializeObject(dataClass);

            return new System.Net.Http.StringContent(wiPostDataString, Encoding.UTF8, "application/json-patch+json");
        }


        
        private static void createInitailItemPostObject()
        {

            StringBuilder msg = new StringBuilder();
            msg.Append("[{");
            msg.Append("\"op\": \"add\",");
            msg.Append("\"path\": \"/relations/-\",");
            msg.Append("\"value\": {");
            msg.Append("\"rel\": \"AttachedFile\",");
            msg.Append(String.Format("\"url\": \"{0}\",", attachmentUploadReturnObject.URL));
            msg.Append("\"attributes\": {");
            msg.Append("\"comment\": \"Spec for the work\"");
            msg.Append("}");
            msg.Append("}");
            msg.Append("}]");
            httpStringContent = new System.Net.Http.StringContent(msg.ToString(), Encoding.UTF8, "application/json-patch+json");
        }

 
        private static void attachmentReturn(string jasonReturnString, string returnType)
        {
            attachmentUploadReturnObject = ConvertDataClassToAttachmentUploadReturnDataObject(jasonReturnString);

        }

        public static VSOJasonAttachmentUploadReturnData ConvertDataClassToAttachmentUploadReturnDataObject(string jasonString)
        {
            var wiPostDataString = Newtonsoft.Json.JsonConvert.DeserializeObject<VSOJasonAttachmentUploadReturnData>(jasonString);
            return wiPostDataString;

        }

        private static void attachmentLinkReturn(string jasonReturnString, string returnType)
        {
            
            VSOHistoryItem.Add(workItemId, String.Format("File {0} attached",attachmentName));
        }

    }
}
