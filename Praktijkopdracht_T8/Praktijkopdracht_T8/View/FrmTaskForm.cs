using Praktijkopdracht_T8.Controller;
using Praktijkopdracht_T8.Model;

namespace Praktijkopdracht_T8.View
{
    public partial class FrmTaskForm : Form
    {
        private TaskController taskController = new();
        public FrmTaskForm()
        {
            InitializeComponent();

            // Vullen combobox
            taskComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> status = taskController.GetStatus();

            taskComboBox.Items.Add("Alles");

            foreach (string s in status)
            {
                taskComboBox.Items.Add(s);
            }

            taskComboBox.SelectedItem = "Alles";

            taskComboBox.SelectedIndexChanged += TaskComboBox_SelectedIndexChanged;

            // Vullen listview
            taskListView.Columns.Add("Taak", 120);
            taskListView.Columns.Add("Startdatum", 80);
            taskListView.Columns.Add("Inleverdatum", 80);
            taskListView.Columns.Add("Status", 80);
            taskListView.Columns.Add("Module", -2);

            taskListView.View = System.Windows.Forms.View.Details;
            taskListView.FullRowSelect = true;

            RefreshTaskListView(taskComboBox.Text);

            deleteTask.Enabled = false;
        }

        private void TaskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = taskComboBox.SelectedItem.ToString();
            RefreshTaskListView(selectedStatus);
        }

        private void RefreshTaskListView(string status)
        {
            taskListView.Items.Clear();

            List<TaskModel> tasks = taskController.ReadAll(status);

            foreach (TaskModel task in tasks)
            {
                ListViewItem item = new ListViewItem(task.Name);
                item.SubItems.Add(task.Startdate);
                item.SubItems.Add(task.DueDate);
                item.SubItems.Add(task.Status);
                item.SubItems.Add(task.Module.Name);

                item.Tag = task;

                taskListView.Items.Add(item);
            }
        }
    }
}
