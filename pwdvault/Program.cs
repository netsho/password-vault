/*
Netsho - A secure application for managing and storing passwords.
Copyright (C) 2023-2024 Author : Netsho

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
        private static void Main()
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
                .WriteTo.File($@"{passwordVaultLogsFolder}\log-.txt", rollingInterval: RollingInterval.Day, fileSizeLimitBytes: 1024 * 1024, rollOnFileSizeLimit: true,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Source} {Message}{NewLine}{Exception}")
                .CreateLogger();

            Log.Logger = logger;

            /* --------------------- Delete logs older than 1 month */
            var oneMonthOld = DateTime.Now.AddMonths(-1).Month;
            var files = Directory.GetFiles(passwordVaultFolder);
            foreach(var file in files )
            {
                var fileInfo = new FileInfo(file);
                if(fileInfo.CreationTime.Month < oneMonthOld)
                {
                    fileInfo.Delete();
                }
            }

            Application.Run(new LoginForm());
        }
    }
}