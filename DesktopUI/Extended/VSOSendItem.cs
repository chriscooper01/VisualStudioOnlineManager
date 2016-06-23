using PrimaryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.Extended
{
    public class VSOSendItem
    {
        public static bool WorkItem(ref DataObjectsProject.ProcessingTaskData item, Label archive)
        {
            MessageDisplay.ShowMessageAsync("Creating work item");
            VSOWorkItem.CreateNewItem(ref item);
            if(item.Equals(0))
            {
                MessageDisplay.ShowMessageAsync("Item not created");
                 
                return false;
            }else
            {
                MessageDisplay.ShowMessageAsync("Item created");
                increaseArchiveNumber(archive);
                return true;
            }
        }

        public static bool Attachments(DataObjectsProject.ProcessingTaskData item)
        {               
            if(item.WorkItemId > 0)
            {
                MessageDisplay.ShowMessageAsync("Attaching items");
                if (VSOAttachment.AttachFiles(item.ScreenGrap, item.WorkItemId))
                {
                    MessageDisplay.ShowMessageAsync("Items attached");
                    return false;
                }
                else
                {
                    MessageDisplay.ShowMessageAsync("Items not attached");

                    return true;
                }
            }
            return false;
            
        }

        private static void increaseArchiveNumber(Label archive)
        {
            int currentNumber = 1;
            int.TryParse(archive.Text, out currentNumber);
            currentNumber++;
            archive.Text = currentNumber.ToString();
            archive.Visible = true;
        }

    }
}
