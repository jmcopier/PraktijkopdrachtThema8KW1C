/*
 * Jesse Copier
 * TaskForm
 * 22-5-2024
 */

using Praktijkopdracht_T8.Controller;
using Praktijkopdracht_T8.Model;
using System.Text;

namespace Praktijkopdracht_T8.View
{
    public partial class FrmTaskForm : Form
    {
        public FrmTaskForm()
        {
            InitializeComponent();

            // Vullen combobox
            taskComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> status = TaskController.GetStatus();

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

            taskListView.SelectedIndexChanged += TaskListView_SelectedIndexChanged;

            RefreshTaskListView(taskComboBox.Text);

            deleteTask.Enabled = false;
        }

        private void TaskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = taskComboBox.SelectedItem.ToString();
            RefreshTaskListView(selectedStatus);
        }

        private void TaskListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteTask.Enabled = taskListView.SelectedItems.Count > 0;
        }

        private void RefreshTaskListView(string status)
        {
            taskListView.Items.Clear();

            List<TaskModel> tasks = TaskController.ReadAll(status);

            foreach (TaskModel task in tasks)
            {
                ListViewItem item = new ListViewItem(task.Name);
                item.SubItems.Add(task.Startdate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(task.DueDate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(task.Status);
                item.SubItems.Add(task.Module.Name);

                item.Tag = task;

                taskListView.Items.Add(item);
            }
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            FrmAddTaksForm frm = new();
            frm.ShowDialog();
        }

        private void exportTask_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.Title = "CSV File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                ExportListViewToCSV(taskListView, saveFileDialog.FileName);
            }
        }

        private void ExportListViewToCSV(ListView listView, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ColumnHeader column in listView.Columns)
            {
                sb.Append(column.Text + ",");
            }
            sb.AppendLine();

            foreach (ListViewItem item in listView.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    sb.Append(subItem.Text + ",");
                }
                sb.AppendLine();
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshTaskListView(taskComboBox.Text);
        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = taskListView.SelectedItems[0];
            TaskModel selectedTask = (TaskModel)selectedItem.Tag;

            FrmDeleteTaskForm frm = new(selectedTask);
            frm.ShowDialog();
        }
    }
}
