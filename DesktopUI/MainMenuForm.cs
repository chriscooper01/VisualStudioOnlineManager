using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI
{
    public partial class MainMenuForm : Form
    {

        private DataObjectsProject.ProcessingTaskData currentTask;
        
        public MainMenuForm()
        {
            InitializeComponent();
            currentTask = new DataObjectsProject.ProcessingTaskData();
            currentTask.ScreenGrap = new List<string>();
        }

        private void pctImage_Click(object sender, EventArgs e)
        {
           
            this.Refresh();


            string path = PrimaryCore.ScreenGrap.GetPrimary("primary");
            currentTask.ScreenGrap.Add(path);

            Extended.MessageDisplay.ShowMessageAsync("Screen grabbed");
            Extended.ImagePreview.Show(path);

        
        }

        private void pctSettings_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void pctSave_Click(object sender, EventArgs e)
        {
            Extended.VSOSendItem.WorkItem(ref currentTask, lblArchivedTaskNumber);
            Extended.VSOSendItem.Attachments( currentTask);
            PrimaryCore.ScreenGrap.CleanUp();

            currentTask = new DataObjectsProject.ProcessingTaskData();
        }

        private void pctBug_Click(object sender, EventArgs e)
        {
            var form = new WorkItemDetailForm();
            form.currentTask = currentTask;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            currentTask = form.currentTask;


            pctSave.Enabled = !String.IsNullOrEmpty(currentTask.Title);
        }

        private void pctArchive_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not yet available");
        }
    }
}
