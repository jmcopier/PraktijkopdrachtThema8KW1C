/*
 * Jesse Copier
 * TaakModel klas
 * 25-4-2024
 */

namespace Praktijkopdracht_T8.Model
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Startdate { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
        public ModuleModel Module { get; set; }
    }
}
