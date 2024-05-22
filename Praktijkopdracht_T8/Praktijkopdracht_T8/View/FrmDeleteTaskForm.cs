using Praktijkopdracht_T8.Controller;
using Praktijkopdracht_T8.Model;

namespace Praktijkopdracht_T8.View
{
    public partial class FrmDeleteTaskForm : Form
    {
        private TaskModel task;
        public FrmDeleteTaskForm(TaskModel task)
        {
            InitializeComponent();
            this.task = task;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            if (TaskController.Delete(task) > 0)
            {
                this.Close();
            }
        }
    }
}
