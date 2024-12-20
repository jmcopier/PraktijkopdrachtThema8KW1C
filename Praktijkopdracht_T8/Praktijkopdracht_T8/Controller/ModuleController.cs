/*
 * Jesse Copier
 * ModuleController klas
 * 22-5-2024
 */

using Praktijkopdracht_T8.Model;
using System.Data.SqlClient;

namespace Praktijkopdracht_T8.Controller
{
    public static class ModuleController
    {
        private static string connectionString = @"Data Source=LAPTOP-FKB21FMN;Initial Catalog=PlanningDB;Integrated Security=True";

        public static List<ModuleModel> ReadAll()
        {
                List<ModuleModel> returnList = new();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sqlQuery = "SELECT m.ModuleId, m.Naam AS Module, t.ThemaId AS ThemeId, t.Naam AS Theme, d.DocentId AS TeacherId, d.Voornaam AS FirstName, d.Tussenvoegsel AS Infix, d.Achternaam AS Surname, d.Afbeelding AS [Image] FROM Module m INNER JOIN Thema t ON t.ThemaId = m.ThemaId INNER JOIN Docent d ON d.DocentId = m.DocentId;";

                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnList.Add(new ModuleModel
                        {
                            ModuleId = (int)reader["ModuleId"],
                            Name = (string)reader["Module"],
                            Theme = new ThemeModel
                            {
                                ThemeId = (int)reader["ThemeId"],
                                Name = (string)reader["Theme"]
                            },
                            Teacher = new TeacherModel
                            {
                                TeacherId = (int)reader["TeacherId"],
                                FirstName = (string)reader["FirstName"],
                                Infix = reader["Infix"] == DBNull.Value ? null : (string)reader["Infix"],
                                Surname = (string)reader["Surname"],
                                Image = (string)reader["Image"]
                            }
                        });
                    }
                }
            }

            return returnList;
        }
    }
}
