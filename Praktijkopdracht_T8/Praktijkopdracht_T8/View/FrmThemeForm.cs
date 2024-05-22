
using Praktijkopdracht_T8.Controller;
using Praktijkopdracht_T8.Model;

namespace Praktijkopdracht_T8.View
{
    public partial class FrmThemeForm : Form
    {
        public FrmThemeForm()
        {
            InitializeComponent();

            // Vullen listview
            themeList.Columns.Add("Thema", -2);

            themeList.View = System.Windows.Forms.View.Details;
            themeList.FullRowSelect = true;

            List<ThemeModel> themes = ThemeController.ReadAll();

            foreach (ThemeModel theme in themes)
            {
                ListViewItem item = new ListViewItem(theme.Name);

                themeList.Items.Add(item);
            }
        }
    }
}
