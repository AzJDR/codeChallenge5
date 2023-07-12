namespace codeChallenge5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Create an instance of the Main form
            Main mainForm = new Main();

            // Center the form on the screen
            mainForm.StartPosition = FormStartPosition.CenterScreen;

            // Run the application
            Application.Run(mainForm);
        }
    }
}