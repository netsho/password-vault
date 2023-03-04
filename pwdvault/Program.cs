using Serilog;
using pwdvault.Forms;
using pwdvault.Services;
using System.Diagnostics;

namespace pwdvault
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            /* ---------------------Create the logger for the application */
            string passwordVaultFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault");

            using var logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .WriteTo.File($@"{passwordVaultFolder}\log-.txt", rollingInterval: RollingInterval.Day, fileSizeLimitBytes: 1024*1024, rollOnFileSizeLimit: true)
                .CreateLogger();

            Log.Logger = logger;

            /* -------------------Create a new Password Vault folder in Local App Data to store any file and/or information related to the application */
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string PasswordVaultFolder = Path.Combine(appDataPath, "PasswordVault");
            if(!Directory.Exists(PasswordVaultFolder))
            {
                Directory.CreateDirectory(PasswordVaultFolder);
            }
            

            LoginForm loginForm = new LoginForm();
            Application.Run(new SignInForm());

            //if(loginForm.UserSuccessfullyAuthenticated)
            //{
            //    Application.Run(new MainForm());
            //}
        }
    }
}