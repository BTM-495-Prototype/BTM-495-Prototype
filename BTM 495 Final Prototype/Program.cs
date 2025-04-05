namespace BTM_495_Final_Prototype
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application, displays the login screen to user upon access.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage()); // creating the login page, the start position of user interation with GUI
        }
    }
}