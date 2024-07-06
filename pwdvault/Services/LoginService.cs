using Npgsql;
using pwdvault.Models;
using Serilog;
using System.Configuration;
using System.Text.Json;

namespace pwdvault.Services
{
    public static class LoginService
    {
        private static readonly string LoginDataPath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault"), "LoginData.json");

        /// <summary>
        /// Creates a JSON in Local Application Data folder to store additional login data.
        /// </summary>
        public static void StoreLoginData(string caFilePath, string certificateFilePath, string keyFilePath, string secretId)
        {
            try
            {
                var loginData = new List<LoginData>
                { new()
                    {
                        CaFilePath = caFilePath,
                        CertificateFilePath = certificateFilePath,
                        KeyFilePath = keyFilePath,
                        SecretId = secretId
                    }
                };
                JsonSerializerOptions jsonSerializerOptions = new() { WriteIndented = true };
                string jsonLogin = JsonSerializer.Serialize(loginData, jsonSerializerOptions);
                File.WriteAllText(LoginDataPath, jsonLogin);
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
        public static LoginData RetrieveLoginData()
        {
            try
            {
                var jsonLoginData = File.ReadAllText(LoginDataPath);
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
        public static void AddLoginDataConfig(string caFilePath, string certificateFilePath, string keyFilePath)
        {
            var appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString;

            connectionString = UpdateConnectionStringParameter(connectionString, "root certificate", caFilePath);
            connectionString = UpdateConnectionStringParameter(connectionString, "ssl certificate", certificateFilePath);
            connectionString = UpdateConnectionStringParameter(connectionString, "ssl key", keyFilePath);

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

        /// <summary>
        /// Tests the connection to PostGreSql database using the SSL certificates provided by the user.
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> TestPgSqlConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString;

            await using var npgsqlConnection = new NpgsqlConnection(connectionString);
            await npgsqlConnection.OpenAsync();
            return npgsqlConnection.State == System.Data.ConnectionState.Open;
        }
    }
}
