/*
 * Jesse Copier
 * TaakModel klas
 * 25-4-2024
 */

namespace Praktijkopdracht_T8.Model
{
    public class TaakModel
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Status { get; set; }
        public int ModuleId { get; set; }
    }
}
