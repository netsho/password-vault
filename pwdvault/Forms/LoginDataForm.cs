/*
Netsho - Additional data login form. 
Copyright (C) 2023-2024 Netsho

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <https://www.gnu.org/licenses/>.
*/
using pwdvault.Models;
using System.Configuration;
using System.Text.Json;
using Serilog;
using pwdvault.Controllers;

namespace pwdvault.Forms
{
    public partial class LoginDataForm : Form
    {
        private readonly string _loginDataPath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault"), "LoginData.json");

        public LoginDataForm()
        {
            InitializeComponent();
            if (!File.Exists(_loginDataPath)) return;
            var loginData = RetrieveLoginData();
            txtBoxCA.Text = loginData.CaFilePath;
            txtBoxCertificate.Text = loginData.CertificateFilePath;
            txtBoxKey.Text = loginData.KeyFilePath;
            txtBoxSecretId.Text = loginData.SecretId;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxCA.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCertificate.Text) ||
                string.IsNullOrWhiteSpace(txtBoxKey.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSecretId.Text))
            {
                MessageBox.Show("Please complete all fields.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    AddLoginDataConfig();

                    var vaultServerUri = ConfigurationManager.AppSettings["VaultServerUri"];
                    var roleId = ConfigurationManager.AppSettings["RoleID"];
                    var secretPath = ConfigurationManager.AppSettings["SecretPath"];
                    VaultController.GetInstance(roleId!, txtBoxSecretId.Text, vaultServerUri!, secretPath!);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------ File dialogs buttons to retrieve certificates -------------------------------------------------------------------*/
        private void BtnFileDialogCA_Click(object sender, EventArgs e)
        {
            var openFileDialogCa = new OpenFileDialog
            {
                Filter = "CA files (*.crt)|*.crt|All files (*.*)|*.*"
            };

            if (openFileDialogCa.ShowDialog() == DialogResult.OK)
            {
                txtBoxCA.Text = openFileDialogCa.FileName;
            }
        }

        private void BtnFileDialogCert_Click(object sender, EventArgs e)
        {
            var openFileDialogCertificate = new OpenFileDialog
            {
                Filter = "Certificate files (*.crt)|*.crt|All files (*.*)|*.*"
            };

            if (openFileDialogCertificate.ShowDialog() == DialogResult.OK)
            {
                txtBoxCertificate.Text = openFileDialogCertificate.FileName;
            }
        }

        private void BtnFileDialogKey_Click(object sender, EventArgs e)
        {
            var openFileDialogKey = new OpenFileDialog
            {
                Filter = "Key files (*.key)|*.key|All files (*.*)|*.*"
            };

            if (openFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                txtBoxKey.Text = openFileDialogKey.FileName;
            }
        }
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/

        private void CheckBoxInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInfo.Checked)
            {
                StoreLoginData();
            }
        }

        /// <summary>
        /// Creates a JSON in Local Application Data folder to store additional login data.
        /// </summary>
        private void StoreLoginData()
        {
            try
            {
                var loginData = new List<LoginData>
                { new() 
                    {
                        CaFilePath = txtBoxCA.Text,
                        CertificateFilePath = txtBoxCertificate.Text,
                        KeyFilePath = txtBoxKey.Text,
                        SecretId = txtBoxSecretId.Text
                    }
                };
                JsonSerializerOptions jsonSerializerOptions = new() { WriteIndented = true };
                string jsonLogin = JsonSerializer.Serialize(loginData, jsonSerializerOptions);
                File.WriteAllText(_loginDataPath, jsonLogin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
            }
        }

        /// <summary>
        /// Retrieves the stored additional login data in the JSON file, LoginData.json
        /// </summary>
        /// <returns></returns>
        private LoginData RetrieveLoginData()
        {
            try
            {
                var jsonLoginData = File.ReadAllText(_loginDataPath);
                var listLoginData = JsonSerializer.Deserialize<List<LoginData>>(jsonLoginData);
                return listLoginData!.FirstOrDefault() ?? new LoginData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                return new LoginData();
            }
        }

        /// <summary>
        /// Updates the connection string in the application's configuration file by adding the username and the certificates needed for SSL connection.
        /// </summary>
        private void AddLoginDataConfig()
        {
            var appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString;

            connectionString = UpdateConnectionStringParameter(connectionString, "root certificate", txtBoxCA.Text);
            connectionString = UpdateConnectionStringParameter(connectionString, "ssl certificate", txtBoxCertificate.Text);
            connectionString = UpdateConnectionStringParameter(connectionString, "ssl key", txtBoxKey.Text);

            appConfig.ConnectionStrings.ConnectionStrings.Remove(ConfigurationManager.ConnectionStrings["ConnectionDb"]);
            appConfig.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("ConnectionDb", connectionString));
            appConfig.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        /// <summary>
        /// Checks if a parameter already exists in the connection string. If it does, it updates its value; otherwise, it adds the parameter with its value to the connection string.
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="parameterName"></param>
        /// <param name="parameterValue"></param>
        /// <returns></returns>
        private static string UpdateConnectionStringParameter(string connectionString, string parameterName, string parameterValue)
        {
            if (!connectionString.Contains(parameterName + "="))
            {
                connectionString += $"{parameterName}={parameterValue};";
            }
            else
            {
                var parameterStart = connectionString.IndexOf(parameterName + "=", StringComparison.OrdinalIgnoreCase);
                var valueStartIndex = parameterStart + parameterName.Length + 1;
                var valueEndIndex = connectionString.IndexOf(';', valueStartIndex);
                if (valueEndIndex == -1) valueEndIndex = connectionString.Length;

                var currentValue = connectionString.Substring(valueStartIndex, valueEndIndex - valueStartIndex);
                connectionString = connectionString.Replace(currentValue, parameterValue);
            }
            return connectionString;
        }
    }
}
