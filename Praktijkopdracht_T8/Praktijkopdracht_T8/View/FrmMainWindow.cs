using Praktijkopdracht_T8.View;

namespace Praktijkopdracht_T8
{
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void taskBtn_Click(object sender, EventArgs e)
        {
            FrmTaskForm frmTask = new();

            frmTask.TopLevel = false;
            frmTask.FormBorderStyle = FormBorderStyle.None;
            frmTask.WindowState = FormWindowState.Maximized;
            frmTask.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(frmTask);

            frmTask.Show();
        }
    }
}
