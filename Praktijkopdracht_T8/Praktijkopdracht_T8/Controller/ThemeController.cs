/*
 * Jesse Copier
 * ThemeController klas
 * 22-5-2024
 */

using Praktijkopdracht_T8.Model;
using System.Data.SqlClient;

namespace Praktijkopdracht_T8.Controller
{
    public static class ThemeController
    {
        private static string connectionString = @"Data Source=LAPTOP-FKB21FMN;Initial Catalog=PlanningDB;Integrated Security=True";

        public static List<ThemeModel> ReadAll()
        {
            List<ThemeModel> returnList = new();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sqlQuery = "SELECT ThemaId AS ThemeId, Naam AS [Name] FROM Thema";
                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnList.Add(new ThemeModel
                        {
                            ThemeId = (int)reader["ThemeId"],
                            Name = (string)reader["Name"]
                        });
                    }
                }
            }

            return returnList;
        }
    }
}
