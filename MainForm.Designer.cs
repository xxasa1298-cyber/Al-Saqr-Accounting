namespace SAQR_ERP_Client
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelSidebar;
        private Panel panelContainer;
        private Button btnDashboard;
        private Button btnUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSidebar = new Panel();
            this.btnUsers = new Button();
            this.btnDashboard = new Button();
            this.panelContainer = new Panel();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();

            // panelSidebar
            this.panelSidebar.BackColor = Color.FromArgb(30, 30, 30);
            this.panelSidebar.Controls.Add(this.btnUsers);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Width = 200;

            // btnDashboard
            this.btnDashboard.Dock = DockStyle.Top;
            this.btnDashboard.Height = 50;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.ForeColor = Color.White;
            this.btnDashboard.FlatStyle = FlatStyle.Flat;
            this.btnDashboard.Click += new EventHandler(this.btnDashboard_Click);

            // btnUsers
            this.btnUsers.Dock = DockStyle.Top;
            this.btnUsers.Height = 50;
            this.btnUsers.Text = "Users";
            this.btnUsers.ForeColor = Color.White;
            this.btnUsers.FlatStyle = FlatStyle.Flat;
            this.btnUsers.Click += new EventHandler(this.btnUsers_Click);

            // panelContainer
            this.panelContainer.Dock = DockStyle.Fill;
            this.panelContainer.BackColor = Color.FromArgb(45, 45, 45);

            // MainForm
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSidebar);
            this.Text = "SAQR ERP Client";
            this.WindowState = FormWindowState.Maximized;

            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
