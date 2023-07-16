using pwdvault.Forms;
using Serilog;

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

            /* --------------------- Create a new Password Vault folder in Local App Data to store any file and/or information related to the application */
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var passwordVaultFolder = Path.Combine(appDataPath, "PasswordVault");
            var passwordVaultLogsFolder = Path.Combine(passwordVaultFolder, "Logs");
            if (!Directory.Exists(passwordVaultFolder)) Directory.CreateDirectory(passwordVaultFolder);
            if(!Directory.Exists(passwordVaultLogsFolder)) Directory.CreateDirectory(passwordVaultLogsFolder);


            /* --------------------- Create the logger for the application */
            using var logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .WriteTo.File($@"{passwordVaultLogsFolder}\log-.txt", rollingInterval: RollingInterval.Day, fileSizeLimitBytes: 1024 * 1024, rollOnFileSizeLimit: true)
                .CreateLogger();

            Log.Logger = logger;

            /* --------------------- Delete logs older than 1 month */
            var OneMonthOld = DateTime.Now.AddMonths(-1).Month;
            var files = Directory.GetFiles(passwordVaultFolder);
            foreach(var file in files )
            {
                var fileInfo = new FileInfo(file);
                if(fileInfo.CreationTime.Month < OneMonthOld)
                {
                    fileInfo.Delete();
                }
            }

            Application.Run(new LoginForm());
        }
    }
}