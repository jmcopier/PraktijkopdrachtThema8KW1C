using Praktijkopdracht_T8.Controller;
using Praktijkopdracht_T8.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

                moduleListView.Items.Add(item);
            }
        }
    }
}
