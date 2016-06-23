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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = new DataObjectsProject.TaskItem();
            item.Title = txtTitle.Text.Trim();
            item.Tags = txtTag.Text.Trim().Replace(" ", ",");
            item.Description = txtDescription.Text.Trim();
            //PrimaryCore.VSOWorkItem.CreateNewItem(item);

            //PrimaryCore.VSOAttachment.AttachFiles(new List<string>() { @"c:\Temp\test.txt" }, itemId);
        }
    }
}
