/*
 * Jesse Copier
 * ModuleModel klas
 * 21-5-2024
 */

namespace Praktijkopdracht_T8.Model
{
    public class ModuleModel
    {
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public ThemeModel Theme { get; set; }
        public TeacherModel Teacher { get; set; }

        public string DisplayName
        {
            get
            {
                return $"{Name}, {Theme.Name}";
            }
        }
    }
}
