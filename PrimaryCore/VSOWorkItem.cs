using DataObjectsProject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaryCore
{
    public class VSOWorkItem
    {

        private static List<DataObjectsProject.VSOJasonWorkItemPostData> wiPostDataArr;
        private static DataObjectsProject.VSOJasonWorkItemReturnData initailJasonReturnObject;
        private static DataObjectsProject.ProcessingTaskData newTaskItem;
                

        public static void CreateNewItem(ref DataObjectsProject.ProcessingTaskData item)
        {
            wiPostDataArr = new List<DataObjectsProject.VSOJasonWorkItemPostData>();
            newTaskItem = item;
            
            createInitailItemPostObject();

            createInitialWorkItem();

            item = newTaskItem;
            if(item.WorkItemId > 0)
            {
                Models.Bug.Queries.ArchiveQuery.Insert(item.WorkItemId, item.Title);
            }
        }


        private static void createInitailItemPostObject()
        {
            if (!String.IsNullOrEmpty(newTaskItem.Title))
                AddUpdateProp("/fields/System.Title", newTaskItem.Title);
            if(!String.IsNullOrEmpty(newTaskItem.Tags))
                AddUpdateProp("/fields/System.Tags", newTaskItem.Tags);
            if (!String.IsNullOrEmpty(newTaskItem.Description))
                AddUpdateProp("/fields/System.Description", newTaskItem.Description);
                       
        }

        private static void AddUpdateProp( string field, object value)
        {            
            DataObjectsProject.VSOJasonWorkItemPostData wiPostData = new DataObjectsProject.VSOJasonWorkItemPostData();
            wiPostData.op = "add";
            wiPostData.path = field;
            wiPostData.value = value;
            wiPostDataArr.Add(wiPostData);           
        }
        
        private static void createInitialWorkItem()
        {
            Models.Helpers.JASONHelper.Post(Models.VSO.Constants.APICalls.NewWorkItem, ConvertDataClassToJason(wiPostDataArr), "createtask", new Models.Helpers.JASONHelper.JSONReturnCallBack(newTaskReturn));         
        }
        
      
        private static void newTaskReturn(string jasonReturnString, string returnType)
        {
            initailJasonReturnObject = ConvertDataClassToWorkItemReturnDataObject(jasonReturnString);
            newTaskItem.WorkItemId = initailJasonReturnObject.Id;
        }
        public static VSOJasonWorkItemReturnData ConvertDataClassToWorkItemReturnDataObject(string jasonString)
        {
            var wiPostDataString = Newtonsoft.Json.JsonConvert.DeserializeObject<VSOJasonWorkItemReturnData>(jasonString);
            return wiPostDataString;

        }



        public static System.Net.Http.HttpContent ConvertDataClassToJason(object dataClass)
        {
            string wiPostDataString = Newtonsoft.Json.JsonConvert.SerializeObject(dataClass);

            return new System.Net.Http.StringContent(wiPostDataString, Encoding.UTF8, "application/json-patch+json");
        }

    }
}
