namespace QLBanDT
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

<<<<<<< Updated upstream
            Application.Run(new Customer2());
=======
            Application.Run(new Order());
>>>>>>> Stashed changes

        }
    }
}