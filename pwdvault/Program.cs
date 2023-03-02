using pwdvault.Forms;

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
            LoginForm loginForm = new LoginForm();
            Application.Run(new SignInForm());

            //if(loginForm.UserSuccessfullyAuthenticated)
            //{
            //    Application.Run(new MainForm());
            //}
        }
    }
}