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
    public partial class WorkItemDetailForm : Form
    {
        public DataObjectsProject.ProcessingTaskData currentTask;
        public WorkItemDetailForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentTask.Title = txtTitle.Text;
            currentTask.Description = txtDescription.Text;
            this.Close();
        }
    }
}
