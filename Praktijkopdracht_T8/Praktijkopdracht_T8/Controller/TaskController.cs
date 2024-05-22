/*
 * Jesse Copier
 * TaskController klas
 * 25-4-2024
 */

using Praktijkopdracht_T8.Model;
using System.Data.SqlClient;

namespace Praktijkopdracht_T8.Controller
{
    public class TaskController
    {
        private static string connectionString = @"Data Source=LAPTOP-FKB21FMN;Initial Catalog=PlanningDB;Integrated Security=True";

        public List<TaskModel> ReadAll(string status)
        {
            List<TaskModel> returnList = new();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sqlQuery = "SELECT TaakId AS TaskId, t.Naam AS Task, Omschrijving AS [Description], Startdatum AS Startdate, Inleverdatum AS DueDate, [Status], m.ModuleId, m.Naam AS Module, th.ThemaId AS ThemeId, th.Naam AS Theme, d.DocentId AS TeacherId, Voornaam AS FirstName, Tussenvoegsel AS Infix, Achternaam AS Surname, Afbeelding AS [Image] FROM Taak t INNER JOIN Module m ON t.ModuleId = m.ModuleId INNER JOIN Thema th ON m.ThemaId = th.ThemaId INNER JOIN Docent d ON d.DocentId = m.DocentId";
                if (status != "Alles")
                {
                    sqlQuery += " WHERE [Status] = @Status";
                }

                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    if (status != "Alles")
                    {
                        command.Parameters.AddWithValue("@Status", status);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnList.Add(new TaskModel
                        {
                            TaskId = (int)reader["TaskId"],
                            Name = (string)reader["Task"],
                            Description = (string)reader["Description"],
                            Startdate = ((DateTime)reader["Startdate"]).ToString("dd-MM-yyyy"),
                            DueDate = ((DateTime)reader["DueDate"]).ToString("dd-MM-yyyy"),
                            Status = (string)reader["Status"],
                            Module = new ModuleModel
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
                            }
                        });
                    }
                }
            }

            return returnList;
        }

        public List<string> GetStatus()
        {
            List<string> returnList = new();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sqlQuery = "SELECT DISTINCT [Status] FROM Taak;";
                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnList.Add((string)reader["Status"]);
                    }
                }
            }

            return returnList;
        }
    }
}
