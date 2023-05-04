namespace Capital_Avenue
{
    internal static class Program
    {
        public static CAWindow PageHome;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            PageHome = new CAWindow();
            Application.Run(PageHome);
        }
    }
}