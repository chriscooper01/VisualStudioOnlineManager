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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrimaryCore.SettingDataSave.VSOUserDetails(txtUsername.Text, txtPassword.Text);
            PrimaryCore.SettingDataSave.VSODetails(txtAcount.Text, txtProject.Text);
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            PrimaryCore.SettingDataGet.UserDetails(txtUsername, txtPassword);
            PrimaryCore.SettingDataGet.VSODetails(txtAcount, txtProject);
        }
    }
}
