using Praktijkopdracht_T8.Controller;
using Praktijkopdracht_T8.Model;

namespace Praktijkopdracht_T8.View
{
    public partial class FrmModuleForm : Form
    {
        public FrmModuleForm()
        {
            InitializeComponent();

            // Vullen listview
            moduleListView.Columns.Add("Module", 150);
            moduleListView.Columns.Add("Thema", 150);
            moduleListView.Columns.Add("Docent", -2);

            moduleListView.View = System.Windows.Forms.View.Details;
            moduleListView.FullRowSelect = true;

            List<ModuleModel> modules = ModuleController.ReadAll();

            foreach (ModuleModel module in modules)
            {
                ListViewItem item = new ListViewItem(module.Name);
                item.SubItems.Add(module.Theme.Name);
                if (module.Teacher.Infix == null)
                {
                    item.SubItems.Add($"{module.Teacher.FirstName} {module.Teacher.Surname}");
                }
                else
                {
                    item.SubItems.Add($"{module.Teacher.FirstName} {module.Teacher.Infix} {module.Teacher.Surname}");
                }

                item.Tag = module;

                moduleListView.Items.Add(item);
            }

            moduleListView.SelectedIndexChanged += ModuleListView_SelectedIndexChanged;

            teacher.Enabled = false;
        }

        private void ModuleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacher.Enabled = moduleListView.SelectedItems.Count > 0;
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = moduleListView.SelectedItems[0];
            ModuleModel selectedModule = (ModuleModel)selectedItem.Tag;

            FrmTeacherForm frm = new(selectedModule.Teacher);
            frm.ShowDialog();
        }
    }
}
