using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktijkopdracht_T8.View
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Wachtwoord kan niet leeg zijn.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var config = ConfigurationManager.ConnectionStrings["RDSConnection"];
                var builder = new SqlConnectionStringBuilder(config.ConnectionString)
                {
                    Password = password
                };

                using (var connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                }

                UpdateConnectionString(password);

                MessageBox.Show("Inloggen succesvol", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMainWindow mainWindow = new FrmMainWindow();
                mainWindow.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is iets misgegaan!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateConnectionString(string password)
        {
            // Update the connection string in the app.config with the correct password.
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringSettings = config.ConnectionStrings.ConnectionStrings["RDSConnection"];

            if (connectionStringSettings != null)
            {
                connectionStringSettings.ConnectionString = connectionStringSettings.ConnectionString.Replace("PLACEHOLDER_PASSWORD", password);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
            }
        }
    }
}
