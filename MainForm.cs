using System;
using System.Windows.Forms;

namespace SAQR_ERP_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            panelContainer.Controls.Clear();
            var dash = new UserControlDashboard();
            dash.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(dash);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            var users = new UserControlUsers();
            users.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(users);
        }
    }
}
