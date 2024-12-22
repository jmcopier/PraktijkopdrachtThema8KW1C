/*
 * Jesse Copier
 * AddTaskForm
 * 22-5-2024
 */

using Praktijkopdracht_T8.Controller;
using Praktijkopdracht_T8.Model;

namespace Praktijkopdracht_T8.View
{
    public partial class FrmAddTaksForm : Form
    {
        public FrmAddTaksForm()
        {
            InitializeComponent();

            // Vullen status combobox
            statusCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> status = TaskController.GetStatus();

            for (int i = 0; i < status.Count; i++)
            {
                statusCombo.Items.Add(status[i]);
                if (i == 0)
                {
                    statusCombo.SelectedItem = status[i];
                }
            }

            // Vullen module combobox
            moduleCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            List<ModuleModel> modules = ModuleController.ReadAll();
            List<string> displayList = new();

            for (int i = 0; i < modules.Count; i++)
            {
                displayList.Add(modules[i].Name + ", " + modules[i].Theme.Name);
            }

            moduleCombo.DataSource = modules;
            moduleCombo.DisplayMember = "DisplayName";
            moduleCombo.ValueMember = "ModuleId";

        }

        private void addTask_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;
            DateTime startdate = txtStartdate.Value;
            DateTime dueDate = txtDueDate.Value;
            string status = statusCombo.SelectedItem.ToString();
            ModuleModel selectedModule = new ModuleModel
            {
                ModuleId = (int)moduleCombo.SelectedValue
            };

            TaskModel task = new TaskModel
            {
                Name = name,
                Description = description,
                Startdate = startdate,
                DueDate = dueDate,
                Status = status,
                Module = selectedModule
            };

            if (TaskController.Create(task) > 0)
            {
                this.Close();
            }
        }
    }
}
