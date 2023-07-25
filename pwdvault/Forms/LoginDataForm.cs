using pwdvault.Modeles;
using System.Configuration;
using System.Text.Json;
using Serilog;
using pwdvault.Controllers;

namespace pwdvault.Forms
{
    public partial class LoginDataForm : Form
    {
        private readonly string _username;
        private readonly string _loginDataPath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault"), "LoginData.json");

        public LoginDataForm(string username)
        {
            InitializeComponent();
            _username = username;
            if(File.Exists(_loginDataPath))
            {
                var loginData = RetrieveLoginData();
                txtBoxCA.Text = loginData.CaFilePath;
                txtBoxCertificate.Text = loginData.CertificateFilePath;
                txtBoxKey.Text = loginData.KeyFilePath;
                txtBoxSecretId.Text = loginData.SecretID;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxCA.Text) ||
                String.IsNullOrWhiteSpace(txtBoxCertificate.Text) ||
                String.IsNullOrWhiteSpace(txtBoxKey.Text) ||
                String.IsNullOrWhiteSpace(txtBoxSecretId.Text))
            {
                MessageBox.Show("Please complete all fields.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    AddLoginDataConfig();

                    var vaultServerUri = ConfigurationManager.AppSettings["VaultServerUri"];
                    var roleID = ConfigurationManager.AppSettings["RoleID"];
                    var secretPath = ConfigurationManager.AppSettings["SecretPath"];
                    VaultController.GetInstance(roleID!, txtBoxSecretId.Text, vaultServerUri!, secretPath!);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
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
            var openFileDialogCA = new OpenFileDialog
            {
                Filter = "CA files (*.crt)|*.crt|All files (*.*)|*.*" 
            };

            if (openFileDialogCA.ShowDialog() == DialogResult.OK)
            {
                txtBoxCA.Text = openFileDialogCA.FileName;
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
            if(checkBoxInfo.Checked)
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
            {
                new LoginData()
                {
                    CaFilePath = txtBoxCA.Text,
                    CertificateFilePath = txtBoxCertificate.Text,
                    KeyFilePath = txtBoxKey.Text,
                    SecretID = txtBoxSecretId.Text
                }
            };
                var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
                string jsonLogin = JsonSerializer.Serialize(loginData, jsonOptions);
                File.WriteAllText(_loginDataPath, jsonLogin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
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
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                return new LoginData();
            }
        }

        /// <summary>
        /// Updates the connection string in the application's configuration file by adding the username and needed certificates for SSL connection.
        /// </summary>
        private void AddLoginDataConfig()
        {
            var appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString;
            connectionString += "user id=" + _username + ";";
            connectionString += "ssl mode=verifyfull;";
            connectionString += "root certificate=" + txtBoxCA.Text + ";";
            connectionString += "ssl certificate=" + txtBoxCertificate.Text + ";";
            connectionString += "ssl key=" + txtBoxKey.Text + ";";
            appConfig.ConnectionStrings.ConnectionStrings.Remove(ConfigurationManager.ConnectionStrings["ConnectionDb"]);
            appConfig.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("ConnectionDb", connectionString));
            appConfig.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
