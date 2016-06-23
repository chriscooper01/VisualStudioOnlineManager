using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI
{
    public partial class MessageForm : Form
    {
        public string Message { private get; set; }

        public MessageForm()
        {
            InitializeComponent();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = Message;

        }

        private void MessageForm_Shown(object sender, EventArgs e)
        {
            lblMessage.Refresh();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Location = new Point(this.Location.X, this.Location.Y + 15);
            Thread.Sleep(1000);
            this.Close();
        }
    }
}
